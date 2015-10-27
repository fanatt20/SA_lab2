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

        //public static double A_Create(int x1, int x2, int x3, int p_type, double[][] X1, double[][] X2, double[][] X3, double[][] Y)
        //{
        //    double[][] Rez = new double[Y.Length][];
        //    for (int i = 0; i < Rez.Length; i++) Rez[i] = new double[(x1 + 1) * (X1[0].Length - 1) + (x2 + 1) * (X2[0].Length - 1) + (x3 + 1) * (X3[0].Length - 1)];
        //    for (int i = 0; i < Rez.Length; i++)
        //    {
        //        for (int j = 0; j < X1[0].Length - 1; j++)
        //        {
        //            for (int k = 0; k < x1 + 1; k++) Rez[i][j * (x1 + 1) + k] = (new Polinom(p_type, k)).zn(X1[i][j + 1]);
        //        }
        //        for (int j = 0; j < X2[0].Length - 1; j++)
        //        {
        //            for (int k = 0; k < x2 + 1; k++) Rez[i][(x1 + 1) * (X1[0].Length - 1) + j * (x2 + 1) + k] = (new Polinom(p_type, k)).zn(X2[i][j + 1]);
        //        }
        //        for (int j = 0; j < X3[0].Length - 1; j++)
        //        {
        //            for (int k = 0; k < x3 + 1; k++) Rez[i][(x1 + 1) * (X1[0].Length - 1) + (x2 + 1) * (X2[0].Length - 1) + j * (x3 + 1) + k] = (new Polinom(p_type, k)).zn(X3[i][j + 1]);
        //        }
        //    }
        //    return Rez;
        //}
    }
}
