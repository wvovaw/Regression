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

        double[] S2 = new double[8];
        double Smax = 0, Ssum = 0, Sre, Sad = 0;
        double G = 0;
        double[] coefs = new double[4];
        double[] yapp = new double[8];
        double Fc = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            PlanMatrix.DataSource = initTable;
            for (int i = 0; i < 8; i++)
            {
                dr = initTable.NewRow();
                initTable.Rows.Add(dr);
            }
        }
        private void BtnXinput_Click(object sender, EventArgs e)
        {
            double y = 0;
            y = coefs[0] + coefs[1] * Convert.ToDouble(textX1input.Text) + coefs[2] * Convert.ToDouble(textX2input.Text) + coefs[3] * Convert.ToDouble(textX3input.Text);
            textYoutput.Text = y.ToString();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
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
                            MessageBox.Show("Wrong symbol on. Make sure you have inputed everything right." + '(' + i.ToString() + ", " + j.ToString() + ')');
                            plan = new int[8, 4];
                            return;
                        }
                    }
                }
                try
                {
                    for (int i = 0; i < 8; i++)
                    {
                        y1[i] = Convert.ToDouble(PlanMatrix[4, i].Value);
                        y2[i] = Convert.ToDouble(PlanMatrix[5, i].Value);
                        y3[i] = Convert.ToDouble(PlanMatrix[6, i].Value);
                        ymid[i] = (y1[i] + y2[i] + y3[i]) / 3;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Wrong symbol. Make sure you have inputed everything right.");
                    return;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error: Empty input field.");
                return;
            }
            for (int i = 0; i < 8; i++)
            {
                S2[i] = (Math.Pow((y1[i] - ymid[i]), 2) + Math.Pow((y2[i] - ymid[i]), 2) + Math.Pow((y3[i] - ymid[i]), 2)) / 2;
                if (S2[i] > Smax) Smax = S2[i];
                Ssum += S2[i];
            }
            G = Smax / Ssum;
            textG.Text = G.ToString();
            if (G <= 0.5157)
            {
                textG.BackColor = Color.SpringGreen;
                Sre = (Ssum / 8);
                //S2reproduced.Text = Sre.ToString();

                for (int i = 0; i < 4; i++)
                {
                    coefs[i] = 0;
                    for (int j = 0; j < 8; j++)
                    {
                        coefs[i] += plan[j, i] * ymid[j];
                    }
                    coefs[i] /= 8.0;
                }
                textB0.Text = coefs[0].ToString();
                textB1.Text = coefs[1].ToString();
                textB2.Text = coefs[2].ToString();
                textB3.Text = coefs[3].ToString();
                Equation.Text = "y =";
                if (coefs[0] < 0) Equation.Text += " — ";
                else Equation.Text += " + ";
                Equation.Text += Math.Round(Math.Abs(coefs[0]), 3).ToString();
                for (int i = 1; i < 4; i++)
                {
                    if (coefs[i] < 0) Equation.Text += " — ";
                    else Equation.Text += " + ";
                    Equation.Text += Math.Round(Math.Abs(coefs[i]), 3).ToString() + "x" + i.ToString();
                }
                for (int i = 0; i < 8; i++)
                    yapp[i] = coefs[0] + coefs[1] * plan[i, 1] + coefs[2] * plan[i, 2] + coefs[3] * plan[i, 3];

                for (int i = 0; i < 8; i++)
                    Sad += Math.Pow((ymid[i] - yapp[i]), 2);
                Sad = Sad * 3 / 4;
                Fc = Sad / Sre;
                Fcalc.Text = Fc.ToString();
                if (Fc <= 3.7294)
                {
                    Fcalc.BackColor = Color.SpringGreen;
                    textX1input.Enabled = true;
                    textX2input.Enabled = true;
                    textX3input.Enabled = true;
                    BtnCalc.Enabled = true;
                }
                else Fcalc.BackColor = Color.IndianRed;
            }
            else textG.BackColor = Color.IndianRed;

            Smax = 0;
            Ssum = 0;
            Sre = 0;
            Sad = 0;
            G = 0;
            Fc = 0;
            textG.BackColor = Fcalc.BackColor = textB0.BackColor;
            textX1input.Enabled = false;
            textX2input.Enabled = false;
            textX3input.Enabled = false;
            BtnCalc.Enabled = false;
        }
    }
}
