using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public class Log
    {
        internal static TextBoxBase Target { get; set; }
        public static void Write(Object str) { Target.Text += str;}
        public static void WriteLine(Object str) { Write(str + "\n"); }
        public static void WriteLine() { Write("\n"); }
    }
}
