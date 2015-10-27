using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace UI
{
    internal static class MatrixFileReader
    {
        internal static double[][] ReadAsMatrix(string path)
        {
            using (var sReader = new StreamReader(path))
            {
                var resultInLst = new List<List<double>>();
                var bufferStr = sReader.ReadLine();

                if (bufferStr != null)
                {
                    var collection = bufferStr.Replace(".", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator)
                            .Split('\t')
                            .Select(s => double.Parse(s, CultureInfo.InvariantCulture));
                    foreach (var num in collection)
                    {
                        resultInLst.Add(new List<double> { num });
                    }
                    var index = 0;
                    while ((bufferStr = sReader.ReadLine()) != null)
                    {
                        collection = bufferStr.Replace(".", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator)
                                                .Split('\t')
                                                .Select(s => double.Parse(s, CultureInfo.InvariantCulture));
                        foreach (var item in collection)
                            resultInLst[index++].Add(item);
                        index = 0;
                    }
                }
                return resultInLst.Select(lst => lst.ToArray()).ToArray();
            }
        }

        internal static double[] ReadAsArray(string path)
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