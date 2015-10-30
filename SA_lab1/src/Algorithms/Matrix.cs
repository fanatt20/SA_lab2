﻿using System;
using System.Linq;

namespace Algorithms
{
    public class Matrix
    {
        public enum BType
        {
            Type1 = 1,
            Type2,
            Type3
        }

        public static double[][] B_Create(BType b_type, double[][] Y)
        {
            var B = new double[Y.Length][];
            switch (b_type)
            {
                case BType.Type1:
                    for (var i = 0; i < Y.Length; i++)
                        B[i] = new double[1];
                    for (var i = 0; i < Y.Length; i++)
                        B[i][0] = (Y[i].Max() + Y[i].Min())/2;
                    break;
                case BType.Type2:
                    for (var i = 0; i < Y.Length; i++)
                        B[i] = new double[1];
                    for (var i = 0; i < Y.Length; i++)
                        B[i][0] = Y[i].Average();
                    break;
                case BType.Type3:
                    for (var i = 0; i < Y.Length; i++)
                        B[i] = new double[Y[i].Length];
                    for (var i = 0; i < B.Length; i++)
                        for (var j = 0; j < B[i].Length; j++)
                            B[i][j] = Y[i][j];
                    break;
                default:
                    throw new NotSupportedException();
            }
            return B;
        }

        public static double[][] A_Create(int rang_1, int rang_2, int rang_3, PolinomType p_type, double[][] X1, double[][] X2,
            double[][] X3, double[][] Y)
        {
            var A = new double[Y.Length][];
            for (var i = 0; i < A.Length; i++)
                A[i] =
                    new double[(rang_1 + 1)*(X1[0].Length) + (rang_2 + 1)*(X2[0].Length) + (rang_3 + 1)*(X3[0].Length)];
            for (var i = 0; i < A.Length; i++)
            {
                for (var j = 0; j < X1[0].Length; j++)
                    for (var k = 0; k < rang_1 + 1; k++)
                        A[i][j*(rang_1 + 1) + k] = new Polynom().Calculate(X1[i][j], k, p_type);
                for (var j = 0; j < X2[0].Length; j++)
                    for (var k = 0; k < rang_2 + 1; k++)
                        A[i][(rang_1 + 1)*(X1[0].Length) + j*(rang_2 + 1) + k] = new Polynom().Calculate(X2[i][j], k,
                            p_type);
                for (var j = 0; j < X3[0].Length; j++)
                    for (var k = 0; k < rang_3 + 1; k++)
                        A[i][(rang_1 + 1)*(X1[0].Length) + (rang_2 + 1)*(X2[0].Length) + j*(rang_3 + 1) + k] =
                            new Polynom().Calculate(X3[i][j], k, p_type);
            }
            return A;
        }
    }
}