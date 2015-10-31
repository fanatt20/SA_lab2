using Algorithms.Extensions;

namespace UI.DataHolder
{
    internal class NormalizedDataHolder : IDataHolder
    {
        private double[][] _variables;
        private double[][] _x1;
        private double[][] _x2;
        private double[][] _x3;
        private double[][] _y;
        internal int MeterageCount = -1;

        public double[][] AllVariables
        {
            get
            {
                return _variables == null
                    ? null
                    : _variables.TakeBySecondCoordinate(MeterageCount > 0 ? MeterageCount : _variables[0].Length);
            }
            set { _variables = value.DeepCopy(); }
        }

        public double[][] X1
        {
            get
            {
                return _x1 == null ? null : _x1.TakeBySecondCoordinate(MeterageCount > 0 ? MeterageCount : _x1[0].Length);
            }
            internal set { _x1 = value.DeepCopy(); }
        }

        public double[][] X2
        {
            get
            {
                return _x2 == null ? null : _x2.TakeBySecondCoordinate(MeterageCount > 0 ? MeterageCount : _x2[0].Length);
            }
            internal set { _x2 = value.DeepCopy(); }
        }

        public double[][] X3
        {
            get
            {
                return _x3 == null ? null : _x3.TakeBySecondCoordinate(MeterageCount > 0 ? MeterageCount : _x3[0].Length);
            }
            internal set { _x3 = value.DeepCopy(); }
        }

        public double[][] Y
        {
            get
            {
                return _y == null ? null : _y.TakeBySecondCoordinate(MeterageCount > 0 ? MeterageCount : _y[0].Length);
            }
            internal set { _y = value.DeepCopy(); }
        }
    }
}