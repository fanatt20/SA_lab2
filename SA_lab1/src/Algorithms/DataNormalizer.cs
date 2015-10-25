using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class DataNormalizer
    {
        private static double DELTA = 0.000000001;
        public static double[] Normalize(double[] array)
        {
            if (array == null || array.Length == 0)
                return array;
           double[] result = (double[])array.Clone();
            double min = array.Min();
            double max = array.Max();
            int i = 0;
            double d = (max - min);
            if (IsDoubleValueZero(d))
                foreach (double value in array)
                {
                    result[i] = value;
                }
            else
                foreach (double value in array)
                {
                    result[i] = (value - min) / d;
                }
            return result;
        }
        private static bool IsDoubleValueZero(double value)
        {
            return (-DELTA < value) && (value < DELTA);
        }
    }
}
