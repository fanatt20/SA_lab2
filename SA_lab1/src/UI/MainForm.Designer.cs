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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFunctionPath = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnShowInputInTables = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVariablePath
            // 
            this.txtVariablePath.Location = new System.Drawing.Point(6, 19);
            this.txtVariablePath.Name = "txtVariablePath";
            this.txtVariablePath.ReadOnly = true;
            this.txtVariablePath.Size = new System.Drawing.Size(213, 20);
            this.txtVariablePath.TabIndex = 0;
            this.txtVariablePath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxOpenFileAction);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVariablePath);
            this.groupBox1.Location = new System.Drawing.Point(262, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 46);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные переменные";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Location = new System.Drawing.Point(256, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 135);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сохранить в файл";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(213, 20);
            this.textBox5.TabIndex = 0;
            this.textBox5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxSaveFileAction);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowInputInTables);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 177);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Входные данные";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFunctionPath);
            this.groupBox4.Location = new System.Drawing.Point(262, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 52);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Значения функции";
            // 
            // txtFunctionPath
            // 
            this.txtFunctionPath.Location = new System.Drawing.Point(6, 19);
            this.txtFunctionPath.Name = "txtFunctionPath";
            this.txtFunctionPath.ReadOnly = true;
            this.txtFunctionPath.Size = new System.Drawing.Size(213, 20);
            this.txtFunctionPath.TabIndex = 3;
            this.txtFunctionPath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxOpenFileAction);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Location = new System.Drawing.Point(18, 195);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(487, 168);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Результат";
            // 
            // btnShowInputInTables
            // 
            this.btnShowInputInTables.Location = new System.Drawing.Point(262, 129);
            this.btnShowInputInTables.Name = "btnShowInputInTables";
            this.btnShowInputInTables.Size = new System.Drawing.Size(225, 36);
            this.btnShowInputInTables.TabIndex = 6;
            this.btnShowInputInTables.Text = "Показать в виде таблиц";
            this.btnShowInputInTables.UseVisualStyleBackColor = true;
            this.btnShowInputInTables.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 370);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtFunctionPath;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

