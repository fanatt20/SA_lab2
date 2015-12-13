using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI;

namespace Algorithms
{
    public class PolynomialCalculusnew
    {
        public static Psi[][][] CalculatePsi(double[][] lambda, PolinomType p_type, int[] rang, int[] x, bool useFrom2Lab)
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
                        result[i][l][j] = new Psi(useFrom2Lab ? 1 : 0);
                        for (int k = 0; k <= rang[l]; k++)
                        {
                            int index = (x[0]) * (rang[0] + 1) + (x[1]) * (rang[1]) + j * (rang[2]) + k;
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
