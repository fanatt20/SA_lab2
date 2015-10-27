namespace UI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtVariablePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numMeterageCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVar3Dim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVar2Dim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVar1Dim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVarCount = new System.Windows.Forms.TextBox();
            this.btnShowInputInTables = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFunction3Path = new System.Windows.Forms.TextBox();
            this.txtFunction2Path = new System.Windows.Forms.TextBox();
            this.txtFunction1Path = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMeterageCount)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVariablePath
            // 
            this.txtVariablePath.Location = new System.Drawing.Point(8, 23);
            this.txtVariablePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtVariablePath.Name = "txtVariablePath";
            this.txtVariablePath.ReadOnly = true;
            this.txtVariablePath.Size = new System.Drawing.Size(283, 22);
            this.txtVariablePath.TabIndex = 0;
            this.txtVariablePath.TextChanged += new System.EventHandler(this.VariableDataSourceChanged);
            this.txtVariablePath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxOpenFileAction);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVariablePath);
            this.groupBox1.Location = new System.Drawing.Point(8, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(300, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные переменные";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Location = new System.Drawing.Point(13, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(303, 213);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сохранить в файл";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(8, 39);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(283, 22);
            this.textBox5.TabIndex = 0;
            this.textBox5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxSaveFileAction);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.btnShowInputInTables);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(750, 357);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Входные данные";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(315, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(427, 328);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Настройка входных данных";
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(6, 222);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(415, 100);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Функции";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.numMeterageCount);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.txtVarCount);
            this.groupBox7.Location = new System.Drawing.Point(6, 21);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(415, 193);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Переменные";
            // 
            // numMeterageCount
            // 
            this.numMeterageCount.Location = new System.Drawing.Point(340, 51);
            this.numMeterageCount.Name = "numMeterageCount";
            this.numMeterageCount.Size = new System.Drawing.Size(69, 22);
            this.numMeterageCount.TabIndex = 6;
            this.numMeterageCount.ValueChanged += new System.EventHandler(this.numMeterageCount_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Размер выборки: ";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Controls.Add(this.txtVar3Dim);
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Controls.Add(this.txtVar2Dim);
            this.groupBox9.Controls.Add(this.label2);
            this.groupBox9.Controls.Add(this.txtVar1Dim);
            this.groupBox9.Location = new System.Drawing.Point(6, 49);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(203, 138);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Размерность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Х3 - ";
            // 
            // txtVar3Dim
            // 
            this.txtVar3Dim.Location = new System.Drawing.Point(51, 75);
            this.txtVar3Dim.Name = "txtVar3Dim";
            this.txtVar3Dim.ReadOnly = true;
            this.txtVar3Dim.Size = new System.Drawing.Size(100, 22);
            this.txtVar3Dim.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Х2 - ";
            // 
            // txtVar2Dim
            // 
            this.txtVar2Dim.Location = new System.Drawing.Point(51, 47);
            this.txtVar2Dim.Name = "txtVar2Dim";
            this.txtVar2Dim.ReadOnly = true;
            this.txtVar2Dim.Size = new System.Drawing.Size(100, 22);
            this.txtVar2Dim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Х1 - ";
            // 
            // txtVar1Dim
            // 
            this.txtVar1Dim.Location = new System.Drawing.Point(51, 19);
            this.txtVar1Dim.Name = "txtVar1Dim";
            this.txtVar1Dim.ReadOnly = true;
            this.txtVar1Dim.Size = new System.Drawing.Size(100, 22);
            this.txtVar1Dim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Общее количество переменных:";
            // 
            // txtVarCount
            // 
            this.txtVarCount.Location = new System.Drawing.Point(231, 21);
            this.txtVarCount.Name = "txtVarCount";
            this.txtVarCount.ReadOnly = true;
            this.txtVarCount.Size = new System.Drawing.Size(178, 22);
            this.txtVarCount.TabIndex = 1;
            // 
            // btnShowInputInTables
            // 
            this.btnShowInputInTables.Location = new System.Drawing.Point(8, 290);
            this.btnShowInputInTables.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowInputInTables.Name = "btnShowInputInTables";
            this.btnShowInputInTables.Size = new System.Drawing.Size(300, 44);
            this.btnShowInputInTables.TabIndex = 6;
            this.btnShowInputInTables.Text = "Показать в виде таблиц";
            this.btnShowInputInTables.UseVisualStyleBackColor = true;
            this.btnShowInputInTables.Click += new System.EventHandler(this.OpenInputInTableForm);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFunction3Path);
            this.groupBox4.Controls.Add(this.txtFunction2Path);
            this.groupBox4.Controls.Add(this.txtFunction1Path);
            this.groupBox4.Location = new System.Drawing.Point(8, 128);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(300, 116);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Значения функции";
            // 
            // txtFunction3Path
            // 
            this.txtFunction3Path.Location = new System.Drawing.Point(8, 86);
            this.txtFunction3Path.Margin = new System.Windows.Forms.Padding(4);
            this.txtFunction3Path.Name = "txtFunction3Path";
            this.txtFunction3Path.ReadOnly = true;
            this.txtFunction3Path.Size = new System.Drawing.Size(284, 22);
            this.txtFunction3Path.TabIndex = 5;
            this.txtFunction3Path.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxOpenFileAction);
            // 
            // txtFunction2Path
            // 
            this.txtFunction2Path.Location = new System.Drawing.Point(8, 56);
            this.txtFunction2Path.Margin = new System.Windows.Forms.Padding(4);
            this.txtFunction2Path.Name = "txtFunction2Path";
            this.txtFunction2Path.ReadOnly = true;
            this.txtFunction2Path.Size = new System.Drawing.Size(284, 22);
            this.txtFunction2Path.TabIndex = 4;
            this.txtFunction2Path.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxOpenFileAction);
            // 
            // txtFunction1Path
            // 
            this.txtFunction1Path.Location = new System.Drawing.Point(8, 23);
            this.txtFunction1Path.Margin = new System.Windows.Forms.Padding(4);
            this.txtFunction1Path.Name = "txtFunction1Path";
            this.txtFunction1Path.ReadOnly = true;
            this.txtFunction1Path.Size = new System.Drawing.Size(284, 22);
            this.txtFunction1Path.TabIndex = 3;
            this.txtFunction1Path.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxOpenFileAction);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chart1);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Location = new System.Drawing.Point(16, 436);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(747, 244);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Результат";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(323, 22);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(417, 214);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Вычислить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 693);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "System Analizys";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMeterageCount)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtVariablePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnShowInputInTables;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtFunction1Path;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtFunction3Path;
        private System.Windows.Forms.TextBox txtFunction2Path;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVar3Dim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVar2Dim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVar1Dim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVarCount;
        private System.Windows.Forms.NumericUpDown numMeterageCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

