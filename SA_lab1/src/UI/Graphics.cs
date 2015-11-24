using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Algorithms.Extensions;

namespace UI
{
    public partial class Graphics : Form
    {
        private readonly double[][] _firstPlot;
        private readonly int _meterageCount;
        private readonly double[][] _secondPlot;

        public Graphics(int meterageCount, double[][] firstPlot, double[][] secondPlot)
        {
            _firstPlot = firstPlot.DeepCopy();
            _secondPlot = secondPlot.DeepCopy();
           
           _meterageCount = meterageCount;

            InitializeComponent();
            for (int i = 0; i <  _secondPlot.Length; i++)
            {
                listBox1.Items.Add("Функция " + (i+1).ToString());
            }
            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
                DrawPlot(0);
            }
        }


        private int SelectedFunction
        {
            get { return listBox1.SelectedIndex; }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DrawPlot(SelectedFunction);
        }

        private void DrawPlot(int index)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            var selectedfunc = SelectedFunction;
            for (var i = 0; i < _meterageCount; i++)
            {
                chart1.Series[0].Points.AddXY(i, _firstPlot[selectedfunc][i]);
                chart1.Series[1].Points.AddXY(i, _secondPlot[selectedfunc][i]);
            }
        }
    }
}