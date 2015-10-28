using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Matrix
    {
        public static double[][] B_Create(int b_type, double[][] Y)
        {
            double[][] B = new double[Y.Length][];
            if(b_type == 1)
            {
                for (int i = 0; i < Y.Length; i++)
                    B[i] = new double[1];
                for (int i = 0; i < Y.Length; i++)
                    B[i][0] = (Y[i].Max() + Y[i].Min())/2;
            }
            else if(b_type == 2)
            {
                for (int i = 0; i < Y.Length; i++)
                    B[i] = new double[1];
                for (int i = 0; i < Y.Length; i++)
                    B[i][0] = Y[i].Average();
            }
            else if(b_type == 3)
            {
                for(int i=0; i<Y.Length; i++)
                    B[i] = new double[Y[i].Length];
                for (int i = 0; i < B.Length; i++)
                    for (int j = 0; j < B[i].Length; j++)
                        B[i][j] = Y[i][j];
            }
            return B;
        }

        public static double[][] A_Create(int rang_1, int rang_2, int rang_3, int p_type, double[][] X1, double[][] X2, double[][] X3, double[][] Y)
        {
            double[][] A = new double[Y.Length][];
            for (int i = 0; i < A.Length; i++) A[i] = new double[(rang_1 + 1) * (X1[0].Length) + (rang_2 + 1) * (X2[0].Length) + (rang_3 + 1) * (X3[0].Length)];
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < X1[0].Length; j++)
                    for (int k = 0; k < rang_1 + 1; k++) A[i][j * (rang_1 + 1) + k] = new Polynom().Calculate(X1[i][j], k, p_type);
                for (int j = 0; j < X2[0].Length; j++)
                    for (int k = 0; k < rang_2 + 1; k++) A[i][(rang_1 + 1) * (X1[0].Length) + j * (rang_2 + 1) + k] = new Polynom().Calculate(X2[i][j], k, p_type);
                for (int j = 0; j < X3[0].Length; j++)
                    for (int k = 0; k < rang_3 + 1; k++) A[i][(rang_1 + 1) * (X1[0].Length) + (rang_2 + 1) * (X2[0].Length) + j * (rang_3 + 1) + k] = new Polynom().Calculate(X3[i][j], k, p_type);
            }
            return A;
        }
    }
}
