using System;

namespace solutions
{
    public class EulerSolution : Solution
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
                yArray[i] = yArray[i-1] + step * func(xArray[i - 1], yArray[i - 1]);
            }
            return yArray;
        }
    }
}