using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Algorithms;
using Algorithms.Extensions;
using UI.Properties;
using Matrix = Algorithms.Matrix;
using UI.DataHolder;
using UI;

namespace UI
{

    public partial class MainForm : Form
    {

        private readonly OpenFileDialog _openFile;
        private readonly SaveFileDialog _saveFile;
        private readonly Dictionary<PolinomType,RadioButton> _polinomRadioButtons=new Dictionary<PolinomType, RadioButton>();
        private readonly Dictionary<Matrix.BType,RadioButton> _matrixBRadioButtons = new Dictionary<Matrix.BType, RadioButton>();

        private int _maxMeterageCount;

        private DataHolder.DataHolder _data = new DataHolder.DataHolder();

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
            _matrixBRadioButtons.Add(Matrix.BType.Type2,radioBType2);
            _matrixBRadioButtons.Add(Matrix.BType.Type3, radioBType3);

            _variablesDimension[0] =(int)numVar1Dim.Value;
            _variablesDimension[1] = (int)numVar2Dim.Value;
            _variablesDimension[2] = (int)numVar3Dim.Value;
            
            Log.Target = txtLog;
            Log.WriteLine(new DateTime());
            Log.WriteLine();
        }


        private readonly List<int> _variablesDimension = new List<int> { 0, 0, 0 };




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

            var variableNumber = int.Parse(new string(currentVariableDimensionUpDown.Name.Where(ch => char.IsDigit(ch)).ToArray())) - 1;

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
            decimal sumOfDimensions = numVar1Dim.Value + numVar2Dim.Value + numVar3Dim.Value;
            return sumOfDimensions <= int.Parse(txtVarCount.Text);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (_data.AllVariables == null || _data.Y == null)
                return;
            var bMatrix = Matrix.B_Create(_matrixBRadioButtons.First((pair => pair.Value.Checked)).Key, _data.Normalized.Y.Transpone()).Transpone();
            
            Log.Write("Матрица Б:\n"+ bMatrix.AsString());
            var numPolinomPowerVals = new int[3];
            numPolinomPowerVals[0] = (int)numPolinomPowerX1.Value;
            numPolinomPowerVals[1] = (int)numPolinomPowerX2.Value;
            numPolinomPowerVals[2] = (int)numPolinomPowerX3.Value;
            var aMatrix = Matrix.A_Create(numPolinomPowerVals, _polinomRadioButtons.First(pair => pair.Value.Checked).Key, _data.Normalized.X1.Transpone(), _data.Normalized.X2.Transpone(), _data.Normalized.X3.Transpone(), _data.Normalized.Y.Transpone()).Transpone();
            Log.Write("Матрица A:\n" + aMatrix.AsString());

            new InputDataInTables(aMatrix,null, bMatrix,null).ShowDialog();
            
            double[][] lambda = new double[bMatrix.Length][];
            for (int i = 0; i < bMatrix.Length; i++)
            {
                lambda[i] = SlaeSolver.Solve(aMatrix, bMatrix[i]);
            }
            //TODO log values and show result on UI
            int type = 0;
            //TODO get type of selected polynomial
            var Xi = new double[][][] { _data.X1, _data.X2, _data.X3 };
            Polinom[][][] psi = PolynomialCalculus.CalculatePsi(
                lambda,
                type, 
                numPolinomPowerVals,
                new int[3] { _data.X1.Length, _data.X2.Length, _data.X3.Length });
            //TODO log calculations and show result
            var Yt = Matrix.Transponation(_data.Y);//fixme
            double[][][] aRes = Matrix.A_Get(Xi, Yt, psi);
            //TODO log calculations and show result
            double[][][] F = Matrix.F_Get(Xi, _data.Y, Yt, aRes, psi);
            //TODO log calculations and show result
            double[][] c = Matrix.C_Get(Yt, F);
            //TODO log calculations and show result
            var Yo = Matrix.Yo_Get(aRes, Xi, c, psi, Yt.Length);
            //TODO log calculations and show result
            //TODO denormalize data
        }

        private void GetX1X2X3YAsString()
        {
            var strBuilder = new StringBuilder();
            var x1AsString = _data.X1.Aggregate(strBuilder, (builder, array) =>
                             builder.Append(array.Aggregate(new StringBuilder(), (b, d) => b.Append('\t').Append(d).Append('\t')))
                             .Append('\n')
                             .Append('-', 7)
                             .Append('\n')).ToString();
            var x2AsString = _data.X2.Aggregate(strBuilder, (builder, array) =>
                             builder.Append(array.Aggregate(new StringBuilder(), (b, d) => b.Append('\t').Append(d).Append('\t')))
                             .Append('\n')
                             .Append('-', 7)
                             .Append('\n')).ToString();
            var x3AsString = _data.X3.Aggregate(strBuilder, (builder, array) =>
                              builder.Append(array.Aggregate(new StringBuilder(), (b, d) => b.Append('\t').Append(d).Append('\t')))
                             .Append('\n')
                             .Append('-', 7)
                             .Append('\n')).ToString();
            var yAsString = _data.Y.Aggregate(strBuilder, (builder, array) =>
                              builder.Append(array.Aggregate(new StringBuilder(), (b, d) => b.Append('\t').Append(d).Append('\t')))
                             .Append('\n')
                             .Append('-', 7)
                             .Append('\n')).ToString();
            var result = "\nX1:\n" + x1AsString +
                            "\nX2:\n" + x2AsString +
                            "\nX3:\n" + x3AsString +
                            "\nY:\n" + yAsString;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}