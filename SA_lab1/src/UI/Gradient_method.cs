using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Gradient_method
    {
        static public double[] X(Double[][] A, Double[] f, double eps)
        {
            Double[] x = new double[A[0].Length];
            Double[] xn;
            for (int i = 0; i < x.Length; i++) x[i] = 0;
            do
            {
                xn = new double[x.Length];
                double[] grad = gradientF(A, f, x);
                double[][] ges = GesseF(A);
                double a = 0;
                for (int i = 0; i < grad.Length; i++) a += grad[i] * grad[i];
                double tmp = 0;
                for (int k = 0; k < ges.Length; k++)
                    for (int h = 0; h < ges.Length; h++)
                        tmp += ges[k][h] * grad[k] * grad[h];
                a /= tmp;
                for (int i = 0; i < x.Length; i++) xn[i] = x[i] - a * grad[i];
                if (F(A, f, xn) > F(A, f, x)) return x;
                if ((dif(x, xn) > eps) && (F(A, f, xn) > eps)) x = xn;
                else { x = xn; break; }
            } while (true);
            return x;
        }

        static double dif(double[] x1, double[] x2)
        {
            double rez = 0;
            for (int i = 0; i < x1.Length; i++) rez += Math.Pow(x1[i] - x2[i], 2);
            return Math.Sqrt(rez);
        }

        static double F(Double[][] A, Double[] f, Double[] x)
        {
            double rez = 0;
            for (int i = 0; i < f.Length; i++)
            {
                double tmp = 0;
                for (int j = 0; j < x.Length; j++) { tmp += A[i][j] * x[j]; }
                tmp -= f[i];
                rez += tmp * tmp;
            }
            return rez;
        }

        static double[] gradientF(Double[][] A, Double[] f, Double[] x)
        {
            double[] grad = new double[x.Length];
            for (int k = 0; k < grad.Length; k++)
            {
                double rez = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    double tmp = 0;
                    for (int j = 0; j < x.Length; j++) tmp += A[i][j] * x[j];
                    tmp -= f[i];
                    tmp = 2 * A[i][k] * tmp;
                    rez += tmp;
                }
                grad[k] = rez;
            }
            return grad;
        }

        static double[][] GesseF(Double[][] A)
        {
            double[][] ges = new double[A[0].Length][];
            for (int i = 0; i < ges.Length; i++) ges[i] = new double[ges.Length];
            for (int k = 0; k < ges.Length; k++)
                for (int j = 0; j < ges[k].Length; j++)
                {
                    double tmp = 0;
                    for (int i = 0; i < A.Length; i++) tmp += A[i][k] * A[i][j];
                    ges[k][j] = 2 * tmp;
                }
            return ges;
        }
    }
}
