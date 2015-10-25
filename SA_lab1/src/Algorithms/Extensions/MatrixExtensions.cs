using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Extensions
{
    public static class MatrixExtensions
    {
        public static double[][] CreateMatrix(this double[] data,params double[][] array)
        {
            var result = new double[1+array.Length][];
            result[0] = data;
            for (int i = 0; i < array.Length; i++)
            {
                result[i + 1] = array[i];
            }
            return result;

        }
    }
}
