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

        public static double[] log(double[] vec)
        {
            var e = 0;           
            double[] rez = new double[vec.Length];
            for (int i = 0; i < rez.Length; i++)
            {
                rez[i] = Math.Log(vec[i] + 1 + e);
            }
            return rez;
        }

        public static double[] Asin(double[] vec)
        {
            double[] rez = new double[vec.Length];
            for (int i = 0; i < rez.Length; i++)
            {
                rez[i] = Math.Log(Math.Asin(vec[i]) + 1.6);
            }
            return rez;
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

        public static double[][] Am_Create(int[] rang, PolinomType p_type, double[][] X1, double[][] X2,
            double[][] X3, double[][] Y)
        {
            var rang_1 = rang[0];
            var rang_2 = rang[1];
            var rang_3 = rang[2];
            var A = new double[Y.Length][];
            for (var i = 0; i < A.Length; i++)
                A[i] =
                    new double[(rang_1 + 1) * (X1[0].Length) + (rang_2 + 1) * (X2[0].Length) + (rang_3 + 1) * (X3[0].Length)];
            for (var i = 0; i < A.Length; i++)
            {
                for (var j = 0; j < X1[0].Length; j++)
                    for (var k = 0; k < rang_1 + 1; k++)
                        A[i][j * (rang_1 + 1) + k] = Math.Log(1+ new Polynom().Calculate(X1[i][j], k, p_type));
                for (var j = 0; j < X2[0].Length; j++)
                    for (var k = 0; k < rang_2 + 1; k++)
                        A[i][(rang_1 + 1) * (X1[0].Length) + j * (rang_2 + 1) + k] = Math.Log(1+ new Polynom().Calculate(X2[i][j], k,
                            p_type));
                for (var j = 0; j < X3[0].Length; j++)
                    for (var k = 0; k < rang_3 + 1; k++)
                        A[i][(rang_1 + 1) * (X1[0].Length) + (rang_2 + 1) * (X2[0].Length) + j * (rang_3 + 1) + k] =
                            Math.Log(1+new Polynom().Calculate(X3[i][j], k, p_type));
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

        public static double[][] Alm_Create(int matrix_number, int rang, PolinomType p_type, double[][] X1, double[][] X2,
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
                            for (int k = 0; k < rang + 1; k++) A[i][j * (rang + 1) + k] = Math.Log(1+new Polynom().Calculate(X1[i][j], k, p_type));
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < A.Length; i++) A[i] = new double[(rang + 1) * (X2[0].Length)];
                    for (int i = 0; i < A.Length; i++)
                    {
                        for (int j = 0; j < X2[0].Length; j++)
                        {
                            for (int k = 0; k < rang + 1; k++) A[i][j * (rang + 1) + k] = Math.Log(1+new Polynom().Calculate(X2[i][j], k,
                            p_type));
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < A.Length; i++) A[i] = new double[(rang + 1) * (X3[0].Length)];
                    for (int i = 0; i < A.Length; i++)
                    {
                        for (int j = 0; j < X3[0].Length; j++)
                        {
                            for (int k = 0; k < rang + 1; k++) A[i][j * (rang + 1) + k] = Math.Log(1+new Polynom().Calculate(X3[i][j], k, p_type));
                        }
                    }
                    break;
            }
            return A;
        }

        public static double[][] Alms_Create(int matrix_number, int rang, PolinomType p_type, double[][] X1, double[][] X2,
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
                            for (int k = 0; k < rang + 1; k++) A[i][j * (rang + 1) + k] = Math.Log(1.6 + Math.Asin(new Polynom().Calculate(X1[i][j], k, p_type)));
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < A.Length; i++) A[i] = new double[(rang + 1) * (X2[0].Length)];
                    for (int i = 0; i < A.Length; i++)
                    {
                        for (int j = 0; j < X2[0].Length; j++)
                        {
                            for (int k = 0; k < rang + 1; k++) A[i][j * (rang + 1) + k] = Math.Log(1.6 + Math.Asin(new Polynom().Calculate(X2[i][j], k,
                            p_type)));
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < A.Length; i++) A[i] = new double[(rang + 1) * (X3[0].Length)];
                    for (int i = 0; i < A.Length; i++)
                    {
                        for (int j = 0; j < X3[0].Length; j++)
                        {
                            for (int k = 0; k < rang + 1; k++) A[i][j * (rang + 1) + k] = Math.Log(1.6 + Math.Asin(new Polynom().Calculate(X3[i][j], k, p_type)));
                        }
                    }
                    break;
            }
            return A;
        }

        /*
        Xt = Data.Xt {t : 1,2,3}
            */
        static double[][] W(Psi[][] p, double[][] X, int t, int multiplicative)
        {
            double[][] w;
            var e = 0;
            w = new double[X.Length][];
            for (int i = 0; i < w.Length; i++)
            {
                w[i] = new double[p[t - 1].Length];
                for (int j = 0; j < w[i].Length; j++)
                {
                    if (multiplicative == 0)
                        w[i][j] = p[t - 1][j].value(X[i][j]);
                    else if (multiplicative == 1) w[i][j] = Math.Log(1 + e + p[t - 1][j].value(X[i][j]));
                    else w[i][j] = Math.Log(1.6 + Math.Asin(p[t - 1][j].value(X[i][j])));
                }
            }
            return w;
        }

        public static double[][][] A_Get(double[][][]x, double[][] yt, Psi[][][] psi, int method, int multiplicative)
        {
            double[][][] a = new double[yt.Length][][];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new double[3][];
                for (int j = 0; j < 3; j++)
                {
                    double[][] w = W(psi[i], x[j], j + 1, multiplicative);
                    switch (method)
                    {
                        case 0:
                            if (multiplicative ==0)
                                a[i][j] = SlaeSolver.Solve(w, yt[i]);
                            else if(multiplicative==1) a[i][j] = SlaeSolver.Solve(w, log(yt[i]));
                            else if (multiplicative == 2) a[i][j] = SlaeSolver.Solve(w, Asin(yt[i]));
                            break;
                        case 1:
                            if (multiplicative==0)
                                a[i][j] = Gradient_method.X(w, yt[i], 0.00001);
                            else if(multiplicative==1) a[i][j] = Gradient_method.X(w, log(yt[i]), 0.00001);
                            else if (multiplicative == 2) a[i][j] = Gradient_method.X(w, Asin(yt[i]), 0.00001);
                            break;
                    }            
                }
            }
            return a;
        }

        public static double[][][] F_Get(double [][][]x, double[][] y, double[][] yt, double[][][] a, Psi[][][] psi, int multiplicative)
        {
            double[][][] tF = new double[yt.Length][][];
            var e = 0;
            for (int i = 0; i < tF.Length; i++)
            {
                tF[i] = new double[y.Length][];
                for (int j = 0; j < tF[i].Length; j++)
                {
                    tF[i][j] = new double[3];
                    for (int k = 0; k < 3; k++)
                    {
                        if (multiplicative == 0)
                            tF[i][j][k] = F(psi, x[k], a, k, i, j, multiplicative);
                        else if (multiplicative == 1) tF[i][j][k] = Math.Log(1 + e + F(psi, x[k], a, k, i, j, multiplicative));
                        else tF[i][j][k] = Math.Log(1.6 + Math.Asin(F(psi, x[k], a, k, i, j, multiplicative)));
                    }
                }
            }
            return tF;
        }

        private static double F(Psi[][][] p, double[][] X, double[][][] a, int x, int y, int q, int multiplicative)
        {
            var e = 0;
            if(multiplicative==0)
            {
                double A = 0;
                for (int i = 0; i < p[y][x].Length; i++)
                    A += a[y][x][i] * (p[y][x][i]).value(X[q][i]);
                return A;
            }
            else if(multiplicative==1)
            {
                double A = 1;
                for (int i = 0; i < p[y][x].Length; i++)
                    A *= Math.Pow(1+e+(p[y][x][i]).value(X[q][i]), a[y][x][i]);
                A -= 1 + e;
                return A;
            }
            else
            {
                double A = 1;
                for (int i = 0; i < p[y][x].Length; i++)
                    A *= Math.Pow(1.6 + Math.Asin((p[y][x][i]).value(X[q][i])), a[y][x][i]);
                A -= 1.6;
                return Math.Sin(A);
            }
        }

        public static double[][] C_Get(double[][] yt, double[][][] f, int method, int multiplicative)
        {
            double[][] c = new double[yt.Length][];
            for (int i = 0; i < c.Length; i++)
            {
                switch (method)
                {
                    case 0:
                        if(multiplicative==0)
                            c[i] = SlaeSolver.Solve(f[i], yt[i]);
                        else if(multiplicative==1) c[i] = SlaeSolver.Solve(f[i], log(yt[i]));
                        else c[i] = SlaeSolver.Solve(f[i], Asin(yt[i]));
                        break;
                    case 1:
                        if(multiplicative==0)
                            c[i] = Gradient_method.X(f[i], yt[i], 0.00001);                        
                        else if(multiplicative==1) c[i] = Gradient_method.X(f[i], log(yt[i]), 0.00001);
                        else c[i] = Gradient_method.X(f[i], Asin(yt[i]), 0.00001);
                        break;
                }         
            }
            return c;
        }

        public static double[][] Y_Get(double[][][] a, double[][][] x, double[][] c, Psi[][][] psi, int length, int length2, int multiplicative)
        {
            var Yo = new double[length][];
            for (int i = 0; i < Yo.Length; i++)
            {
                Yo[i] = new double[length2];
                for (int j = 0; j < Yo[i].Length; j++)
                {
                    Yo[i][j] = f(psi, x, a, c, i, j, multiplicative);
                }
            }
            return Yo;
        }
        private static double f(Psi[][][] psi, double[][][]x, double[][][] a, double[][] c, int y, int q, int multiplicative)
        {
            var e = 0;
            if(multiplicative==0)
            {
                double A = 0;
                for (int i = 0; i < c[y].Length; i++)
                    A += c[y][i] * F(psi, x[i], a, i, y, q, multiplicative);
                return A;
            }
            else if(multiplicative==1)
            {
                double A = 1;
                for (int i = 0; i < c[y].Length; i++)
                    A *= Math.Pow(1+e+F(psi, x[i], a, i, y, q, multiplicative), c[y][i]);
                A -= 1 + e;
                return A;
            }
            else
            {
                double A = 1;
                for (int i = 0; i < c[y].Length; i++)
                    A *= Math.Pow(1.6 + Math.Asin(F(psi, x[i], a, i, y, q, multiplicative)), c[y][i]);
                A -= 1.6;
                return Math.Sin(A);
            }


        }
        public static double sq_err(double[] y1, double[] y2)
        {
            double err = 0;
            for (int i = 0; i < y1.Length; i++)
                err += (y1[i] - y2[i]) * (y1[i] - y2[i]);
            return err;
        }
        public static double max_err(double[] y1, double[] y2)
        {
            double[] err = new double[y1.Length];
            for(int i=0; i< err.Length; i++)
                err[i] = Math.Abs(y1[i] - y2[i]);
            return err.Max();
        }

        public static double[] VecConcat(double[] t1, double[] t2, double[] t3)
        {
            int N = t1.Length + t2.Length + t3.Length;
            double[] rez = new double[N];
            for (int i = 0; i < N; i++)
            {
                if (i < t1.Length)
                    rez[i] = t1[i];
                else
                    if (i < t1.Length + t2.Length)
                        rez[i] = t2[i - t1.Length];
                    else
                        rez[i] = t3[i - t1.Length - t2.Length];
            }
            return rez;
        }

        public static double[][] Concat(double[][] t1, double[][] t2, double[][] t3)
        {
            double[][] rez = new double[t1.Length][];
            int N = t1[0].Length + t2[0].Length + t3[0].Length;
            for (int i = 0; i < rez.Length; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (j < t1[0].Length)
                        rez[i][j] = t1[i][j];
                    else
                        if (j < t2[0].Length)
                            rez[i][j] = t2[i][j];
                        else rez[i][j] = t3[i][j];

                }
            }
            return rez;
        }
    }
}