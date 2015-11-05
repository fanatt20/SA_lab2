using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Algorithms.Extensions;

namespace UI
{
    public partial class Graphics : Form
    {
        private readonly double[][] _firstPlot;
        private readonly List<RadioButton> _functionSelector;
        private readonly int _meterageCount;
        private readonly double[][] _secondPlot;

        public Graphics(int meterageCount, double[][] firstPlot, double[][] secondPlot)
        {
            _firstPlot = firstPlot.DeepCopy();
            _secondPlot = secondPlot.DeepCopy();
            _meterageCount = meterageCount;

            InitializeComponent();
            _functionSelector = new List<RadioButton> {radioButton1, radioButton2, radioButton3};

            DrawPlot(0);
        }


        private int _selectedFunction
        {
            get { return _functionSelector.FindIndex(button => button.Checked); }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DrawPlot(_selectedFunction);
        }

        private void DrawPlot(int index)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            var selectedfunc = _selectedFunction;
            for (var i = 0; i < _meterageCount; i++)
            {
                chart1.Series[0].Points.AddXY(i, _firstPlot[selectedfunc][i]);
                chart1.Series[1].Points.AddXY(i, _secondPlot[selectedfunc][i]);
            }
        }
    }
}