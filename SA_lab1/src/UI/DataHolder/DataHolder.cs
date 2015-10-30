using System;
using Algorithms;
using Algorithms.Extensions;

namespace UI.DataHolder
{
    internal class DataHolder : IDataHolder
    {
        private int _meterageCount = -1;

        private double[][] _variables;
        private double[][] _x1;
        private double[][] _x2;
        private double[][] _x3;
        private double[][] _y;

        public DataHolder()
        {
            Normalized = new NormalizedDataHolder();
        }


        public IDataHolder Normalized { get; }

        public int MeterageCount
        {
            get { return _meterageCount; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                _meterageCount = value;
                (Normalized as NormalizedDataHolder).MeterageCount = value;
            }
        }

        public double[][] AllVariables
        {
            get
            {
                return _variables == null
                    ? null
                    : _variables.TakeBySecondCoordinate(MeterageCount > 0 ? MeterageCount : _variables[0].Length);
            }
            set
            {
                _variables = value.DeepCopy();
                (Normalized as NormalizedDataHolder).AllVariables = DataNormalizer.Normalize(_variables);
            }
        }

        public double[][] X1
        {
            get
            {
                return _x1 == null ? null : _x1.TakeBySecondCoordinate(MeterageCount > 0 ? MeterageCount : _x1[0].Length);
            }
            set
            {
                _x1 = value.DeepCopy();
                (Normalized as NormalizedDataHolder).X1 = DataNormalizer.Normalize(_x1);
            }
        }

        public double[][] X2
        {
            get
            {
                return _x2 == null ? null : _x2.TakeBySecondCoordinate(MeterageCount > 0 ? MeterageCount : _x2[0].Length);
            }
            set
            {
                _x2 = value.DeepCopy();
                (Normalized as NormalizedDataHolder).X2 = DataNormalizer.Normalize(_x2);
            }
        }

        public double[][] X3
        {
            get
            {
                return _x3 == null ? null : _x3.TakeBySecondCoordinate(MeterageCount > 0 ? MeterageCount : _x3[0].Length);
            }
            set
            {
                _x3 = value.DeepCopy();
                (Normalized as NormalizedDataHolder).X3 = DataNormalizer.Normalize(_x3);
            }
        }

        public double[][] Y
        {
            get
            {
                return _y == null ? null : _y.TakeBySecondCoordinate(MeterageCount > 0 ? MeterageCount : _y[0].Length);
            }
            set
            {
                _y = value.DeepCopy();
                (Normalized as NormalizedDataHolder).Y = DataNormalizer.Normalize(_y);
            }
        }

        public void SetVariables(double[][] variables, int[] dimensions)
        {
            AllVariables = variables;
            var splicedVars = variables.SpliceAccordingDims(dimensions);


            X1 = splicedVars[0];
            X2 = splicedVars[1];
            X3 = splicedVars[2];
        }

        public void ChangeDimensions(int[] newDimensions)
        {
            var splicedVars = _variables.SpliceAccordingDims(newDimensions);

            X1 = splicedVars[0];
            X2 = splicedVars[1];
            X3 = splicedVars[2];
        }

        public void SetFunctions(double[][] y)
        {
            Y = y;
        }
    }
}