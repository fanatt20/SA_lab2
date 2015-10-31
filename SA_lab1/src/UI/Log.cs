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
        public static TextBoxBase Target { get; set; }
        public static void Write(String str) { Target.Text += str;}
        public static void WriteLine(String str) { Write("\n" + str); }
    }
}
