using Algorithms.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UI.Properties;

namespace UI
{
    public partial class MainForm : Form
    {
        private readonly OpenFileDialog _openFile;
        private readonly SaveFileDialog _saveFile;

        private double[][][] _variables;
        private double[][] _functions;

        private int _variablesCount = 3;
        private readonly List<int> _variablesDimension = new List<int> { 2, 1, 2 };
        private int _meterageCount = 36;
        private int _maxMeterageCount = 36;


        public MainForm()
        {
            InitializeComponent();
            _openFile = new OpenFileDialog { Multiselect = false, Filter = "Text File|*.txt" };
            _saveFile = new SaveFileDialog { Filter = "Text File|*.txt" };
            txtVar1Dim.Text = _variablesDimension[0].ToString();
            txtVar2Dim.Text = _variablesDimension[1].ToString();
            txtVar3Dim.Text = _variablesDimension[2].ToString();
            txtVarCount.Text = "5";
            numMeterageCount.Value = _meterageCount;

        }

        private void TextBoxOpenFileAction(object sender, MouseEventArgs e)
        {
            var txtBox = sender as TextBox;
            if (txtBox == null)
                throw new ArgumentException("Sender must be textbox");

            _openFile.FileName = txtBox.Text ?? "";
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
            _saveFile.FileName = txtBox.Text ?? "";
            _openFile.ShowDialog();
            if (_openFile.FileName != null)
            {
                txtBox.Text = _saveFile.FileName;
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
        }

        private void OpenInputInTableForm(object sender, EventArgs e)
        {
            try
            {
                var fileReader = new MatrixFileReader();

                var function1 = fileReader.ReadAsArray(txtFunction1Path.Text);
                var function2 = fileReader.ReadAsArray(txtFunction2Path.Text);
                var function3 = fileReader.ReadAsArray(txtFunction3Path.Text);



                _functions = function1.CreateMatrix(function2, function3);


                var tables = new InputDataInTables(_variables, function1, function2, function3);
                tables.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Невозможно открыть файл\n" + exc.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void VariableDataSourceChanged(object sender, EventArgs e)
        {
            var textBox = (sender as TextBox);
            if (textBox != null)
            {
                var path = textBox.Text;
                try
                {
                    using (var sr = new StreamReader(path))
                    {
                        var variables = (new MatrixFileReader()).ReadAsMatrix(txtVariablePath.Text);
                        _variables = new double[_variablesCount][][];
                        for (int i = 0; i < _variablesCount; i++)
                        {
                            _variables[i] = variables.Skip(_variablesDimension.Take(i).Sum()).Take(_variablesDimension[i]).ToArray();// new double[_variablesDimension[i]][];
                        }
                    }
                }
                catch (IOException exc)
                {
                    MessageBox.Show("Попробуйте другой файл\n" + exc.Message, "Ошибка при чтении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void numMeterageCount_ValueChanged(object sender, EventArgs e)
        {
            var num = (NumericUpDown)sender;
            if (num.Value < 0 || num.Value > _maxMeterageCount)
                if (num.Value < 0)
                    num.Value = 0;
                else
                    num.Value = _maxMeterageCount;
            else
                _meterageCount = (int)num.Value;
        }

    }
}