using System;
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

        public MainForm()
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

        private void OpenInputInTableForm(object sender, EventArgs e)
        {
            try
            {
                var fileReader = new MatrixFileReader();
                var variables =fileReader.ReadAsMatrix(txtVariablePath.Text);
                var function1 = fileReader.ReadAsArray(txtFunction1Path.Text);
                var function2 = fileReader.ReadAsArray(txtFunction2Path.Text);
                var function3 = fileReader.ReadAsArray(txtFunction3Path.Text);
                var tables = new InputDataInTables(variables, function1,function2,function3);
                tables.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Невозможно открыть файл\n" + exc.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

       
    }
}