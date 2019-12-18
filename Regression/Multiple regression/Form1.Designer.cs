namespace Multiple_regression
{
    partial class Form1
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
            this.PlanMatrix = new System.Windows.Forms.DataGridView();
            this.X0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textB0 = new System.Windows.Forms.TextBox();
            this.textB1 = new System.Windows.Forms.TextBox();
            this.textB3 = new System.Windows.Forms.TextBox();
            this.textB2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textG = new System.Windows.Forms.TextBox();
            this.S2reproduced = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Equation = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Fcalc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlanMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // PlanMatrix
            // 
            this.PlanMatrix.AllowUserToAddRows = false;
            this.PlanMatrix.AllowUserToDeleteRows = false;
            this.PlanMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlanMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X0,
            this.X1,
            this.X2,
            this.X3,
            this.Y1,
            this.Y2,
            this.Y3});
            this.PlanMatrix.Location = new System.Drawing.Point(12, 12);
            this.PlanMatrix.Name = "PlanMatrix";
            this.PlanMatrix.Size = new System.Drawing.Size(400, 244);
            this.PlanMatrix.TabIndex = 0;
            // 
            // X0
            // 
            this.X0.HeaderText = "X0";
            this.X0.Name = "X0";
            this.X0.Width = 50;
            // 
            // X1
            // 
            this.X1.HeaderText = "X1";
            this.X1.Name = "X1";
            this.X1.Width = 50;
            // 
            // X2
            // 
            this.X2.HeaderText = "X2";
            this.X2.Name = "X2";
            this.X2.Width = 50;
            // 
            // X3
            // 
            this.X3.HeaderText = "X3";
            this.X3.Name = "X3";
            this.X3.Width = 50;
            // 
            // Y1
            // 
            this.Y1.HeaderText = "Y1";
            this.Y1.Name = "Y1";
            this.Y1.Width = 50;
            // 
            // Y2
            // 
            this.Y2.HeaderText = "Y2";
            this.Y2.Name = "Y2";
            this.Y2.Width = 50;
            // 
            // Y3
            // 
            this.Y3.HeaderText = "Y3";
            this.Y3.Name = "Y3";
            this.Y3.Width = 50;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(12, 322);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "b0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "b1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "b2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "b3";
            // 
            // textB0
            // 
            this.textB0.Location = new System.Drawing.Point(483, 12);
            this.textB0.Name = "textB0";
            this.textB0.ReadOnly = true;
            this.textB0.Size = new System.Drawing.Size(79, 20);
            this.textB0.TabIndex = 6;
            // 
            // textB1
            // 
            this.textB1.Location = new System.Drawing.Point(483, 39);
            this.textB1.Name = "textB1";
            this.textB1.ReadOnly = true;
            this.textB1.Size = new System.Drawing.Size(79, 20);
            this.textB1.TabIndex = 7;
            // 
            // textB3
            // 
            this.textB3.Location = new System.Drawing.Point(483, 93);
            this.textB3.Name = "textB3";
            this.textB3.ReadOnly = true;
            this.textB3.Size = new System.Drawing.Size(79, 20);
            this.textB3.TabIndex = 8;
            // 
            // textB2
            // 
            this.textB2.Location = new System.Drawing.Point(483, 66);
            this.textB2.Name = "textB2";
            this.textB2.ReadOnly = true;
            this.textB2.Size = new System.Drawing.Size(79, 20);
            this.textB2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gрасч.";
            // 
            // textG
            // 
            this.textG.Location = new System.Drawing.Point(483, 138);
            this.textG.Name = "textG";
            this.textG.ReadOnly = true;
            this.textG.Size = new System.Drawing.Size(79, 20);
            this.textG.TabIndex = 11;
            // 
            // S2reproduced
            // 
            this.S2reproduced.Location = new System.Drawing.Point(483, 173);
            this.S2reproduced.Name = "S2reproduced";
            this.S2reproduced.ReadOnly = true;
            this.S2reproduced.Size = new System.Drawing.Size(79, 20);
            this.S2reproduced.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "S^2воспр";
            // 
            // Equation
            // 
            this.Equation.AutoSize = true;
            this.Equation.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equation.Location = new System.Drawing.Point(92, 261);
            this.Equation.Name = "Equation";
            this.Equation.Size = new System.Drawing.Size(0, 25);
            this.Equation.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "The equation:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fрасч";
            // 
            // Fcalc
            // 
            this.Fcalc.Location = new System.Drawing.Point(483, 208);
            this.Fcalc.Name = "Fcalc";
            this.Fcalc.ReadOnly = true;
            this.Fcalc.Size = new System.Drawing.Size(79, 20);
            this.Fcalc.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 355);
            this.Controls.Add(this.Fcalc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Equation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.S2reproduced);
            this.Controls.Add(this.textG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textB2);
            this.Controls.Add(this.textB3);
            this.Controls.Add(this.textB1);
            this.Controls.Add(this.textB0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.PlanMatrix);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlanMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PlanMatrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn X0;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn X3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y3;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textB0;
        private System.Windows.Forms.TextBox textB1;
        private System.Windows.Forms.TextBox textB3;
        private System.Windows.Forms.TextBox textB2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textG;
        private System.Windows.Forms.TextBox S2reproduced;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Equation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Fcalc;
    }
}

