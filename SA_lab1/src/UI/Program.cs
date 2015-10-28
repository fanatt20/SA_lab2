using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;
using Algorithms;

namespace SA_lab1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() { 
        
            if ( RunTest()) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            } else
            {
                Console.WriteLine("Tests did not pass, unable to run App.");
            }

        }

        private static bool RunTest()
        {
            try {
                Console.WriteLine("SLAE solver started");
                double[,] A = new double[,] { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };

                double[] b = new double[] { 2.0, 3.0, 9.0 };

                double[] x = SlaeSolver.Solve(A, b);
                Console.WriteLine("x: (" + x[0] + ", " + x[1] + ", " + x[2] + ")"); }
            catch{ return false; }
            return true;
        }
    }
}
