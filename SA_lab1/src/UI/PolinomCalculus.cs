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
        public static Polinom[][][] CalculatePsi(double[][] lambda, PolinomType p_type, int[] rang, int[] x)
        {
            Polinom[][][] result = new Polinom[lambda.Length][][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new Polinom[3][];
                for (int l = 0; l < 3; l++)
                {
                    Log.WriteLine(" X" + i + ":");
                    result[i][l] = new Polinom[x[l]];
                    for (int j = 0; j < result[i][l].Length; j++)
                    {
                        int index = j * (rang[l] + 1);
                        for (int m = 0; m < l; m++)
                            index += (x[m]) * (rang[m] + 1);
                        var lambdaIJ = lambda[i][index];
                        var pol = (new Polinom(p_type, 0));
                        result[i][l][j] = lambdaIJ * pol;
                        Log.Write("w" + l + " = " + lambdaIJ + "*" + pol.ToString());
                        for (int k = 1; k <= rang[l]; k++)
                        {
                            index = j * (rang[l] + 1) + k;
                            for (int m = 0; m < l; m++)
                                index += (x[m]) * (rang[m] + 1);
                            var lambdaIJTemp = lambda[i][index];
                            var polTemp = new Polinom(p_type, k);
                            Log.Write(lambdaIJTemp>=0 ? " +" : " " + lambdaIJTemp + "*" + polTemp.ToString());
                            result[i][l][j] += lambda[i][index] * new Polinom(p_type, k);
                        }
                        Log.WriteLine(" = " + result[i][l][j].ToString());
                    }
                }      
            }
            return result;     
        }       
    }
}
