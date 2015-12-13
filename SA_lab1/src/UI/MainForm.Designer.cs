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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnOpenChart = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
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
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMeterageCount)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVar3Dim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVar2Dim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVar1Dim)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVariablePath
            // 
            this.txtVariablePath.Location = new System.Drawing.Point(8, 23);
            this.txtVariablePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(300, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные переменные";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveResult);
            this.groupBox2.Controls.Add(this.txtSaveResult);
            this.groupBox2.Location = new System.Drawing.Point(3, 140);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(492, 107);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сохранить лог в файл";
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Location = new System.Drawing.Point(8, 53);
            this.btnSaveResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(476, 42);
            this.btnSaveResult.TabIndex = 1;
            this.btnSaveResult.Text = "Сохранить";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // txtSaveResult
            // 
            this.txtSaveResult.Location = new System.Drawing.Point(8, 23);
            this.txtSaveResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSaveResult.Name = "txtSaveResult";
            this.txtSaveResult.ReadOnly = true;
            this.txtSaveResult.Size = new System.Drawing.Size(475, 22);
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
            this.groupBox3.Location = new System.Drawing.Point(13, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(757, 526);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Входные данные";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.checkBox2);
            this.groupBox13.Controls.Add(this.checkBox1);
            this.groupBox13.Controls.Add(this.groupBox14);
            this.groupBox13.Location = new System.Drawing.Point(453, 257);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox13.Size = new System.Drawing.Size(287, 206);
            this.groupBox13.TabIndex = 10;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Формируем матрицу B";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(8, 177);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(211, 21);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Мультипликативная форма";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(7, 143);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(262, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Определять лямбда в 3-х системах";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.radioBType3);
            this.groupBox14.Controls.Add(this.radioBType2);
            this.groupBox14.Controls.Add(this.radioBType1);
            this.groupBox14.Location = new System.Drawing.Point(8, 23);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox14.Size = new System.Drawing.Size(271, 105);
            this.groupBox14.TabIndex = 0;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "По";
            // 
            // radioBType3
            // 
            this.radioBType3.AutoSize = true;
            this.radioBType3.Checked = true;
            this.radioBType3.Location = new System.Drawing.Point(8, 80);
            this.radioBType3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBType3.Name = "radioBType3";
            this.radioBType3.Size = new System.Drawing.Size(214, 21);
            this.radioBType3.TabIndex = 5;
            this.radioBType3.TabStop = true;
            this.radioBType3.Text = "Нормированным значениям";
            this.radioBType3.UseVisualStyleBackColor = true;
            // 
            // radioBType2
            // 
            this.radioBType2.AutoSize = true;
            this.radioBType2.Location = new System.Drawing.Point(8, 52);
            this.radioBType2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBType2.Name = "radioBType2";
            this.radioBType2.Size = new System.Drawing.Size(219, 21);
            this.radioBType2.TabIndex = 4;
            this.radioBType2.Text = "Среднему арифметическому";
            this.radioBType2.UseVisualStyleBackColor = true;
            // 
            // radioBType1
            // 
            this.radioBType1.AutoSize = true;
            this.radioBType1.Location = new System.Drawing.Point(8, 23);
            this.radioBType1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBType1.Name = "radioBType1";
            this.radioBType1.Size = new System.Drawing.Size(106, 21);
            this.radioBType1.TabIndex = 3;
            this.radioBType1.Text = "(max+min)/2";
            this.radioBType1.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox12);
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Location = new System.Drawing.Point(16, 257);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox10.Size = new System.Drawing.Size(429, 204);
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
            this.groupBox12.Location = new System.Drawing.Point(19, 33);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox12.Size = new System.Drawing.Size(219, 140);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Степень полинома";
            // 
            // numPolinomPowerX3
            // 
            this.numPolinomPowerX3.Location = new System.Drawing.Point(51, 106);
            this.numPolinomPowerX3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPolinomPowerX3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPolinomPowerX3.Name = "numPolinomPowerX3";
            this.numPolinomPowerX3.Size = new System.Drawing.Size(69, 22);
            this.numPolinomPowerX3.TabIndex = 15;
            this.numPolinomPowerX3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numPolinomPowerX2
            // 
            this.numPolinomPowerX2.Location = new System.Drawing.Point(51, 63);
            this.numPolinomPowerX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPolinomPowerX2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPolinomPowerX2.Name = "numPolinomPowerX2";
            this.numPolinomPowerX2.Size = new System.Drawing.Size(69, 22);
            this.numPolinomPowerX2.TabIndex = 14;
            this.numPolinomPowerX2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numPolinomPowerX1
            // 
            this.numPolinomPowerX1.Location = new System.Drawing.Point(51, 20);
            this.numPolinomPowerX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPolinomPowerX1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPolinomPowerX1.Name = "numPolinomPowerX1";
            this.numPolinomPowerX1.Size = new System.Drawing.Size(69, 22);
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
            this.label6.Location = new System.Drawing.Point(7, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Х3 - ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Х2 - ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Х1 - ";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.radioPolinomHermit);
            this.groupBox11.Controls.Add(this.radioPolinomLagger);
            this.groupBox11.Controls.Add(this.radioPolinomLejandr);
            this.groupBox11.Controls.Add(this.radioPolinomChebyshev);
            this.groupBox11.Location = new System.Drawing.Point(245, 33);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox11.Size = new System.Drawing.Size(167, 140);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Вид полинома";
            // 
            // radioPolinomHermit
            // 
            this.radioPolinomHermit.AutoSize = true;
            this.radioPolinomHermit.Location = new System.Drawing.Point(11, 103);
            this.radioPolinomHermit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPolinomHermit.Name = "radioPolinomHermit";
            this.radioPolinomHermit.Size = new System.Drawing.Size(78, 21);
            this.radioPolinomHermit.TabIndex = 3;
            this.radioPolinomHermit.Text = "Эрмита";
            this.radioPolinomHermit.UseVisualStyleBackColor = true;
            // 
            // radioPolinomLagger
            // 
            this.radioPolinomLagger.AutoSize = true;
            this.radioPolinomLagger.Location = new System.Drawing.Point(11, 76);
            this.radioPolinomLagger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPolinomLagger.Name = "radioPolinomLagger";
            this.radioPolinomLagger.Size = new System.Drawing.Size(84, 21);
            this.radioPolinomLagger.TabIndex = 2;
            this.radioPolinomLagger.Text = "Лагерра";
            this.radioPolinomLagger.UseVisualStyleBackColor = true;
            // 
            // radioPolinomLejandr
            // 
            this.radioPolinomLejandr.AutoSize = true;
            this.radioPolinomLejandr.Location = new System.Drawing.Point(11, 48);
            this.radioPolinomLejandr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPolinomLejandr.Name = "radioPolinomLejandr";
            this.radioPolinomLejandr.Size = new System.Drawing.Size(96, 21);
            this.radioPolinomLejandr.TabIndex = 1;
            this.radioPolinomLejandr.Text = "Лежандра";
            this.radioPolinomLejandr.UseVisualStyleBackColor = true;
            // 
            // radioPolinomChebyshev
            // 
            this.radioPolinomChebyshev.AutoSize = true;
            this.radioPolinomChebyshev.Checked = true;
            this.radioPolinomChebyshev.Location = new System.Drawing.Point(11, 20);
            this.radioPolinomChebyshev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPolinomChebyshev.Name = "radioPolinomChebyshev";
            this.radioPolinomChebyshev.Size = new System.Drawing.Size(99, 21);
            this.radioPolinomChebyshev.TabIndex = 0;
            this.radioPolinomChebyshev.TabStop = true;
            this.radioPolinomChebyshev.Text = "Чебышева";
            this.radioPolinomChebyshev.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(8, 468);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(744, 50);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnShowNormalizeInputInTables
            // 
            this.btnShowNormalizeInputInTables.Location = new System.Drawing.Point(8, 207);
            this.btnShowNormalizeInputInTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowNormalizeInputInTables.Name = "btnShowNormalizeInputInTables";
            this.btnShowNormalizeInputInTables.Size = new System.Drawing.Size(300, 44);
            this.btnShowNormalizeInputInTables.TabIndex = 8;
            this.btnShowNormalizeInputInTables.Text = "Показать в нормализованом виде";
            this.btnShowNormalizeInputInTables.UseVisualStyleBackColor = true;
            this.btnShowNormalizeInputInTables.Click += new System.EventHandler(this.OpenNormalizeInputInTableForm);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(315, 22);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(436, 229);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Настройка входных данных";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox15);
            this.groupBox7.Controls.Add(this.numMeterageCount);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.txtVarCount);
            this.groupBox7.Location = new System.Drawing.Point(5, 21);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(425, 208);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Переменные";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.radioButton2);
            this.groupBox15.Controls.Add(this.radioButton1);
            this.groupBox15.Location = new System.Drawing.Point(213, 85);
            this.groupBox15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox15.Size = new System.Drawing.Size(205, 100);
            this.groupBox15.TabIndex = 7;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Метод решения СНЛАУ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 68);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(162, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Градиентный метод";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 30);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(200, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Метод случайного поиска";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // numMeterageCount
            // 
            this.numMeterageCount.Location = new System.Drawing.Point(460, 60);
            this.numMeterageCount.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.numMeterageCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numMeterageCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMeterageCount.Name = "numMeterageCount";
            this.numMeterageCount.Size = new System.Drawing.Size(69, 22);
            this.numMeterageCount.TabIndex = 6;
            this.numMeterageCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMeterageCount.ValueChanged += new System.EventHandler(this.numMeterageCount_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
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
            this.groupBox9.Location = new System.Drawing.Point(5, 49);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Size = new System.Drawing.Size(203, 151);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Размерность";
            // 
            // numVar3Dim
            // 
            this.numVar3Dim.Location = new System.Drawing.Point(51, 114);
            this.numVar3Dim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numVar3Dim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVar3Dim.Name = "numVar3Dim";
            this.numVar3Dim.Size = new System.Drawing.Size(69, 22);
            this.numVar3Dim.TabIndex = 9;
            this.numVar3Dim.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numVar3Dim.ValueChanged += new System.EventHandler(this.VariableDimensionChanged);
            // 
            // numVar2Dim
            // 
            this.numVar2Dim.Location = new System.Drawing.Point(51, 65);
            this.numVar2Dim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numVar2Dim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVar2Dim.Name = "numVar2Dim";
            this.numVar2Dim.Size = new System.Drawing.Size(69, 22);
            this.numVar2Dim.TabIndex = 8;
            this.numVar2Dim.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numVar2Dim.ValueChanged += new System.EventHandler(this.VariableDimensionChanged);
            // 
            // numVar1Dim
            // 
            this.numVar1Dim.Location = new System.Drawing.Point(51, 22);
            this.numVar1Dim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numVar1Dim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVar1Dim.Name = "numVar1Dim";
            this.numVar1Dim.Size = new System.Drawing.Size(69, 22);
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
            this.label4.Location = new System.Drawing.Point(7, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Х3 - ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Х2 - ";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Общее количество переменных:";
            // 
            // txtVarCount
            // 
            this.txtVarCount.Location = new System.Drawing.Point(241, 21);
            this.txtVarCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVarCount.Name = "txtVarCount";
            this.txtVarCount.ReadOnly = true;
            this.txtVarCount.Size = new System.Drawing.Size(177, 22);
            this.txtVarCount.TabIndex = 1;
            this.txtVarCount.Text = "0";
            // 
            // btnShowInputInTables
            // 
            this.btnShowInputInTables.Location = new System.Drawing.Point(8, 158);
            this.btnShowInputInTables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowInputInTables.Name = "btnShowInputInTables";
            this.btnShowInputInTables.Size = new System.Drawing.Size(300, 44);
            this.btnShowInputInTables.TabIndex = 6;
            this.btnShowInputInTables.Text = "Показать в виде таблиц";
            this.btnShowInputInTables.UseVisualStyleBackColor = true;
            this.btnShowInputInTables.Click += new System.EventHandler(this.OpenInputInTableForm);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFunction1Path);
            this.groupBox4.Location = new System.Drawing.Point(8, 89);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(300, 60);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Значения функции";
            // 
            // txtFunction1Path
            // 
            this.txtFunction1Path.Location = new System.Drawing.Point(8, 23);
            this.txtFunction1Path.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFunction1Path.Name = "txtFunction1Path";
            this.txtFunction1Path.ReadOnly = true;
            this.txtFunction1Path.Size = new System.Drawing.Size(284, 22);
            this.txtFunction1Path.TabIndex = 3;
            this.txtFunction1Path.TextChanged += new System.EventHandler(this.FunctionDataSourceChanged);
            this.txtFunction1Path.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxOpenFileAction);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.btnOpenChart);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Location = new System.Drawing.Point(779, 209);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(508, 247);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Результат";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(492, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Открыть нормированные графики";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpenChart
            // 
            this.btnOpenChart.Location = new System.Drawing.Point(8, 28);
            this.btnOpenChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenChart.Name = "btnOpenChart";
            this.btnOpenChart.Size = new System.Drawing.Size(492, 50);
            this.btnOpenChart.TabIndex = 7;
            this.btnOpenChart.Text = "Открыть восстановленные графики";
            this.btnOpenChart.UseVisualStyleBackColor = true;
            this.btnOpenChart.Click += new System.EventHandler(this.btnOpenChart_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtLog);
            this.groupBox8.Location = new System.Drawing.Point(13, 546);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Size = new System.Drawing.Size(1273, 198);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Промежуточные результаты";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(4, 19);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(1265, 175);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.label16);
            this.groupBox16.Controls.Add(this.label15);
            this.groupBox16.Controls.Add(this.label14);
            this.groupBox16.Controls.Add(this.label13);
            this.groupBox16.Controls.Add(this.label12);
            this.groupBox16.Controls.Add(this.label11);
            this.groupBox16.Controls.Add(this.label10);
            this.groupBox16.Controls.Add(this.label9);
            this.groupBox16.Location = new System.Drawing.Point(779, 17);
            this.groupBox16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox16.Size = new System.Drawing.Size(508, 175);
            this.groupBox16.TabIndex = 8;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Над программой работали:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(196, 69);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 17);
            this.label16.TabIndex = 7;
            this.label16.Text = "студент группы КА-23";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(196, 130);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "студентка группы КА-24";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(196, 102);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "студент группы КА-24";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(196, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "студент группы КА-23";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 69);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Никитин Андрей";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 130);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Евграфова Ксения";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Венжик Андрей";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Белас Андрей";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(779, 481);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(507, 22);
            this.txtStatus.TabIndex = 9;
            this.txtStatus.Text = "Ожидаем ввода перемнных";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(779, 460);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 17);
            this.label17.TabIndex = 10;
            this.label17.Text = "Статус";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 780);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
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
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
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
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

