using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class PolynomialCalculus
    {
        /*
        selectedType = type_combo.SelectedIndex + 1
        por = ? (original content)
        x[i-1] = Data.Xi[0]
        */
        public static Polinom[][][] CalculatePsi(double[][] lambda, int selectedType, int[] por, int[] x)
        {
            Polinom[][][] result = new Polinom[lambda.Length][][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new Polinom[3][];
                for (int l = 0; l < 3; l++) {
                    result[i][l] = new Polinom[x[0]];
                    for (int j = 0; j < result[i][0].Length; j++)
                    {
                        for (int k = 0; k <= por[0]; k++)
                        {
                            int index = j * (por[l] + 1) + k;
                            for (int m = 0; m < l; m++)
                                index += (x[l]) * (por[l] + 1);
                            result[i][l][j] += lambda[i][index] * new Polinom(selectedType, k, false);
                        }
                    }
                }      
            }
            return result;     
        }
    }
}
