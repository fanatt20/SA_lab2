using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Algorithms.Extensions;

namespace UI
{
    public partial class InputDataInTables : Form
    {
        public InputDataInTables(double[][][] variables, double[] function1, double[] function2, double[] function3)
        {
            InitializeComponent();

            dataGridView1.DataSource = GetDataTableFromMatrix(variables.ToArrayOfArray(), new string[] { "Переменная 1", "Переменная 2", "Переменная 3", "Переменная 4", "Переменная 5" });
            var functions = function1.CreateMatrix(function2, function3);
            dataGridView3.DataSource = GetDataTableFromMatrix(functions, new string[] { "Функция 1", "Функция 2", "Функция 3" });
        }

        private DataTable GetDataTableFromMatrix(double[][] matrix, string[] columnsName = null)
        {
            var result = new DataTable();
            if (columnsName != null)
            {
                if (columnsName.Length != matrix.Length)
                    throw new ArgumentException();
                for (var i = 0; i < columnsName.Length; i++)
                {
                    result.Columns.Add(columnsName[i]);
                }
            }
            else
                for (var i = 0; i < matrix.Length; i++)
                {
                    result.Columns.Add();
                }
            var row = new List<string>();
            for (var i = 0; i < matrix[0].Length; i++)
            {
                row.AddRange(matrix.Select(sub => sub[i].ToString()));
                result.Rows.Add(row.ToArray());
                row.Clear();
            }
            return result;
        }
    }
}