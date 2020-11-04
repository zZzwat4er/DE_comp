using System;

namespace solutions
{
    public class ImpEulerSolution : Solution
    {
        private double func(double x, double y)
        {
            if(x == 0) throw new Exception("X cannot be equal to zero");
            return 1 + 2 * y / x;
        }
        
        

        public double[] Solve(double[] xArray, double initY, double step)
        {
            double[] yArray = new double[xArray.Length];
            yArray[0] = initY;
            for (int i = 1; i < xArray.Length; i++)
            {
                double k1 = func(xArray[i - 1], yArray[i - 1]);
                double k2 = func(xArray[i], yArray[i - 1] + step * k1);
                yArray[i] = yArray[i-1] + step / 2 * (k1 + k2);
            }
            return yArray;
        }
    }
}