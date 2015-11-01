using System.Windows.Forms;

namespace UI
{
    public class Log
    {
        public static TextBoxBase Target { get; set; }

        public static void Write(string str)
        {
            Target.Text += str;
        }

        public static void WriteLine(string str)
        {
            Write("\n" + str);
        }

        public static void Write(double[][] matrix)
        {
            foreach (var array in matrix)
            {
                foreach (var element in array)
                {
                    Write(element + "\t");
                }
                WriteLine("");
            }
        }
    }
}