using System.Windows.Forms;
using Algorithms.Extensions;
using UI.DataHolder;
using System.Collections.Generic;

namespace UI
{
    public partial class InputDataInTables : Form
    {
        public InputDataInTables(IDataHolder dataHolder)
        {
            InitializeComponent();
            var varNamelst = new List<string>();
            for (int i = 0; i < dataHolder.AllVariables.Length; i++)
            {
                varNamelst.Add("Переменная " + (i + 1));
            }
            gridViewVariables.DataSource = dataHolder.AllVariables.GetDataTableFromMatrix(varNamelst.ToArray());
            var funcNamelst = new List<string>();
            for (int i = 0; i < dataHolder.Y.Length; i++)
            {
                funcNamelst.Add("Функция " + (i + 1));
            }
            gridViewFunctions.DataSource =
            dataHolder.Y.GetDataTableFromMatrix(funcNamelst.ToArray());
        }

        public InputDataInTables(double[][] MatrixA,string[] nameForVariableOfMatrix1, double[][] matrixB, string[] nameForVariableOfMatrix2)
        {
            InitializeComponent();

            gridViewVariables.DataSource = MatrixA
                .GetDataTableFromMatrix(nameForVariableOfMatrix1);
            gridViewFunctions.DataSource =
                matrixB.GetDataTableFromMatrix(nameForVariableOfMatrix2);
        }
    }
}