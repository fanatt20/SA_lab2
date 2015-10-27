using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace UI
{
    internal class MatrixFileReader
    {
        public MatrixFileReader()
        {
        }
        internal double[][] ReadAsMatrix(string path)
        {
            double[][] result = null;

            using (var sReader = new StreamReader(path))
            {
                var buffer = sReader.ReadLine();

                if (buffer == null || buffer.Split('\t').Count() != 2)
                    throw new FormatException();

                result = new double[int.Parse(buffer.Split('\t')[1])][];
                var length = int.Parse(buffer.Split('\t')[0]);
                for (var i = 0; i < result.Length; i++)
                {
                    result[i] = new double[length];
                }
                var secondIndex = 0;
                while ((buffer = sReader.ReadLine()) != null)
                {
                    var firstIndex = 0;
                    foreach (var number in buffer.Split('\t')
                        .Select(s => double.Parse(s.Replace(".", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator),
                                                                                                    CultureInfo.InvariantCulture)))
                    {
                        result[firstIndex++][secondIndex] = number;
                    }
                    secondIndex++;
                }
            }
            return result;
        }

        internal double[] ReadAsArray(string path)
        {
            double[] result = null;

            using (var sReader = new StreamReader(path))
            {
                var buffer = sReader.ReadLine();

                if (buffer == null || buffer.Split('\t').Count() != 1)
                    throw new FormatException();

                result = new double[int.Parse(buffer.Split('\t')[0])];

                var firstIndex = 0;
                while ((buffer = sReader.ReadLine()) != null)
                {
                    result[firstIndex++] = double.Parse(buffer.Replace(".", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), CultureInfo.InvariantCulture);
                }
            }

            return result;
        }
    }
}