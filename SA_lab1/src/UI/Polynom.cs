using System;

namespace Algorithms
{
    public enum PolinomType
    {
        Chebyshev = 1,
        Lejandr,
        Lagger,
        Hermit
    }

    internal class Polynom
    {
        public double Chebyshev(double x, int rang)
        {
            if (rang < 0) return 0;
            if (rang == 0) return 1;
            if (rang == 1) return -1 + 2*x;

            return 2*(-1 + 2*x)*Chebyshev(x, rang - 1) - Chebyshev(x, rang - 2);
        }

        public double Lejandr(double x, int rang)
        {
            if (rang < 0) return 0;
            if (rang == 0) return 1;
            if (rang == 1) return x;

            return (1.0/(rang))*((2*rang - 1)*x*Lejandr(x, rang - 1) -
                                 (rang - 1)*Lejandr(x, rang - 2));
        }

        public double Lagger(double x, int rang)
        {
            if (rang < 0) return 0;
            if (rang == 0) return 1;
            if (rang == 1) return -x + 1;

            return (2*rang - 1 - x)*Lagger(x, rang - 1) -
                   (rang - 1)*(rang - 1)*Lagger(x, rang - 2);
        }

        public double Hermit(double x, int rang)
        {
            if (rang < 1) return 0;
            if (rang == 1) return 2*x;
            if (rang == 2) return 4*x*x - 2;

            return 2*x*Hermit(x, rang - 1) - 2*(rang - 1)*Hermit(x, rang - 2);
        }

        public double Calculate(double x, int rang, PolinomType type)
        {
            switch (type)
            {
                case PolinomType.Chebyshev:
                    return Chebyshev(x, rang);
                case PolinomType.Lejandr:
                    return Lejandr(x, rang);
                case PolinomType.Lagger:
                    return Lagger(x, rang);
                case PolinomType.Hermit:
                    return Hermit(x, rang);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}