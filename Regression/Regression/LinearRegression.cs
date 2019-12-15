using System;

namespace Regression
{
    public class LinearRegression
    {
        public static double[] Solve(double[] x, double[] y)
        {
            int len = x.Length;
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
    }
}
