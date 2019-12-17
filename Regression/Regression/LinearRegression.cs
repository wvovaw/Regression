using System;

namespace Regression
{
    public class LinearRegression
    {
        static int len;
        static double R2;
        // Sollve k0 and k1 coefficients
        public static double[] Solve(double[] x, double[] y)
        {
            len = x.Length;
            double[] vectorX2 = new double[len];
            double[] vectorXY = new double[len];

            for (int i = 0; i < x.Length; i++)
            {
                vectorX2[i] = Math.Pow(x[i], 2);
                vectorXY[i] = x[i] * y[i];
            }

            double sumX = 0;
            double sumY = 0;
            double sumXY = 0;
            double sumX2 = 0;
            for (int i = 0; i < len; i++)
            {
                sumX += x[i];
                sumY += y[i];
                sumXY += vectorXY[i];
                sumX2 += vectorX2[i];
            }

            double[] res = { (sumY * sumX2 - sumX * sumXY) / (len * sumX2 - sumX * sumX),
                             (len * sumXY - sumX * sumY) / (len * sumX2 - sumX * sumX) };
            return res;
        }
        // Average Approximation Error
        public static double AAE(double[] y, double[] Y)
        {
            double sumAAE = 0;
            double d1 = 0; //Explained dispersion
            double d2 = 0; //Not explained dispersion
            double AVGY = 0;
            foreach (var item in Y)
                AVGY += item;
            AVGY /= len;
            for (int i = 0; i < len; i++)
            {
                sumAAE += Math.Abs((y[i] - Y[i]) / y[i]);
                d1 += Math.Pow((y[i] - Y[i]), 2);
                d2 += Math.Pow((y[i] - AVGY), 2);
            }
                
            double AAE = (1 / Convert.ToDouble(len)) * sumAAE * 100;
            R2 = 1 - d1 / d2;
            return AAE;
        }
        // The Fisher test. There are compairing  Ffact and Ftab 
        public static double Ffact()
        {
            double ffact = (R2 / Convert.ToDouble(1 - R2)) * (len - 2);
            return ffact;
        }
    }
}
