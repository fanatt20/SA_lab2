using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        private readonly OpenFileDialog _openFile;
        private SaveFileDialog _saveFile;

        public Form1()
        {
            InitializeComponent();
            _openFile = new OpenFileDialog();
            _openFile.Multiselect = false;
            _saveFile=new SaveFileDialog();
            _saveFile.Filter = "Text File|*.txt";
#warning раскомментировать фильтр для _openFile:OpenFileDialog
            //_openFile.Filter = "Text File|*.txt";
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
    }
}