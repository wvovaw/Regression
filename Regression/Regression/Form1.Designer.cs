﻿namespace Regression
{
    partial class Regression
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.initDataView = new System.Windows.Forms.DataGridView();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.radioLinear = new System.Windows.Forms.RadioButton();
            this.radioPolynom = new System.Windows.Forms.RadioButton();
            this.outputDataView = new System.Windows.Forms.DataGridView();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.l2 = new System.Windows.Forms.Label();
            this.radioNONE = new System.Windows.Forms.RadioButton();
            this.l1 = new System.Windows.Forms.Label();
            this.labelAAE = new System.Windows.Forms.Label();
            this.labelFisher = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(576, 500);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // initDataView
            // 
            this.initDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.initDataView.Location = new System.Drawing.Point(594, 12);
            this.initDataView.Name = "initDataView";
            this.initDataView.Size = new System.Drawing.Size(214, 243);
            this.initDataView.TabIndex = 1;
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(594, 261);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenFileBtn.TabIndex = 2;
            this.OpenFileBtn.Text = "Open file";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // radioLinear
            // 
            this.radioLinear.AutoSize = true;
            this.radioLinear.Location = new System.Drawing.Point(723, 262);
            this.radioLinear.Name = "radioLinear";
            this.radioLinear.Size = new System.Drawing.Size(54, 17);
            this.radioLinear.TabIndex = 3;
            this.radioLinear.TabStop = true;
            this.radioLinear.Text = "Linear";
            this.radioLinear.UseVisualStyleBackColor = true;
            // 
            // radioPolynom
            // 
            this.radioPolynom.AutoSize = true;
            this.radioPolynom.Location = new System.Drawing.Point(723, 285);
            this.radioPolynom.Name = "radioPolynom";
            this.radioPolynom.Size = new System.Drawing.Size(75, 17);
            this.radioPolynom.TabIndex = 4;
            this.radioPolynom.TabStop = true;
            this.radioPolynom.Text = "Polynomial";
            this.radioPolynom.UseVisualStyleBackColor = true;
            // 
            // outputDataView
            // 
            this.outputDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputDataView.Location = new System.Drawing.Point(594, 331);
            this.outputDataView.Name = "outputDataView";
            this.outputDataView.Size = new System.Drawing.Size(214, 113);
            this.outputDataView.TabIndex = 5;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(594, 302);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateBtn.TabIndex = 6;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(594, 499);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(34, 13);
            this.l2.TabIndex = 7;
            this.l2.Text = "Ffact ";
            // 
            // radioNONE
            // 
            this.radioNONE.AutoSize = true;
            this.radioNONE.Location = new System.Drawing.Point(723, 308);
            this.radioNONE.Name = "radioNONE";
            this.radioNONE.Size = new System.Drawing.Size(56, 17);
            this.radioNONE.TabIndex = 8;
            this.radioNONE.TabStop = true;
            this.radioNONE.Text = "NONE";
            this.radioNONE.UseVisualStyleBackColor = true;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(594, 451);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(84, 13);
            this.l1.TabIndex = 9;
            this.l1.Text = "avg approx error";
            // 
            // labelAAE
            // 
            this.labelAAE.AutoSize = true;
            this.labelAAE.Location = new System.Drawing.Point(684, 451);
            this.labelAAE.Name = "labelAAE";
            this.labelAAE.Size = new System.Drawing.Size(0, 13);
            this.labelAAE.TabIndex = 11;
            // 
            // labelFisher
            // 
            this.labelFisher.AutoSize = true;
            this.labelFisher.Location = new System.Drawing.Point(684, 499);
            this.labelFisher.Name = "labelFisher";
            this.labelFisher.Size = new System.Drawing.Size(0, 13);
            this.labelFisher.TabIndex = 10;
            // 
            // Regression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 515);
            this.Controls.Add(this.labelAAE);
            this.Controls.Add(this.labelFisher);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.radioNONE);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.outputDataView);
            this.Controls.Add(this.radioPolynom);
            this.Controls.Add(this.radioLinear);
            this.Controls.Add(this.OpenFileBtn);
            this.Controls.Add(this.initDataView);
            this.Controls.Add(this.chart);
            this.Name = "Regression";
            this.Text = "Regression";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridView initDataView;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.RadioButton radioLinear;
        private System.Windows.Forms.RadioButton radioPolynom;
        private System.Windows.Forms.DataGridView outputDataView;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.RadioButton radioNONE;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label labelAAE;
        private System.Windows.Forms.Label labelFisher;
    }
}

