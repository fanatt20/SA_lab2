namespace UI
{
    partial class InputDataInTables
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridViewVariables = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridViewFunctions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVariables)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFunctions)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewVariables
            // 
            this.gridViewVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewVariables.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridViewVariables.Location = new System.Drawing.Point(3, 16);
            this.gridViewVariables.Name = "gridViewVariables";
            this.gridViewVariables.Size = new System.Drawing.Size(556, 406);
            this.gridViewVariables.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.gridViewVariables);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 425);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Переменные";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.gridViewFunctions);
            this.groupBox2.Location = new System.Drawing.Point(577, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 425);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Функции";
            // 
            // gridViewFunctions
            // 
            this.gridViewFunctions.AllowUserToAddRows = false;
            this.gridViewFunctions.AllowUserToDeleteRows = false;
            this.gridViewFunctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewFunctions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridViewFunctions.Location = new System.Drawing.Point(3, 16);
            this.gridViewFunctions.Name = "gridViewFunctions";
            this.gridViewFunctions.ReadOnly = true;
            this.gridViewFunctions.Size = new System.Drawing.Size(327, 406);
            this.gridViewFunctions.TabIndex = 0;
            // 
            // InputDataInTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 449);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InputDataInTables";
            this.Text = "InputDataInTables";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVariables)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFunctions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewVariables;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridViewFunctions;
    }
}