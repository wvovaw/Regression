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

        DataTable initTable = new DataTable();
        DataTable outputTable = new DataTable();

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            string[] columnTitles = null;
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
                            DataRow dr = initTable.NewRow();
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
    }
}
