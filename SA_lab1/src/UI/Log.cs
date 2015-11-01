using System.Windows.Forms;

namespace UI
{
    public class Log
    {
        internal static TextBoxBase Target { get; set; }
        public static void Write(System.Object str) { Target.Text += str;}
        public static void WriteLine(System.Object str) { Write(str + "\n"); }
        public static void WriteLine() { Write("\n"); }
        public static void Write(string str){ Target.Text += str;}
        public static void WriteLine(string str){ Write("\n" + str);}

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
