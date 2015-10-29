using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class DataNormalizer
    {
        private static readonly double DELTA = 0.000000001;

        public static double[][] Normalize(double[][] matrix)
        {
            return matrix.Select(Normalize).ToArray();
        }

        public static double[][][] Normalize(double[][][] setOfMatrix)
        {
            return setOfMatrix.Select(Normalize).ToArray();
        }

        public static double[] Normalize(double[] array)
        {
            if (array == null || array.Length == 0)
                return array;
            var result = (double[]) array.Clone();
            var min = array.Min();
            var max = array.Max();
            var i = 0;
            var d = (max - min);
            if (IsDoubleValueZero(d))
                foreach (var value in array)
                {
                    result[i++] = value;
                }
            else
                foreach (var value in array)
                {
                    result[i++] = (value - min)/d;
                }
            return result;
        }

        private static bool IsDoubleValueZero(double value)
        {
            return (-DELTA < value) && (value < DELTA);
        }
    }
}