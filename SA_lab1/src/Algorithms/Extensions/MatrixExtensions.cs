using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Extensions
{
    public static class MatrixExtensions
    {
        public static double[][] CreateMatrix(this double[] data, params double[][] array)
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

    }
}
