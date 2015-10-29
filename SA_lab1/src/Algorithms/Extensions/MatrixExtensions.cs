using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Extensions
{
    public static class MatrixExtensions
    {
        public static double[][] CreateArrayOfArray(this double[] data, params double[][] array)
        {
            var result = new double[1 + array.Length][];
            result[0] = data;
            for (int i = 0; i < array.Length; i++)
            {
                result[i + 1] = array[i];
            }
            return result;
        }
        public static double[][] ToArrayOfArray(this double[][][] data)
        {
            var lst = new List<double[]>();
            foreach (var item in data)
            {
                lst.AddRange(item);
            }
            return lst.ToArray();
        }
        public static double[,] ToMatrix(this double[][] data)
        {
            int n = data.Count();
            int m = data.First().Count();
            var result = new double[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    result[i, j] = data[i][j];
            return result;
        }


        public static DataTable GetDataTableFromMatrix(this double[][] matrix, string[] columnsName = null)
        {
            var result = new DataTable();
            if (columnsName != null)
            {
                for (var i = 0; i < matrix.Length; i++)
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

        public static double[][] TakeBySecondCoordinate(this double[][] data, int count)
        {
            return data.Select(c => c.Take(count).ToArray()).ToArray();
        }
        public static double[][][] SpliceAccordingDims(this double[][] data, int[] dimensions)
        {
            if (dimensions.Sum() > data.Length)
                throw new ArgumentOutOfRangeException();
            double[][][] result = new double[dimensions.Length][][];
            for (int i = 0; i < dimensions.Length; i++)
            {
                result[i] = (double[][])data.Skip(dimensions.Take(i).Sum()).Take(dimensions[i]).ToArray().Clone();
            }
            return result;
        }

        public static double[][] DeepCopy(this double[][] data)
        {
            var result = new double[data.Length][];
            for (int i = 0; i < data.Length; i++)
            {
                result[i] = new double[data[i].Length];
                for (int j = 0; j < data[i].Length; j++)
                {
                    result[i][j] = data[i][j];
                }
            }
            return result;
        }

        public static string AsString(this double[][] data)
        {
            var builder = new StringBuilder().Append('\t');
            foreach (var array in data)
            {
                foreach (var element in array)
                {
                    builder.Append(element).Append('\t');
                }
                builder.AppendLine();
            }
            return builder.ToString();


        }
    }
}
