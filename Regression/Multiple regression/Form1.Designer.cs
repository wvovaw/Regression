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
            this.groupCoeff = new System.Windows.Forms.GroupBox();
            this.textB2 = new System.Windows.Forms.TextBox();
            this.textB3 = new System.Windows.Forms.TextBox();
            this.textB1 = new System.Windows.Forms.TextBox();
            this.textB0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupKohren = new System.Windows.Forms.GroupBox();
            this.textG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Fcalc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Equation = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textYoutput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textX1input = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textX2input = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textX3input = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlanMatrix)).BeginInit();
            this.groupCoeff.SuspendLayout();
            this.groupKohren.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.PlanMatrix.Size = new System.Drawing.Size(395, 209);
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
            this.BtnStart.Location = new System.Drawing.Point(12, 291);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // groupCoeff
            // 
            this.groupCoeff.Controls.Add(this.textB2);
            this.groupCoeff.Controls.Add(this.textB3);
            this.groupCoeff.Controls.Add(this.textB1);
            this.groupCoeff.Controls.Add(this.textB0);
            this.groupCoeff.Controls.Add(this.label4);
            this.groupCoeff.Controls.Add(this.label3);
            this.groupCoeff.Controls.Add(this.label2);
            this.groupCoeff.Controls.Add(this.label1);
            this.groupCoeff.Location = new System.Drawing.Point(413, 7);
            this.groupCoeff.Name = "groupCoeff";
            this.groupCoeff.Size = new System.Drawing.Size(149, 116);
            this.groupCoeff.TabIndex = 19;
            this.groupCoeff.TabStop = false;
            this.groupCoeff.Text = "Coefficients";
            // 
            // textB2
            // 
            this.textB2.Location = new System.Drawing.Point(30, 65);
            this.textB2.Name = "textB2";
            this.textB2.ReadOnly = true;
            this.textB2.Size = new System.Drawing.Size(109, 20);
            this.textB2.TabIndex = 17;
            // 
            // textB3
            // 
            this.textB3.Location = new System.Drawing.Point(30, 91);
            this.textB3.Name = "textB3";
            this.textB3.ReadOnly = true;
            this.textB3.Size = new System.Drawing.Size(109, 20);
            this.textB3.TabIndex = 16;
            // 
            // textB1
            // 
            this.textB1.Location = new System.Drawing.Point(30, 39);
            this.textB1.Name = "textB1";
            this.textB1.ReadOnly = true;
            this.textB1.Size = new System.Drawing.Size(109, 20);
            this.textB1.TabIndex = 15;
            // 
            // textB0
            // 
            this.textB0.Location = new System.Drawing.Point(30, 12);
            this.textB0.Name = "textB0";
            this.textB0.ReadOnly = true;
            this.textB0.Size = new System.Drawing.Size(109, 20);
            this.textB0.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "b3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "b2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "b1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "b0";
            // 
            // groupKohren
            // 
            this.groupKohren.Controls.Add(this.textG);
            this.groupKohren.Controls.Add(this.label5);
            this.groupKohren.Location = new System.Drawing.Point(413, 129);
            this.groupKohren.Name = "groupKohren";
            this.groupKohren.Size = new System.Drawing.Size(149, 45);
            this.groupKohren.TabIndex = 20;
            this.groupKohren.TabStop = false;
            this.groupKohren.Text = "Cochran’s G test";
            // 
            // textG
            // 
            this.textG.Location = new System.Drawing.Point(47, 19);
            this.textG.Name = "textG";
            this.textG.ReadOnly = true;
            this.textG.Size = new System.Drawing.Size(92, 20);
            this.textG.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Gcalc.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Fcalc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(413, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 41);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fisher\'s F test";
            // 
            // Fcalc
            // 
            this.Fcalc.Location = new System.Drawing.Point(47, 14);
            this.Fcalc.Name = "Fcalc";
            this.Fcalc.ReadOnly = true;
            this.Fcalc.Size = new System.Drawing.Size(92, 20);
            this.Fcalc.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fcalc.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Equation);
            this.groupBox2.Location = new System.Drawing.Point(12, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 58);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equation";
            // 
            // Equation
            // 
            this.Equation.AutoSize = true;
            this.Equation.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equation.Location = new System.Drawing.Point(6, 25);
            this.Equation.Name = "Equation";
            this.Equation.Size = new System.Drawing.Size(0, 25);
            this.Equation.TabIndex = 16;
            // 
            // BtnCalc
            // 
            this.BtnCalc.Enabled = false;
            this.BtnCalc.Location = new System.Drawing.Point(240, 18);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(64, 41);
            this.BtnCalc.TabIndex = 23;
            this.BtnCalc.Text = "Calculate";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnXinput_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textX3input);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textX2input);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textYoutput);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textX1input);
            this.groupBox3.Controls.Add(this.BtnCalc);
            this.groupBox3.Location = new System.Drawing.Point(167, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 60);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Count Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Y";
            // 
            // textYoutput
            // 
            this.textYoutput.Enabled = false;
            this.textYoutput.Location = new System.Drawing.Point(330, 29);
            this.textYoutput.Name = "textYoutput";
            this.textYoutput.ReadOnly = true;
            this.textYoutput.Size = new System.Drawing.Size(52, 20);
            this.textYoutput.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "X1";
            // 
            // textX1input
            // 
            this.textX1input.Enabled = false;
            this.textX1input.Location = new System.Drawing.Point(26, 29);
            this.textX1input.Name = "textX1input";
            this.textX1input.Size = new System.Drawing.Size(52, 20);
            this.textX1input.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "X2";
            // 
            // textX2input
            // 
            this.textX2input.Enabled = false;
            this.textX2input.Location = new System.Drawing.Point(104, 29);
            this.textX2input.Name = "textX2input";
            this.textX2input.Size = new System.Drawing.Size(52, 20);
            this.textX2input.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "X3";
            // 
            // textX3input
            // 
            this.textX3input.Enabled = false;
            this.textX3input.Location = new System.Drawing.Point(182, 29);
            this.textX3input.Name = "textX3input";
            this.textX3input.Size = new System.Drawing.Size(52, 20);
            this.textX3input.TabIndex = 30;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(12, 323);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 25;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 354);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PlanMatrix);
            this.Controls.Add(this.groupCoeff);
            this.Controls.Add(this.groupKohren);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlanMatrix)).EndInit();
            this.groupCoeff.ResumeLayout(false);
            this.groupCoeff.PerformLayout();
            this.groupKohren.ResumeLayout(false);
            this.groupKohren.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupCoeff;
        private System.Windows.Forms.TextBox textB2;
        private System.Windows.Forms.TextBox textB3;
        private System.Windows.Forms.TextBox textB1;
        private System.Windows.Forms.TextBox textB0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupKohren;
        private System.Windows.Forms.TextBox textG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Fcalc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Equation;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textYoutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textX1input;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textX3input;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textX2input;
        private System.Windows.Forms.Button BtnExit;
    }
}

