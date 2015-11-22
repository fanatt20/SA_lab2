using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Algorithms;
using Algorithms.Extensions;
using UI.Properties;

namespace UI
{
    public partial class MainForm : Form
    {
        private readonly DataHolder.DataHolder _data = new DataHolder.DataHolder();

        private readonly Dictionary<Matrix.BType, RadioButton> _matrixBRadioButtons =
            new Dictionary<Matrix.BType, RadioButton>();

        private readonly OpenFileDialog _openFile;

        private readonly Dictionary<PolinomType, RadioButton> _polinomRadioButtons =
            new Dictionary<PolinomType, RadioButton>();

        private readonly SaveFileDialog _saveFile;


        private readonly List<int> _variablesDimension = new List<int> { 0, 0, 0 };

        private int _maxMeterageCount;

        public MainForm()
        {
            InitializeComponent();

            _openFile = new OpenFileDialog { Multiselect = false, Filter = Resources.File_Fileter_Txt };
            _saveFile = new SaveFileDialog { Filter = Resources.File_Fileter_Txt };

            _polinomRadioButtons.Add(PolinomType.Chebyshev, radioPolinomChebyshev);
            _polinomRadioButtons.Add(PolinomType.Hermit, radioPolinomHermit);
            _polinomRadioButtons.Add(PolinomType.Lagger, radioPolinomLagger);
            _polinomRadioButtons.Add(PolinomType.Lejandr, radioPolinomLejandr);

            _matrixBRadioButtons.Add(Matrix.BType.Type1, radioBType1);
            _matrixBRadioButtons.Add(Matrix.BType.Type2, radioBType2);
            _matrixBRadioButtons.Add(Matrix.BType.Type3, radioBType3);

            _variablesDimension[0] = (int)numVar1Dim.Value;
            _variablesDimension[1] = (int)numVar2Dim.Value;
            _variablesDimension[2] = (int)numVar3Dim.Value;

            Log.Target = txtLog;
            Log.WriteLine(DateTime.Now);
            Log.WriteLine();
        }

        private PolinomType _polinomType
        {
            get { return _polinomRadioButtons.First(pair => pair.Value.Checked).Key; }
        }

        private void TextBoxOpenFileAction(object sender, MouseEventArgs e)
        {
            var txtBox = sender as TextBox;
            if (txtBox == null)
                throw new ArgumentException("Sender must be textbox");

            _openFile.FileName = txtBox.Text ?? string.Empty;
            _openFile.ShowDialog();
            if (_openFile.FileName != null)
            {
                txtBox.Text = _openFile.FileName;
            }
        }

        private void TextBoxSaveFileAction(object sender, MouseEventArgs e)
        {
            var txtBox = sender as TextBox;
            if (txtBox == null)
                throw new ArgumentException("Sender must be textbox");
            _saveFile.FileName = txtBox.Text ?? string.Empty;
            _openFile.ShowDialog();
            if (_openFile.FileName != null)
            {
                txtBox.Text = _saveFile.FileName;
            }
        }

        private void OpenInputInTableForm(object sender, EventArgs e)
        {
            if (_data.AllVariables == null)

                MessageBox.Show(Resources.InputFileWithVariables, Resources.Error, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else if (_data.Y == null)
                MessageBox.Show(Resources.InputFileWithFunctions, Resources.Error, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
                try
                {
                    var tables = new InputDataInTables(_data);
                    tables.ShowDialog();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(Resources.UnnableToOpenFile + exc.Message, Resources.Error, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
        }

        private void VariableDataSourceChanged(object sender, EventArgs e)
        {
            var textBox = (sender as TextBox);
            if (textBox == null) return;
            var path = textBox.Text;
            try
            {
                _data.SetVariables(MatrixFileReader.ReadAsMatrix(path), _variablesDimension.ToArray());
                numMeterageCount.Value = _maxMeterageCount = _data.AllVariables[0].Length;
                txtVarCount.Text = _data.AllVariables.Count().ToString();
            }
            catch (IOException exc)
            {
                MessageBox.Show(Resources.TryAnotherFile + exc.Message, Resources.ReadingError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException exc)
            {
                MessageBox.Show(Resources.TryAnotherFile + exc.Message, Resources.ReadingError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void numMeterageCount_ValueChanged(object sender, EventArgs e)
        {
            var num = (NumericUpDown)sender;
            if (num.Value > _maxMeterageCount)
                num.Value = _maxMeterageCount;
            else
                _data.MeterageCount = (int)num.Value;
        }

        private void OpenNormalizeInputInTableForm(object sender, EventArgs e)
        {
            if (_data.AllVariables == null)

                MessageBox.Show(Resources.InputFileWithVariables, Resources.Error, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else if (_data.Y == null)
                MessageBox.Show(Resources.InputFileWithFunctions, Resources.Error, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
                try
                {
                    var tables = new InputDataInTables(_data.Normalized);
                    tables.ShowDialog();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(Resources.UnnableToOpenFile + exc.Message, Resources.Error, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
        }

        private void FunctionDataSourceChanged(object sender, EventArgs e)
        {
            var textBox = (sender as TextBox);
            if (textBox == null) return;
            var path = textBox.Text;
            try
            {
                var func = MatrixFileReader.ReadAsMatrix(path);
                _data.SetFunctions(func);
            }
            catch (IOException exc)
            {
                MessageBox.Show(Resources.TryAnotherFile + exc.Message, Resources.ReadingError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException exc)
            {
                MessageBox.Show(Resources.TryAnotherFile + exc.Message, Resources.ReadingError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void VariableDimensionChanged(object sender, EventArgs e)
        {
            var currentVariableDimensionUpDown = (NumericUpDown)sender;

            var variableNumber =
                int.Parse(new string(currentVariableDimensionUpDown.Name.Where(ch => char.IsDigit(ch)).ToArray())) - 1;

            if (!DimensionsIsCorrect() || _data.AllVariables == null)

                currentVariableDimensionUpDown.Value = _variablesDimension[variableNumber];
            else
            {
                _variablesDimension[variableNumber] = (int)currentVariableDimensionUpDown.Value;

                _data.ChangeDimensions(_variablesDimension.ToArray());
            }
        }

        private bool DimensionsIsCorrect()
        {
            var sumOfDimensions = numVar1Dim.Value + numVar2Dim.Value + numVar3Dim.Value;
            return sumOfDimensions <= int.Parse(txtVarCount.Text);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (_data.AllVariables == null || _data.Y == null)
                return;
            int method = 0;
            if (radioButton1.Checked) method = 0;
            if (radioButton2.Checked) method = 1;
            var rnd = new Random();
            var polinomType = _polinomType;
            var bMatrix = Matrix.B_Create(_matrixBRadioButtons.First(btn => btn.Value.Checked).Key,
                _data.Normalized.Y.Transpone());

            Log.Write("Matrix B:\n" + bMatrix.AsString());
            var numPolinomPowerVals = new int[3];
            numPolinomPowerVals[0] = (int)numPolinomPowerX1.Value;
            numPolinomPowerVals[1] = (int)numPolinomPowerX2.Value;
            numPolinomPowerVals[2] = (int)numPolinomPowerX3.Value;
            var aMatrix = Matrix.A_Create(numPolinomPowerVals,
                _polinomRadioButtons.First(pair => pair.Value.Checked).Key, _data.Normalized.X1.Transpone(),
                _data.Normalized.X2.Transpone(), _data.Normalized.X3.Transpone(), _data.Normalized.Y.Transpone());
            Log.Write("Matrix A:\n" + aMatrix.AsString());
            var a1Matrix = Matrix.Al_Create(1, numPolinomPowerVals[0], polinomType, _data.Normalized.X1.Transpone(),
                _data.Normalized.X2.Transpone(), _data.Normalized.X3.Transpone(), _data.Normalized.Y.Transpone());
            var a2Matrix = Matrix.Al_Create(2, numPolinomPowerVals[1], polinomType, _data.Normalized.X1.Transpone(),
                _data.Normalized.X2.Transpone(), _data.Normalized.X3.Transpone(), _data.Normalized.Y.Transpone());
            var a3Matrix = Matrix.Al_Create(3, numPolinomPowerVals[2], polinomType, _data.Normalized.X1.Transpone(),
                _data.Normalized.X2.Transpone(), _data.Normalized.X3.Transpone(), _data.Normalized.Y.Transpone());
            var lambdaCount = _data.Normalized.Y.Length;
            double ep = 0.00001;
            var lambda = new double[lambdaCount][];
            if (!checkBox1.Checked)
            {
                for (int i = 0; i < lambdaCount; i++)
                {
                    lambda[i] = method== 0 ? 
                        SlaeSolver.Solve(aMatrix, bMatrix.Transpone()[i]) :
                        Gradient_method.X(aMatrix, bMatrix.Transpone()[i], ep);
                }

            }
            else
            {
                for (int i = 0; i < lambdaCount; i++)
                {
                    switch (method)
                    {
                        case 0:
                            lambda[i] = SlaeSolver.Solve(aMatrix, bMatrix.Transpone()[i]);
                            break;
                        case 1:
                            lambda[i] = Gradient_method.X(aMatrix, bMatrix.Transpone()[i], ep);
                            break;
                    }
                }
            }

            var lambda_rez = lambda.Transpone();
            Log.Write("Vector lambda:");
            Log.Write(lambda_rez.AsString());
            Log.WriteLine("Polinomial Psi");
            var X = new[]
            {_data.Normalized.X1.Transpone(), _data.Normalized.X2.Transpone(), _data.Normalized.X3.Transpone()};
            var psi = PolynomialCalculus.CalculatePsi(
                lambda,
                polinomType,
                numPolinomPowerVals,
                new[]
                {
                    _data.Normalized.X1.Length,
                    _data.Normalized.X2.Length,
                    _data.Normalized.X3.Length
                });
            var aRes = Matrix.A_Get(X, _data.Normalized.Y, psi, method);
            Log.WriteLine("Matrix a:\n");
            for (int j = 0; j < _data.Normalized.Y.Length; j++)
            {
                Log.WriteLine("  For Y" + (j + 1) + ":");
                int k = 0;
                foreach (var vector in aRes[j])
                {
                    Log.WriteLine("    For X" + (++k) + ":");
                    Log.WriteLine(aRes[j][k]);
                }
            }
            var F = Matrix.F_Get(X, _data.Normalized.Y.Transpone(), _data.Normalized.Y, aRes, psi);
            printF(F);
            var c = Matrix.C_Get(_data.Normalized.Y, F, method);
            Log.WriteLine("Matrix c:\n" + c.AsString());
            _data.Y_eval_norm = Matrix.Y_Get(aRes, X, c, psi, _data.Normalized.Y.Length, _data.Normalized.Y.Transpone().Length);
            Log.Write("Approximated normalized Y:\n" + _data.Y_eval_norm.Transpone().AsString());
            Log.WriteLine("Squared error:");
            double[] err = new double[_data.Normalized.Y.Length];
            for (int i = 0; i < err.Length; i++)
            {
                err[i] = Matrix.sq_err(_data.Normalized.Y[i], _data.Y_eval_norm[i]);
                Log.WriteLine("For Y" + (i + 1).ToString() + " sq_err = " + err[i].ToString());
            }
            Log.WriteLine("Max abs error:");
            double[] errr = new double[_data.Normalized.Y.Length];
            for (int i = 0; i < errr.Length; i++)
            {
                errr[i] = Matrix.max_err(_data.Normalized.Y[i], _data.Y_eval_norm[i]);
                Log.WriteLine("For Y" + (i + 1).ToString() + " max_err = " + errr[i].ToString());
            }
            _data.Y_eval = new double[_data.Normalized.Y.Length][];
            for (int i = 0; i < _data.Y_eval.Length; i++)
            {
                _data.Y_eval[i] = new double[_data.Normalized.Y[i].Length];
                _data.Y_eval[i] = DataNormalizer.Denormalize(_data.Y_eval_norm[i], _data.Y[i].Min(), _data.Y[i].Max());
            }
            Log.Write("Approximated Y:\n" + _data.Y_eval.Transpone().AsString());
            Log.WriteLine("Max abs error:");
            double[] err2 = new double[_data.Y.Length];
            for (int i = 0; i < err.Length; i++)
            {
                err2[i] = Matrix.max_err(_data.Y[i], _data.Y_eval[i]);
                Log.WriteLine("For Y" + (i + 1).ToString() + " max_err = " + err2[i].ToString());
            }
            new Graphics(_maxMeterageCount, _data.Y, _data.Y_eval).ShowDialog();
        }

        private void printF(double[][][] f)
        {
            Log.WriteLine("Функции Ф1i, Ф2i, Ф3i:");
            int i1 = 0;
            foreach (var yi in f)
            {
                Log.WriteLine("  для Y" + (++i1) + ":");
                for (int i2 = 0, i3 = 0; i2 < yi.GetLength(0) && i3 < yi.GetLength(2); i2++, i3++)
                {
                    Log.WriteLine("Ф" + i2 + "" + i3 + "" + yi[i2][i3]);
                }
            }
        }

        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSaveResult.Text))
            {
                MessageBox.Show("Выберите файл для сохранения");
                return;
            }
            txtLog.Text.SaveToFile(txtSaveResult.Text);
            MessageBox.Show("Успешно сохранено");
        }

        private void btnOpenChart_Click(object sender, EventArgs e)
        {
            new Graphics(_maxMeterageCount, _data.Normalized.Y, _data.Y_eval_norm).ShowDialog();
            //new Graphics(_maxMeterageCount, _data.Y, _data.Y_eval).ShowDialog();
        }
    }
}