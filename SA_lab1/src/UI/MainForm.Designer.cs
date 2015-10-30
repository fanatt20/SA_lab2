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
            this.txtVariablePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.txtSaveResult = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.radioBType3 = new System.Windows.Forms.RadioButton();
            this.radioBType2 = new System.Windows.Forms.RadioButton();
            this.radioBType1 = new System.Windows.Forms.RadioButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.numPolinomPowerX3 = new System.Windows.Forms.NumericUpDown();
            this.numPolinomPowerX2 = new System.Windows.Forms.NumericUpDown();
            this.numPolinomPowerX1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.radioPolinomHermit = new System.Windows.Forms.RadioButton();
            this.radioPolinomLagger = new System.Windows.Forms.RadioButton();
            this.radioPolinomLejandr = new System.Windows.Forms.RadioButton();
            this.radioPolinomChebyshev = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnShowNormalizeInputInTables = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numMeterageCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.numVar3Dim = new System.Windows.Forms.NumericUpDown();
            this.numVar2Dim = new System.Windows.Forms.NumericUpDown();
            this.numVar1Dim = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVarCount = new System.Windows.Forms.TextBox();
            this.btnShowInputInTables = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFunction1Path = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnOpenChart = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPolinomPowerX3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPolinomPowerX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPolinomPowerX1)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMeterageCount)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVar3Dim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVar2Dim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVar1Dim)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVariablePath
            // 
            this.txtVariablePath.Location = new System.Drawing.Point(6, 19);
            this.txtVariablePath.Name = "txtVariablePath";
            this.txtVariablePath.ReadOnly = true;
            this.txtVariablePath.Size = new System.Drawing.Size(213, 20);
            this.txtVariablePath.TabIndex = 0;
            this.txtVariablePath.TextChanged += new System.EventHandler(this.VariableDataSourceChanged);
            this.txtVariablePath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxOpenFileAction);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVariablePath);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 46);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные переменные";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveResult);
            this.groupBox2.Controls.Add(this.txtSaveResult);
            this.groupBox2.Location = new System.Drawing.Point(6, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 87);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сохранить в файл";
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Location = new System.Drawing.Point(6, 43);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(357, 34);
            this.btnSaveResult.TabIndex = 1;
            this.btnSaveResult.Text = "Сохранить";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // txtSaveResult
            // 
            this.txtSaveResult.Location = new System.Drawing.Point(6, 19);
            this.txtSaveResult.Name = "txtSaveResult";
            this.txtSaveResult.ReadOnly = true;
            this.txtSaveResult.Size = new System.Drawing.Size(357, 20);
            this.txtSaveResult.TabIndex = 0;
            this.txtSaveResult.Text = "log.txt";
            this.txtSaveResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxSaveFileAction);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox13);
            this.groupBox3.Controls.Add(this.groupBox10);
            this.groupBox3.Controls.Add(this.btnCalculate);
            this.groupBox3.Controls.Add(this.btnShowNormalizeInputInTables);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.btnShowInputInTables);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(10, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(568, 497);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Входные данные";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.groupBox14);
            this.groupBox13.Location = new System.Drawing.Point(340, 209);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(215, 139);
            this.groupBox13.TabIndex = 10;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Формируем матрицу Б";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.radioBType3);
            this.groupBox14.Controls.Add(this.radioBType2);
            this.groupBox14.Controls.Add(this.radioBType1);
            this.groupBox14.Location = new System.Drawing.Point(6, 19);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(203, 114);
            this.groupBox14.TabIndex = 0;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "По";
            // 
            // radioBType3
            // 
            this.radioBType3.AutoSize = true;
            this.radioBType3.Location = new System.Drawing.Point(6, 65);
            this.radioBType3.Name = "radioBType3";
            this.radioBType3.Size = new System.Drawing.Size(103, 17);
            this.radioBType3.TabIndex = 5;
            this.radioBType3.Text = "Нормированию";
            this.radioBType3.UseVisualStyleBackColor = true;
            // 
            // radioBType2
            // 
            this.radioBType2.AutoSize = true;
            this.radioBType2.Location = new System.Drawing.Point(6, 42);
            this.radioBType2.Name = "radioBType2";
            this.radioBType2.Size = new System.Drawing.Size(171, 17);
            this.radioBType2.TabIndex = 4;
            this.radioBType2.Text = "Среднему арифметическому";
            this.radioBType2.UseVisualStyleBackColor = true;
            // 
            // radioBType1
            // 
            this.radioBType1.AutoSize = true;
            this.radioBType1.Checked = true;
            this.radioBType1.Location = new System.Drawing.Point(6, 19);
            this.radioBType1.Name = "radioBType1";
            this.radioBType1.Size = new System.Drawing.Size(83, 17);
            this.radioBType1.TabIndex = 3;
            this.radioBType1.TabStop = true;
            this.radioBType1.Text = "(max+min)/2";
            this.radioBType1.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox12);
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Location = new System.Drawing.Point(12, 209);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(322, 139);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Полиномы";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.numPolinomPowerX3);
            this.groupBox12.Controls.Add(this.numPolinomPowerX2);
            this.groupBox12.Controls.Add(this.numPolinomPowerX1);
            this.groupBox12.Controls.Add(this.label6);
            this.groupBox12.Controls.Add(this.label7);
            this.groupBox12.Controls.Add(this.label8);
            this.groupBox12.Location = new System.Drawing.Point(6, 19);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(164, 114);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Степень полинома";
            // 
            // numPolinomPowerX3
            // 
            this.numPolinomPowerX3.Location = new System.Drawing.Point(38, 86);
            this.numPolinomPowerX3.Margin = new System.Windows.Forms.Padding(2);
            this.numPolinomPowerX3.Name = "numPolinomPowerX3";
            this.numPolinomPowerX3.Size = new System.Drawing.Size(52, 20);
            this.numPolinomPowerX3.TabIndex = 15;
            this.numPolinomPowerX3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numPolinomPowerX2
            // 
            this.numPolinomPowerX2.Location = new System.Drawing.Point(38, 51);
            this.numPolinomPowerX2.Margin = new System.Windows.Forms.Padding(2);
            this.numPolinomPowerX2.Name = "numPolinomPowerX2";
            this.numPolinomPowerX2.Size = new System.Drawing.Size(52, 20);
            this.numPolinomPowerX2.TabIndex = 14;
            this.numPolinomPowerX2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numPolinomPowerX1
            // 
            this.numPolinomPowerX1.Location = new System.Drawing.Point(38, 16);
            this.numPolinomPowerX1.Margin = new System.Windows.Forms.Padding(2);
            this.numPolinomPowerX1.Name = "numPolinomPowerX1";
            this.numPolinomPowerX1.Size = new System.Drawing.Size(52, 20);
            this.numPolinomPowerX1.TabIndex = 13;
            this.numPolinomPowerX1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Х3 - ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Х2 - ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Х1 - ";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.radioPolinomHermit);
            this.groupBox11.Controls.Add(this.radioPolinomLagger);
            this.groupBox11.Controls.Add(this.radioPolinomLejandr);
            this.groupBox11.Controls.Add(this.radioPolinomChebyshev);
            this.groupBox11.Location = new System.Drawing.Point(176, 19);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(125, 114);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Вид полинома";
            // 
            // radioPolinomHermit
            // 
            this.radioPolinomHermit.AutoSize = true;
            this.radioPolinomHermit.Location = new System.Drawing.Point(8, 84);
            this.radioPolinomHermit.Name = "radioPolinomHermit";
            this.radioPolinomHermit.Size = new System.Drawing.Size(63, 17);
            this.radioPolinomHermit.TabIndex = 3;
            this.radioPolinomHermit.Text = "Эрмита";
            this.radioPolinomHermit.UseVisualStyleBackColor = true;
            // 
            // radioPolinomLagger
            // 
            this.radioPolinomLagger.AutoSize = true;
            this.radioPolinomLagger.Location = new System.Drawing.Point(8, 62);
            this.radioPolinomLagger.Name = "radioPolinomLagger";
            this.radioPolinomLagger.Size = new System.Drawing.Size(67, 17);
            this.radioPolinomLagger.TabIndex = 2;
            this.radioPolinomLagger.Text = "Лаггера";
            this.radioPolinomLagger.UseVisualStyleBackColor = true;
            // 
            // radioPolinomLejandr
            // 
            this.radioPolinomLejandr.AutoSize = true;
            this.radioPolinomLejandr.Location = new System.Drawing.Point(8, 39);
            this.radioPolinomLejandr.Name = "radioPolinomLejandr";
            this.radioPolinomLejandr.Size = new System.Drawing.Size(77, 17);
            this.radioPolinomLejandr.TabIndex = 1;
            this.radioPolinomLejandr.Text = "Лежандра";
            this.radioPolinomLejandr.UseVisualStyleBackColor = true;
            // 
            // radioPolinomChebyshev
            // 
            this.radioPolinomChebyshev.AutoSize = true;
            this.radioPolinomChebyshev.Checked = true;
            this.radioPolinomChebyshev.Location = new System.Drawing.Point(8, 16);
            this.radioPolinomChebyshev.Name = "radioPolinomChebyshev";
            this.radioPolinomChebyshev.Size = new System.Drawing.Size(79, 17);
            this.radioPolinomChebyshev.TabIndex = 0;
            this.radioPolinomChebyshev.TabStop = true;
            this.radioPolinomChebyshev.Text = "Чебышева";
            this.radioPolinomChebyshev.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(5, 457);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(558, 41);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnShowNormalizeInputInTables
            // 
            this.btnShowNormalizeInputInTables.Location = new System.Drawing.Point(6, 168);
            this.btnShowNormalizeInputInTables.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowNormalizeInputInTables.Name = "btnShowNormalizeInputInTables";
            this.btnShowNormalizeInputInTables.Size = new System.Drawing.Size(225, 36);
            this.btnShowNormalizeInputInTables.TabIndex = 8;
            this.btnShowNormalizeInputInTables.Text = "Показать в нормированом виде";
            this.btnShowNormalizeInputInTables.UseVisualStyleBackColor = true;
            this.btnShowNormalizeInputInTables.Click += new System.EventHandler(this.OpenNormalizeInputInTableForm);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(236, 18);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(327, 186);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Настройка входных данных";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.numMeterageCount);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.txtVarCount);
            this.groupBox7.Location = new System.Drawing.Point(4, 17);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(319, 169);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Переменные";
            // 
            // numMeterageCount
            // 
            this.numMeterageCount.Location = new System.Drawing.Point(263, 90);
            this.numMeterageCount.Margin = new System.Windows.Forms.Padding(2);
            this.numMeterageCount.Name = "numMeterageCount";
            this.numMeterageCount.Size = new System.Drawing.Size(52, 20);
            this.numMeterageCount.TabIndex = 6;
            this.numMeterageCount.ValueChanged += new System.EventHandler(this.numMeterageCount_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Размер выборки: ";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.numVar3Dim);
            this.groupBox9.Controls.Add(this.numVar2Dim);
            this.groupBox9.Controls.Add(this.numVar1Dim);
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Controls.Add(this.label2);
            this.groupBox9.Location = new System.Drawing.Point(4, 40);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox9.Size = new System.Drawing.Size(152, 123);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Размерность";
            // 
            // numVar3Dim
            // 
            this.numVar3Dim.Location = new System.Drawing.Point(38, 93);
            this.numVar3Dim.Margin = new System.Windows.Forms.Padding(2);
            this.numVar3Dim.Name = "numVar3Dim";
            this.numVar3Dim.Size = new System.Drawing.Size(52, 20);
            this.numVar3Dim.TabIndex = 9;
            this.numVar3Dim.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numVar3Dim.ValueChanged += new System.EventHandler(this.VariableDimensionChanged);
            // 
            // numVar2Dim
            // 
            this.numVar2Dim.Location = new System.Drawing.Point(38, 53);
            this.numVar2Dim.Margin = new System.Windows.Forms.Padding(2);
            this.numVar2Dim.Name = "numVar2Dim";
            this.numVar2Dim.Size = new System.Drawing.Size(52, 20);
            this.numVar2Dim.TabIndex = 8;
            this.numVar2Dim.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVar2Dim.ValueChanged += new System.EventHandler(this.VariableDimensionChanged);
            // 
            // numVar1Dim
            // 
            this.numVar1Dim.Location = new System.Drawing.Point(38, 18);
            this.numVar1Dim.Margin = new System.Windows.Forms.Padding(2);
            this.numVar1Dim.Name = "numVar1Dim";
            this.numVar1Dim.Size = new System.Drawing.Size(52, 20);
            this.numVar1Dim.TabIndex = 7;
            this.numVar1Dim.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numVar1Dim.ValueChanged += new System.EventHandler(this.VariableDimensionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Х3 - ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Х2 - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Х1 - ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Общее количество переменных:";
            // 
            // txtVarCount
            // 
            this.txtVarCount.Location = new System.Drawing.Point(181, 17);
            this.txtVarCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtVarCount.Name = "txtVarCount";
            this.txtVarCount.ReadOnly = true;
            this.txtVarCount.Size = new System.Drawing.Size(134, 20);
            this.txtVarCount.TabIndex = 1;
            this.txtVarCount.Text = "0";
            // 
            // btnShowInputInTables
            // 
            this.btnShowInputInTables.Location = new System.Drawing.Point(6, 128);
            this.btnShowInputInTables.Name = "btnShowInputInTables";
            this.btnShowInputInTables.Size = new System.Drawing.Size(225, 36);
            this.btnShowInputInTables.TabIndex = 6;
            this.btnShowInputInTables.Text = "Показать в виде таблиц";
            this.btnShowInputInTables.UseVisualStyleBackColor = true;
            this.btnShowInputInTables.Click += new System.EventHandler(this.OpenInputInTableForm);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFunction1Path);
            this.groupBox4.Location = new System.Drawing.Point(6, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 49);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Значения функции";
            // 
            // txtFunction1Path
            // 
            this.txtFunction1Path.Location = new System.Drawing.Point(6, 19);
            this.txtFunction1Path.Name = "txtFunction1Path";
            this.txtFunction1Path.ReadOnly = true;
            this.txtFunction1Path.Size = new System.Drawing.Size(214, 20);
            this.txtFunction1Path.TabIndex = 3;
            this.txtFunction1Path.TextChanged += new System.EventHandler(this.FunctionDataSourceChanged);
            this.txtFunction1Path.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxOpenFileAction);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnOpenChart);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Location = new System.Drawing.Point(584, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(381, 497);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Результат";
            // 
            // btnOpenChart
            // 
            this.btnOpenChart.Location = new System.Drawing.Point(6, 357);
            this.btnOpenChart.Name = "btnOpenChart";
            this.btnOpenChart.Size = new System.Drawing.Size(369, 41);
            this.btnOpenChart.TabIndex = 7;
            this.btnOpenChart.Text = "Открыть графики";
            this.btnOpenChart.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtLog);
            this.groupBox8.Location = new System.Drawing.Point(6, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(369, 332);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Лог";
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 16);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(363, 313);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 520);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "System Analizys";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPolinomPowerX3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPolinomPowerX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPolinomPowerX1)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMeterageCount)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVar3Dim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVar2Dim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVar1Dim)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtVariablePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.TextBox txtSaveResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnShowInputInTables;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtFunction1Path;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVarCount;
        private System.Windows.Forms.NumericUpDown numMeterageCount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnShowNormalizeInputInTables;
        private System.Windows.Forms.Button btnOpenChart;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.NumericUpDown numVar3Dim;
        private System.Windows.Forms.NumericUpDown numVar2Dim;
        private System.Windows.Forms.NumericUpDown numVar1Dim;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.NumericUpDown numPolinomPowerX3;
        private System.Windows.Forms.NumericUpDown numPolinomPowerX2;
        private System.Windows.Forms.NumericUpDown numPolinomPowerX1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioPolinomHermit;
        private System.Windows.Forms.RadioButton radioPolinomLagger;
        private System.Windows.Forms.RadioButton radioPolinomLejandr;
        private System.Windows.Forms.RadioButton radioPolinomChebyshev;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.RadioButton radioBType3;
        private System.Windows.Forms.RadioButton radioBType2;
        private System.Windows.Forms.RadioButton radioBType1;
    }
}

