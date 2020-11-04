using System;

namespace solutions
{
    public class ExactSolution : Solution
    {
        private double _constant;
        
        private double func(double x)
        {
            return x * (_constant * x - 1);
        }

        private void constCalculation(double initX, double initY)
        {
            _constant = (initY + initX) / (initX * initX);
        }

        public double[] Solve(double[] xArray, double initY, double step)
        {
            double[] yArray = new double[xArray.Length];
            constCalculation(xArray[0], initY);
            yArray[0] = initY;
            for (int i = 1; i < xArray.Length; i++)
            {
                yArray[i] = func(xArray[i]);
            }
            return yArray;
        }
        
    }
}