using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new double[10][];
            for (int i = 0; i < 10; i++)
            {
                d[i]=new double[] {1,2,3,4,5,6,7,7,7};
            }
            d.SaveToFile("file.txt","Matrix 1");
            "Hoole".SaveToFile("file.txt");
        }
        
    }
}
