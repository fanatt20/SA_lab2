using System;
using System.Windows.Forms;
using Algorithms;
using UI;

namespace SA_lab1
{
    internal static class Program
    {
        /// <summary>
        ///     Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (!RunTest())
            {
                Console.WriteLine("Tests did not pass, unable to run App.");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static bool RunTest()
        {
            try
            {
                Console.WriteLine("SLAE solver started");
                double[,] A = {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}};

                double[] b = {2.0, 3.0, 9.0};

                var x = SlaeSolver.Solve(A, b);
                Console.WriteLine("x: (" + x[0] + ", " + x[1] + ", " + x[2] + ")");
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}