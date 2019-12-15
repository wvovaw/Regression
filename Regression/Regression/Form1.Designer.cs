namespace Regression
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.initDataView = new System.Windows.Forms.DataGridView();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.radioLinear = new System.Windows.Forms.RadioButton();
            this.radioPolynom = new System.Windows.Forms.RadioButton();
            this.outputDataView = new System.Windows.Forms.DataGridView();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioNONE = new System.Windows.Forms.RadioButton();
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
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(576, 500);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // initDataView
            // 
            this.initDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.initDataView.Location = new System.Drawing.Point(594, 12);
            this.initDataView.Name = "initDataView";
            this.initDataView.Size = new System.Drawing.Size(214, 276);
            this.initDataView.TabIndex = 1;
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(594, 294);
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
            this.radioLinear.Location = new System.Drawing.Point(723, 295);
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
            this.radioPolynom.Location = new System.Drawing.Point(723, 318);
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
            this.outputDataView.Location = new System.Drawing.Point(594, 364);
            this.outputDataView.Name = "outputDataView";
            this.outputDataView.Size = new System.Drawing.Size(214, 113);
            this.outputDataView.TabIndex = 5;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(594, 335);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateBtn.TabIndex = 6;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fisher";
            // 
            // radioNONE
            // 
            this.radioNONE.AutoSize = true;
            this.radioNONE.Location = new System.Drawing.Point(723, 341);
            this.radioNONE.Name = "radioNONE";
            this.radioNONE.Size = new System.Drawing.Size(56, 17);
            this.radioNONE.TabIndex = 8;
            this.radioNONE.TabStop = true;
            this.radioNONE.Text = "NONE";
            this.radioNONE.UseVisualStyleBackColor = true;
            // 
            // Regression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 524);
            this.Controls.Add(this.radioNONE);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioNONE;
    }
}

