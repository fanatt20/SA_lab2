using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI;

namespace Algorithms
{
    public class PolynomialCalculus
    {
        public static Psi[][][] CalculatePsi(double[][] lambda, PolinomType p_type, int[] rang, int[] x, bool multiplicative)
        {
            Psi[][][] result = new Psi[lambda.Length][][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new Psi[3][];
                for (int l = 0; l < 3; l++)
                {
                    Log.WriteLine(" X" + i + ":");
                    result[i][l] = new Psi[x[l]];
                    for (int j = 0; j < result[i][l].Length; j++)
                    {
                        result[i][l][j] = new Psi(multiplicative ? 1 : 0);
                        for (int k = 0; k <= rang[l]; k++)
                        {
                            int index = j * (rang[l] + 1) + k;
                            for (int m = 0; m < l; m++)
                                index += (x[m]) * (rang[m] + 1);
                           result[i][l][j].lambda.Add(lambda[i][index]);
                            result[i][l][j].Add(new Polinom(p_type, k));
                        }
                    }
                }
            }
            return result;     
        }       
    }
}
