using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Algorithms.Extensions;
using UI.DataHolder;

namespace UI
{
    public partial class InputDataInTables : Form
    {
        public InputDataInTables(IDataHolder dataHolder, bool asX1X2X3)
        {
            InitializeComponent();
            if (!asX1X2X3)
            {
                var varNamelst = new List<string>();
                for (var i = 0; i < dataHolder.AllVariables.Length; i++)
                {
                    varNamelst.Add("Переменная " + (i + 1));
                }
                gridViewVariables.DataSource = dataHolder.AllVariables.GetDataTableFromMatrix(varNamelst.ToArray());
            }
            else
            {
                var varNamelst = new List<string>();
                for (var i = 0; i < dataHolder.AllVariables.Length; i++)
                {
                    varNamelst.Add("Переменная " + (i + 1));
                }
                for (int i = 0; i < dataHolder.X1.Length; i++)
                {
                    gridViewVariables.Columns.Add(("X1 " + (i + 1)), (i + 1).ToString());
                }
                for (int i = 0; i < dataHolder.X2.Length; i++)
                {
                    gridViewVariables.Columns.Add(("X2 " + (i + 1)), (i+1).ToString());
                }
                for (int i = 0; i < dataHolder.X3.Length; i++)
                {
                    gridViewVariables.Columns.Add(("X3 " + (i + 1)), (i + 1).ToString());
                }




            }
            var funcNamelst = new List<string>();
            for (var i = 0; i < dataHolder.Y.Length; i++)
            {
                funcNamelst.Add("Функция " + (i + 1));
            }
            gridViewFunctions.DataSource =
                dataHolder.Y.GetDataTableFromMatrix(funcNamelst.ToArray());
        }

        public InputDataInTables(double[][] MatrixA, string[] nameForVariableOfMatrix1, double[][] matrixB,
            string[] nameForVariableOfMatrix2)
        {
            InitializeComponent();

            gridViewVariables.DataSource = MatrixA
                .GetDataTableFromMatrix(nameForVariableOfMatrix1);
            gridViewFunctions.DataSource =
                matrixB.GetDataTableFromMatrix(nameForVariableOfMatrix2);
        }

        private void DgvColumnHeaderMerge_Load(object sender, EventArgs e)

        {
            this.gridViewVariables.Columns.Add("X11", "Win");

            this.gridViewVariables.Columns.Add("JanLoss", "Loss");

            this.gridViewVariables.Columns.Add("FebWin", "Win");

            this.gridViewVariables.Columns.Add("FebLoss", "Loss");

            this.gridViewVariables.Columns.Add("MarWin", "Win");

            this.gridViewVariables.Columns.Add("MarLoss", "Loss");


            for (var j = 0; j < this.gridViewVariables.ColumnCount; j++)

            {
                this.gridViewVariables.Columns[j].Width = 45;
            }

            this.gridViewVariables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            this.gridViewVariables.ColumnHeadersHeight = this.gridViewVariables.ColumnHeadersHeight*2;

            this.gridViewVariables.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            this.gridViewVariables.CellPainting += new DataGridViewCellPaintingEventHandler(dataGridView1_CellPainting);

            this.gridViewVariables.Paint += new PaintEventHandler(dataGridView1_Paint);
        }


        private void dataGridView1_Paint(object sender, PaintEventArgs e)

        {
            string[] monthes = {"January", "February", "March"};

            for (var j = 0; j < 6;)

            {
                Rectangle r1 = this.gridViewVariables.GetCellDisplayRectangle(j, -1, true); //get the column header cell
                r1.X += 1;
                r1.Y += 1;
                r1.Width = r1.Width*2 - 2;
                r1.Height = r1.Height/2 - 2;

                e.Graphics.FillRectangle(new SolidBrush(this.gridViewVariables.ColumnHeadersDefaultCellStyle.BackColor), r1);

                StringFormat format = new StringFormat();

                format.Alignment = StringAlignment.Center;

                format.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawString(monthes[j/2],
                    this.gridViewVariables.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(this.gridViewVariables.ColumnHeadersDefaultCellStyle.ForeColor),
                    r1,
                    format);

                j += 2;
            }
        }


        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)

        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)

            {
                e.PaintBackground(e.CellBounds, false);


                Rectangle r2 = e.CellBounds;

                r2.Y += e.CellBounds.Height/2;

                r2.Height = e.CellBounds.Height/2;

                e.PaintContent(r2);

                e.Handled = true;
            }
        }
    }
}