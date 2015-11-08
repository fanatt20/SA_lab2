using System;
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
                        B[i] = new double[Y[i].Length];
                    for (var i = 0; i < B.Length; i++)
                        for (var j = 0; j < B[i].Length; j++)
                            B[i][j] = (Y[i].Max() + Y[i].Min()) / 2;
                    break;
                case BType.Type2:
                    for (var i = 0; i < Y.Length; i++)
                        B[i] = new double[Y[i].Length];
                    for (var i = 0; i < B.Length; i++)
                        for (var j = 0; j < B[i].Length; j++)
                            B[i][j] = Y[i].Average();
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

        public static double[][] A_Create(int[] rang, PolinomType p_type, double[][] X1, double[][] X2,
            double[][] X3, double[][] Y)
        {
            var rang_1 = rang[0];
            var rang_2 = rang[1];
            var rang_3 = rang[2];
            var A = new double[Y.Length][];
            for (var i = 0; i < A.Length; i++)
                A[i] =
                    new double[(rang_1 + 1)*(X1[0].Length) + (rang_2 + 1)*(X2[0].Length) + (rang_3 + 1)*(X3[0].Length)];
            for (var i = 0; i < A.Length; i++)
            {
                for (var j = 0; j < X1[0].Length; j++)
                    for (var k = 0; k < rang_1 + 1; k++)
                        A[i][j * (rang_1 + 1) + k] = new Polynom().Calculate(X1[i][j], k, p_type);
                for (var j = 0; j < X2[0].Length; j++)
                    for (var k = 0; k < rang_2 + 1; k++)
                        A[i][(rang_1 + 1) * (X1[0].Length) + j * (rang_2 + 1) + k] = new Polynom().Calculate(X2[i][j], k,
                            p_type);
                for (var j = 0; j < X3[0].Length; j++)
                    for (var k = 0; k < rang_3 + 1; k++)
                        A[i][(rang_1 + 1) * (X1[0].Length) + (rang_2 + 1) * (X2[0].Length) + j * (rang_3 + 1) + k] =
                            new Polynom().Calculate(X3[i][j], k, p_type);
            }
            return A;
        }

        public static double[][] Al_Create(int matrix_number, int rang, PolinomType p_type, double[][] X1, double[][] X2,
            double[][] X3, double[][] Y)
        {
            var A = new double[Y.Length][];
            switch (matrix_number)
            {
                case 1:
                    for (int i = 0; i < A.Length; i++) A[i] = new double[(rang + 1) * (X1[0].Length)];
                    for (int i = 0; i < A.Length; i++)
                    {
                        for (int j = 0; j < X1[0].Length; j++)
                        {
                            for (int k = 0; k < rang + 1; k++) A[i][j * (rang + 1) + k] = new Polynom().Calculate(X1[i][j], k, p_type);
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < A.Length; i++) A[i] = new double[(rang + 1) * (X2[0].Length)];
                    for (int i = 0; i < A.Length; i++)
                    {
                        for (int j = 0; j < X2[0].Length; j++)
                        {
                            for (int k = 0; k < rang + 1; k++) A[i][j * (rang + 1) + k] = new Polynom().Calculate(X2[i][j], k,
                            p_type);
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < A.Length; i++) A[i] = new double[(rang + 1) * (X3[0].Length)];
                    for (int i = 0; i < A.Length; i++)
                    {
                        for (int j = 0; j < X3[0].Length; j++)
                        {
                            for (int k = 0; k < rang + 1; k++) A[i][j * (rang + 1) + k] = new Polynom().Calculate(X3[i][j], k, p_type);
                        }
                    }
                    break;
            }
            return A;
        }

        /*
        Xt = Data.Xt {t : 1,2,3}
            */
        static double[][] W(Polinom[][] p, double[][] X, int t)
        {
            double[][] w;
            w = new double[X.Length][];
            for (int i = 0; i < w.Length; i++)
            {
                w[i] = new double[p[t - 1].Length];
                for (int j = 0; j < w[i].Length; j++)
                    w[i][j] = p[t - 1][j].zn(X[i][j]);
            }
            return w;
        }

        public static double[][][] A_Get(double[][][]x, double[][] yt, Polinom[][][] psi)
        {
            double[][][] a = new double[yt.Length][][];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new double[3][];
                for (int j = 0; j < 3; j++)
                {
                    double[][] w = W(psi[i], x[j], j + 1);
                    //a[i][j] = SlaeSolver.Solve(w, yt[i]);
                    a[i][j] = Gradient_method.X(w, yt[i], 0.00001);
                }
            }
            return a;
        }

        public static double[][][] F_Get(double [][][]x, double[][] y, double[][] yt, double[][][] a, Polinom[][][] psi)
        {
            double[][][] tF = new double[yt.Length][][];
            for (int i = 0; i < tF.Length; i++)
            {
                tF[i] = new double[y.Length][];
                for (int j = 0; j < tF[i].Length; j++)
                {
                    tF[i][j] = new double[3];
                    for (int k = 0; k < 3; k++)
                    {
                        tF[i][j][k] = F(psi, x[k], a, k, i, j);
                    }
                }
            }
            return tF;
        }

        private static double F(Polinom[][][] p, double[][] X, double[][][] a, int x, int y, int q)
        {
            double A = 0;
            for (int i = 0; i < p[y][x].Length; i++)
                A += (a[y][x][i] * p[y][x][i]).zn(X[q][i]);
            return A;
        }

        public static double[][] C_Get(double[][] yt, double[][][] f)
        {
            double[][] c = new double[yt.Length][];
            for (int i = 0; i < c.Length; i++)
            {
                //c[i] = SlaeSolver.Solve(f[i], yt[i]);
                c[i] = Gradient_method.X(f[i], yt[i], 0.00001);
            }
            return c;
        }

        public static double[][] Y_Get(double[][][] a, double[][][] x, double[][] c, Polinom[][][] psi, int length, int length2)
        {
            var Yo = new double[length][];
            for (int i = 0; i < Yo.Length; i++)
            {
                Yo[i] = new double[length2];
                for (int j = 0; j < Yo[i].Length; j++)
                {
                    Yo[i][j] = f(psi, x, a, c, i, j);
                }
            }
            return Yo;
        }
        private static double f(Polinom[][][] psi, double[][][]x, double[][][] a, double[][] c, int y, int q)
        {
            double A = 0;
            for (int i = 0; i < c[y].Length; i++)
                A += c[y][i] * F(psi, x[i], a, i, y, q);
            return A;

        }
        public static double sq_err(double[] y1, double[] y2)
        {
            double err = 0;
            for (int i = 0; i < y1.Length; i++)
                err += (y1[i] - y2[i]) * (y1[i] - y2[i]);
            return err;
        }
    }
}