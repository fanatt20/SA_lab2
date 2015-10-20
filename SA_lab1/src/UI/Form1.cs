using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        private readonly OpenFileDialog _openFile;
        private readonly SaveFileDialog _saveFile;

        public Form1()
        {
            InitializeComponent();
            _openFile = new OpenFileDialog { Multiselect = false, Filter = "Text File|*.txt" };
            _saveFile = new SaveFileDialog { Filter = "Text File|*.txt" };
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

        private void button2_Click(object sender, EventArgs e)
        {
            var variables = GetValuesFromFiles(txtVariablePath.Text);
            var functions = GetValuesFromFiles(txtFunctionPath.Text);
            var tables = new InputDataInTables(variables, functions);
            tables.ShowDialog();
        }

        private double[][] GetValuesFromFiles(string path)
        {
            double[][] result = null;
            try
            {
                using (var sReader = new StreamReader(File.OpenRead(path)))
                {
                    var buffer = sReader.ReadLine();
                    
                    if (buffer == null || buffer.Split('\t').Count() != 2)
                        throw new FormatException();

                    result = new double[int.Parse(buffer.Split('\t')[1])][];
                    var length = int.Parse(buffer.Split('\t')[0]);
                    for (var i = 0; i < result.Length; i++)
                    {
                        result[i] = new double[length];
                    }
                    var firstIndex = 0;
                    var secondIndex = 0;
                    while ((buffer = sReader.ReadLine()) != null)
                    {
                        firstIndex = 0;
                        foreach (var number in buffer.Split('\t').Select(double.Parse))
                        {
                            result[firstIndex++][secondIndex] = number;
                        }
                        secondIndex++;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Невозможно открыть файл\n" + exc.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return result;
        }
    }
}