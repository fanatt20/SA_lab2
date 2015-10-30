using System.Windows.Forms;
using Algorithms.Extensions;

namespace UI
{
    public partial class InputDataInTables : Form
    {
        public InputDataInTables(IDataHolder dataHolder)
        {
            InitializeComponent();
            gridViewVariables.DataSource = dataHolder.AllVariables.GetDataTableFromMatrix(new[]
            {"Переменная 1", "Переменная 2", "Переменная 3", "Переменная 4", "Переменная 5"});
            gridViewFunctions.DataSource =
                dataHolder.Y.GetDataTableFromMatrix(new[] {"Функция 1", "Функция 2", "Функция 3"});
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