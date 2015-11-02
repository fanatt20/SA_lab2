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
        x[i-1] = Data.Xi[0]
        */
        public static Polinom[][][] CalculatePsi(double[][] lambda, PolinomType p_type, int[] rang, int[] x)
        {
            Polinom[][][] result = new Polinom[lambda.Length][][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new Polinom[3][];
                for (int l = 0; l < 3; l++)
                {
                    result[i][l] = new Polinom[x[l]];
                    for (int j = 0; j < result[i][l].Length; j++)
                    {
                        result[i][l][j] = lambda[i][j * (rang[l] + 1)] * (new Polinom(p_type, 0));
                        for (int k = 0; k <= rang[l]; k++)
                        {
                            //int index = j * (rang[l] + 1) + k;
                            //for (int m = 0; m < l; m++)
                            //    index += (x[l]) * (rang[l] + 1);
                            //result[i][l][j] += lambda[i][index] * new Polinom(p_type, k);
                            result[i][l][j] += lambda[i][j * (rang[l] + 1) + k] * (new Polinom(p_type, k));
                        }
                    }
                }      
            }
            return result;     
        }
    }
}
