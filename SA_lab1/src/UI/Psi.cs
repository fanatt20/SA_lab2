﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class Psi : List<Polinom>
    {
        public List<double> lambda { get; set; }
        public int type;
        public Psi(int t)
            : base()
        {
            lambda = new List<double>();
            type = t;
        }

        public double value(double x)
        {
            double rez=0;
            switch (type)
            {
                case 0:
                    for (int i = 0; i < this.Count; i++)
                    {
                        rez += lambda[i] * this[i].value(x);
                    }
                    return rez;
                case 1:
                    for (int i = 0; i < this.Count; i++)
                    {
                        rez *= Math.Pow(1 + this[i].value(x), lambda[i]);
                    }
                    return rez - 1;
                default:
                    throw (new Exception(""));
            }
        }

        public string ToString(string s = "x")
        {
            string rez;
            switch (type)
            {
                case 0:
                    rez = lambda[0] + "*(" + this[0].ToString() + ")";
                    for (int i = 1; i < this.Count; i++)
                    {
                        rez += "+" + lambda[i] + "*(" + this[i].ToString(s) + ")";
                    }
                    return rez;
                case 1:
                    rez = "(" + (1 + Math.E).ToString() + "+" + this[0].ToString() + ")^" + lambda[0];
                    for (int i = 1; i < this.Count; i++)
                    {
                        rez += "*(" + (1 + Math.E).ToString() + "+" + this[i].ToString(s) + ")^" + lambda[i];
                    }
                    rez += "-" + (1 + Math.E).ToString();
                    return rez;
                default:
                    throw (new Exception(""));
            }
        }
    }
}