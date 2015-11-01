using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Polinom : List<double>
    {
        public Polinom(PolinomType type = 0, int rang = 0)
            : base()
        {
            switch (type)
            {
                case 0:
                    break;
                case PolinomType.Chebyshev:
                    switch (rang)
                    {
                        case 0:
                            this.Add(1);
                            break;
                        case 1:
                            this.Add(-2);
                            this.Add(4);
                            break;
                        case 2:
                            this.Add(3);
                            this.Add(-16);
                            this.Add(16);
                            break;
                        case 3:
                            this.Add(-4);
                            this.Add(40);
                            this.Add(-96);
                            this.Add(64);
                            break;
                        default:
                            Polinom p = new Polinom();
                            p.Add(-1);
                            p.Add(2);
                            Polinom pp = 2 * p * (new Polinom(type, rang - 1)) + (-1) * (new Polinom(type, rang - 2));
                            for (int i = 0; i < pp.Count; i++)
                                this.Add(pp[i]);
                            break;
                    }
                    break;                
                case PolinomType.Lejandr:
                    switch (rang)
                    {
                        case 0:
                            this.Add(1);
                            break;
                        case 1:
                            this.Add(-1);
                            this.Add(2);
                            break;
                        case 2:
                            this.Add(-1);
                            this.Add(6);
                            this.Add(-6);
                            break;
                        case 3:
                            this.Add(-1);
                            this.Add(12);
                            this.Add(-30);
                            this.Add(20);
                            break;
                        case 4:
                            this.Add(-1);
                            this.Add(20);
                            this.Add(-90);
                            this.Add(140);
                            this.Add(-70);
                            break;
                        case 5:
                            this.Add(-1);
                            this.Add(30);
                            this.Add(-210);
                            this.Add(560);
                            this.Add(-630);
                            this.Add(252);
                            break;
                        default:
                            throw new Exception("Неверный порядок полинома");
                    }
                    break;
                case PolinomType.Lagger:
                    switch (rang)
                    {
                        case 0:
                            this.Add(1);
                            break;
                        case 1:
                            this.Add(1);
                            this.Add(-1);
                            break;
                        case 2:
                            this.Add(2);
                            this.Add(-4);
                            this.Add(1);
                            break;
                        case 3:
                            this.Add(6);
                            this.Add(-18);
                            this.Add(9);
                            this.Add(-1);
                            break;
                        default:
                            Polinom p = new Polinom();
                            p.Add(2 * (rang - 1) + 1);
                            p.Add(-1);
                            Polinom pp = p * (new Polinom(type, rang - 1)) + (-1) * (rang - 1) * (rang - 1) * (new Polinom(type, rang - 2));
                            for (int i = 0; i < pp.Count; i++)
                                this.Add(pp[i]);
                            break;
                    }
                    break;
                case PolinomType.Hermit:
                    switch (rang)
                    {
                        case 0:
                            this.Add(1);
                            break;
                        case 1:
                            this.Add(0);
                            this.Add(2);
                            break;
                        case 2:
                            this.Add(-2);
                            this.Add(0);
                            this.Add(4);
                            break;
                        case 3:
                            this.Add(0);
                            this.Add(-12);
                            this.Add(0);
                            this.Add(8);
                            break;
                        case 4:
                            this.Add(12);
                            this.Add(0);
                            this.Add(-48);
                            this.Add(0);
                            this.Add(16);
                            break;
                        default:
                            Polinom p = new Polinom();
                            p.Add(0);
                            p.Add(2);
                            Polinom pp = p * (new Polinom(type, rang - 1)) + (-2) * (rang - 1) * (new Polinom(type, rang - 2));
                            for (int i = 0; i < pp.Count; i++)
                                this.Add(pp[i]);
                            break;
                    }
                    break;               
                default:
                    throw new Exception("Неверный тип полинома");
            }
        }

        static public Polinom operator + (Polinom p1, Polinom p2)
        {
            int max;
            if (p1.Count > p2.Count) max = p1.Count;
            else max = p2.Count;
            Polinom p = new Polinom();
            for (int i = 0; i < max; i++)
            {
                double rez=0;
                if (i < p1.Count) rez += p1[i];
                if (i < p2.Count) rez += p2[i];
                p.Add(rez);
            }
            return p;
        }
        static public Polinom operator * (double a, Polinom p)
        {
            Polinom pol = new Polinom();
            for (int i = 0; i < p.Count; i++)
                pol.Add(a*p[i]);
            return pol;

        }
        static public Polinom operator *(Polinom p1, Polinom p2)
        {
            Polinom p = new Polinom();
            for (int i = 0; i < p1.Count; i++)
            {
                Polinom pp = new Polinom();
                for (int j = 0; j < i; j++) pp.Add(0);
                for (int j = 0; j < p2.Count; j++) pp.Add(p1[i] * p2[j]);
                p = p + pp;
            }
            return p;
        }

        public string ToString(string sx="x")
        {
            string s = "";
            if (this.Count > 0)
            {
                for (int i = this.Count - 1; i > 0; i--)
                {
                    s += this[i] + "*"+sx+"^" + i + " + ";
                }
                s += this[0];
            }
            return s;
        }

        public double zn(double x)
        {

            double rez=0;
            if (this.Count > 0)
            {
                rez += this[0];
                for (int i = 1; i < this.Count; i++)
                    rez += this[i] * Math.Pow(x, i);
            }
            return rez;
        }
    }
}
