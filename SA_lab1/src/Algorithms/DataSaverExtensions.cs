using System.IO;

namespace Algorithms
{
    public static class DataSaverExtensions
    {
        public static void SaveToFile(this string data, string path)
        {
            using (var sWriter = new StreamWriter(path, true))
            {
                sWriter.Write(data);
            }
        }

        public static void SaveToFile(this double[][] data, string path, string name = null)
        {
            using (var sWriter = new StreamWriter(path, true))
            {
                if (name != null)
                    sWriter.WriteLine(name);
                for (var i = 0; i < data[0].Length; i++)
                {
                    foreach (var array in data)
                    {
                        sWriter.Write(array[i]);
                    }
                    sWriter.WriteLine();
                }
            }
        }
    }
}