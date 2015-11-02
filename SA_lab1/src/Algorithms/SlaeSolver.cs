using System;
using System.Collections.Generic;

namespace Algorithms
{
    //Solving Systems of Linear Algebric Equations (SLAE) AX=B, using method of best probe.
    public class SlaeSolver
    {
        private const int MAX_ITERS = 100000;
        //amount of random vectors
        private const int M = 50;
        //accuracy of calculations for finding solution
        private const double ACCURACY = 0.00000001;
        //optional parameter
        private static readonly double STEP_REDUCE_PARAMETER = 0.5;
        //size of step in random seeking 
        private readonly static double STEP = 100000;
        //input parameters holder
        private static ParameterHolder Params;
        private static Random randomValues;

        public static double[] Solve(double[,] a, double[] b)
        {
            if (a == null || a.Length == 0 || b == null || b.Length == 0)
                return null;
            Params = new ParameterHolder(a, b);
            var x = GetX0(Params.A.GetLength(1));
            Params.Value = F(x);
            while (Params.Value > ACCURACY && Params.Iteration++ < MAX_ITERS)
            {
                x = GetBestValue(x);
            }
            return x;
        }

        public static double[] Solve(double[][] a, double[] b)
        {
            if (a == null || a.Length == 0 || b == null || b.Length == 0)
                return null;
            double[,] aFormatted = new double [a.Length, a[0].Length];
            int i = 0;
            foreach (double[] arr in a)
            {
                int j = 0;
                foreach (double val in arr)
                {
                    aFormatted[i, j] = a[i][j];
                    j++;
                }
                i++;
            }
            return Solve(aFormatted, b);
        }

        private static double[] GetBestValue(double[] x)
        {
            var values = GetRandomVectors(x);
            var bestValue = F(x);
            var result = x;
            foreach (var tempX in values)
            {
                var value = F(tempX);
                if (bestValue > value)
                {
                    bestValue = value;
                    result = tempX;
                }
            }
            Params.Value = bestValue;
            return result;
        }

        private static LinkedList<double[]> GetRandomVectors(double[] x)
        {
            var result = new LinkedList<double[]>();
            var step = GetStep();
            for (var i = 0; i < (Params.Iteration < 2 ? M * 20 : M); i++)
            {
                var vector = new double[x.Length];
                for (var j = 0; j < x.Length; j++)
                    vector[j] = GetPseudoRandomValue();
                var norma = GetVectorNorma(vector);
                for (var k = 0; k < x.Length; k++)
                    vector[k] = x[k] + vector[k]*step/norma;
                result.AddLast(vector);
            }
            return result;
        }

        //returns pseudorandom value from -1 to 1
        private static double GetPseudoRandomValue()
        {
            if (randomValues == null)
                randomValues = new Random();
            return randomValues.NextDouble()*2.0 - 1.0;
        }

        private static double GetStep()
        {
            var multiplier = Params.Iteration < 2 ? 0.1 : Math.Pow(STEP_REDUCE_PARAMETER, Params.Iteration);
            return STEP*multiplier;
        }

        private static double GetVectorNorma(double[] vector)
        {
            var result = 0.0;
            for (var i = 0; i < vector.Length; i++)
                result += vector[i]*vector[i];
            return Math.Sqrt(result);
        }

        private static double[] GetX0(int size)
        {
            var result = new double[size];
            for (var i = 0; i < size; i++)
                result[i] = 0;
            return result;
        }

        private static double F(double[] x)
        {
            var result = 0.0;
            for (var i = 0; i < Params.B.Length; i++)
            {
                var temp = -Params.B[i];
                for (var j = 0; j < x.Length; j++)
                {
                    temp += Params.A[i, j]*x[j];
                }
                result += temp*temp;
            }
            var inputParam = x; //todo delete
            return result;
        }

        private class ParameterHolder
        {
            public readonly double[,] A;
            public readonly double[] B;
            public int Iteration;
            public double Value;

            public ParameterHolder(double[,] a, double[] b)
            {
                A = a;
                B = b;
            }
        }
    }
}