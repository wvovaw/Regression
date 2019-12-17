using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Regression
{
    public partial class Regression : Form
    {
        public Regression()
        {
            InitializeComponent();
        }

        DataTable initTable = new DataTable();  //There is gonna be stored init data (The sequence of X:Y points)
        DataTable regTable = new DataTable();   //There is gonna be the calculated data
        DataTable outputTable = new DataTable(); //Table to store output coefficients
        string[] columnTitles = null;
        DataRow dr;
        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\Users\\vladi\\Desktop";
                openFileDialog.Filter = "text files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                    initTable = new DataTable();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        columnTitles = reader.ReadLine().Split(' ');
                        foreach (string c in columnTitles)
                        {
                            initTable.Columns.Add(c);
                        }
                        string newLine;
                        while ((newLine = reader.ReadLine()) != null)
                        {
                            dr = initTable.NewRow();
                            string[] values = newLine.Split(' ');
                            for (int i = 0; i < values.Length; i++)
                            {
                                dr[i] = values[i];
                            }
                            initTable.Rows.Add(dr);
                        }
                        reader.Close();
                        initDataView.DataSource = initTable;
                        initDataView.Update();
                    }
                }
            }
            chart.Series.Clear();
            Series seriesInit = chart.Series.Add("Init points");
            seriesInit.ChartType = SeriesChartType.Point;
            chart.DataSource = initTable;
            if (columnTitles.Length != 0)
            {
                seriesInit.XValueMember = columnTitles[0];
                seriesInit.YValueMembers = columnTitles[1];
            }
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            
            double[] x = initTable.AsEnumerable()
            .Select(row => Convert.ToDouble(row.Field<object>(columnTitles[0]), System.Globalization.CultureInfo.InvariantCulture)).ToArray();
            double[] y = initTable.AsEnumerable()
            .Select(row => Convert.ToDouble(row.Field<object>(columnTitles[1]), System.Globalization.CultureInfo.InvariantCulture)).ToArray();
            double[] ans = LinearRegression.Solve(x, y);
            //Geting coefficients
            outputTable = new DataTable();
            outputTable.Columns.Add("Value");
            outputTable.Columns.Add("Coefficient");
            int coefNum = 0;
            foreach (double coef in ans)
            {
                dr = outputTable.NewRow();
                dr[0] = coef;
                dr[1] = "k" + coefNum++.ToString();
                outputTable.Rows.Add(dr);
            }
            coefNum = 0;
            outputDataView.DataSource = outputTable;
            outputDataView.Update();
            //Calculating the approximated function
            regTable = initTable;
            for (int i = 0; i < regTable.Rows.Count; i++)
            {
                regTable.Rows[i][columnTitles[1]] = ans[0] + ans[1] * x[i];
            }
            //Counting the Average Approximation Error
            double[] Y = regTable.AsEnumerable()
            .Select(row => Convert.ToDouble(row.Field<object>(columnTitles[1]), System.Globalization.CultureInfo.InvariantCulture)).ToArray();
            double AAE = LinearRegression.AAE(y, Y);
            labelAAE.Text = AAE.ToString() + '%';
            double ffact = LinearRegression.Ffact();
            labelFisher.Text = ffact.ToString();
            //Drawing an approximated series
            Series seriesReg = new Series("Regression line");
            chart.Series.Remove(seriesReg);
            try
            {
                chart.Series.Add(seriesReg);
            }
            catch { /*oops*/}
            seriesReg.ChartType = SeriesChartType.Spline;
            if (columnTitles.Length != 0)
            {
                seriesReg.XValueMember = columnTitles[0];
                seriesReg.YValueMembers = columnTitles[1];
            }
            chart.DataSource = regTable;
        }
    }
}
