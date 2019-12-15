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
            //Series seriesReg = chart.Series.Add("Regression line");
            //seriesReg.ChartType = SeriesChartType.Spline;
            chart.DataSource = initTable;
            if(columnTitles.Length != 0)
            {
                seriesInit.XValueMember = columnTitles[0];
                seriesInit.YValueMembers = columnTitles[1];
            }

        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            //double[][] data = initTable.AsEnumerable().Select(x => new[] { Convert.ToDouble(x[0]), Convert.ToDouble(x[1]) }).ToArray();
            double[] x = initTable.AsEnumerable()
            .Select(row => Convert.ToDouble(row.Field<object>(columnTitles[0]), System.Globalization.CultureInfo.InvariantCulture)).ToArray();
            double[] y = initTable.AsEnumerable()
            .Select(row => Convert.ToDouble(row.Field<object>(columnTitles[1]), System.Globalization.CultureInfo.InvariantCulture)).ToArray();
            double[] ans = LinearRegression.Solve(x, y);
            outputTable.Columns.Add("Coefficient");
            outputTable.Columns.Add("Value");
            foreach (double coef in ans)
            {
                dr = outputTable.NewRow();
                dr[0] = coef;
                outputTable.Rows.Add(dr);
            }
            outputDataView.DataSource = outputTable;
            outputDataView.Update();
        }
    }
}
