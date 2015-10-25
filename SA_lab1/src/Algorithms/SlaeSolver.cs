using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    //Solving Systems of Linear Algebric Equations (SLAE) AX=B, using method of best probe.
    class SlaeSolver
    {
        //optional parameter
        private const double STEP_REDUCE_PARAMETER = 0.99;
        //size of step in random seeking 
        private const double STEP = 0.0000001;
        //amount of random vectors
        private const int M = 500;
        //accuracy of calculations for finding solution
        private const double ACCURACY = 0.0000000001;
        //input parameters holder
        private static ParameterHolder Params;
        private static Random randomValues;

        public static double[] Solve(double[][] a, double[] b)
        {
            if (a == null || a.Length == 0 || b == null || b.Length == 0)
                return null;
            Params = new ParameterHolder(a, b);
            var x = GetX0(a.Length / a.Length);
            Params.Value = F(x);
            while (Params.Value > ACCURACY)
            {
                x = GetBestValue(x);
            }
            return x;
        }

        private static double[] GetBestValue(double[] x)
        {
            var values = GetRandomVectors(x);
            var bestValue = F(x);
            var result = x;
            foreach (double[] tempX in values) {
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
            LinkedList<double[]> result = new LinkedList<double[]>();
            for (int i = 0; i < M; i++)
            {
                var vector = new double[x.Length];
                for (int j = 0; j < x.Length; j++)
                    vector[j] = GetPseudoRandomValue();
                var norma = GetVectorNorma(vector);
                for (int j = 0; j < x.Length; j++)
                    vector[j] = x[j] + vector[j]*GetStep()/norma;
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
            return STEP * Math.Pow(STEP_REDUCE_PARAMETER, Params.Iteration);
        }

        private static double GetVectorNorma(double[] vector)
        {
            var result = 0.0;
            for (int i = 0; i < vector.Length; i++)
                result += vector[i] * vector[i];
            return Math.Sqrt(result);
        }

        private static double[] GetX0(int size)
        {
            var result = new double[size];
            for (int i = 0; i < size; i++)
                result[i] = 0;
            return result;
        }

        private static double F(double[] x)
        {
            var result = 0.0;
            for (int i = 0; i < Params.B.Length; i++)
            {
                double temp = -Params.B[i];
                for (int j = 0; j < x.Length; j++)
                {
                    temp += Params.A[i][j] * x[j];
                }
                result += temp*temp;
            }
            return result;
        }

        private class ParameterHolder
        {
            public double[][] A;
            public double[] B;
            public int Iteration = 0;
            public double Value = 0;

            public ParameterHolder(double[][] a, double[] b)
            {
                A = a;
                B = b;
            }
        }
    }
}
