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
            this.btnShowInputInTables = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFunction3Path = new System.Windows.Forms.TextBox();
            this.txtFunction2Path = new System.Windows.Forms.TextBox();
            this.txtFunction1Path = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(341, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(300, 166);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сохранить в файл";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 91);
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
            this.groupBox3.Controls.Add(this.btnShowInputInTables);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(16, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(657, 218);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Входные данные";
            // 
            // btnShowInputInTables
            // 
            this.btnShowInputInTables.Location = new System.Drawing.Point(340, 159);
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
            this.groupBox4.Location = new System.Drawing.Point(340, 23);
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
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Location = new System.Drawing.Point(24, 240);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(649, 207);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Результат";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 455);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
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
        private System.Windows.Forms.TextBox txtFunction1Path;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtFunction3Path;
        private System.Windows.Forms.TextBox txtFunction2Path;
    }
}

