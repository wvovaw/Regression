using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_regression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable initTable = new DataTable();
        DataRow dr;
        int[,] plan = new int[8, 4];
        double[] y1 = new double[8];
        double[] y2 = new double[8];
        double[] y3 = new double[8];
        double[] ymid = new double[8];
        double[] coefs = new double[3];

        private void Form1_Load(object sender, EventArgs e)
        {
            PlanMatrix.DataSource = initTable;
            for (int i = 0; i < 8; i++)
            {
                dr = initTable.NewRow();
                initTable.Rows.Add(dr);
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int r = 0, c = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (PlanMatrix.Rows[i].Cells[j].Value.ToString() == "+")
                        plan[i, j] = 1;
                    else if (PlanMatrix.Rows[i].Cells[j].Value.ToString() == "-")
                        plan[i, j] = -1;
                    else
                    {
                        MessageBox.Show("Wrong symbol in the plan matrix. Make sure you have entered everything correctly. " + PlanMatrix.Rows[i].Cells[j].Value.ToString());
                        plan = new int[8, 4];
                        return;
                    }
                }
            }
        
            for (int i = 0; i < 8; i++)
            {
                y1[i] = Convert.ToDouble(PlanMatrix[4, i].Value);
                y2[i] = Convert.ToDouble(PlanMatrix[5, i].Value);
                y3[i] = Convert.ToDouble(PlanMatrix[6, i].Value);
                ymid[i] = (y1[i] + y2[i] + y3[i]) / 3;
            }
        }
    }
}
