using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class InputDataInTables : Form
    {
        public InputDataInTables(double[][] variables, double[][] functions)
        {
            InitializeComponent();

            dataGridView1.DataSource = GetDataTableFromMatrix(variables);
            dataGridView3.DataSource = GetDataTableFromMatrix(functions);
        }

        private DataTable GetDataTableFromMatrix(double[][] array)
        {
            var result = new DataTable();
            for (var i = 0; i < array.Length; i++)
            {
                result.Columns.Add();
            }
            var row = new List<string>();
            for (var i = 0; i < array[0].Length; i++)
            {
                row.AddRange(array.Select(sub => sub[i].ToString()));
                result.Rows.Add(row.ToArray());
                row.Clear();
            }
            return result;
        }
    }
}