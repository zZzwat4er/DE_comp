using System;

namespace solutions
{
    public class ErrorSearch : Solution
    {
        private double [] _exactY;
        private double [] _solutionY;

        public ErrorSearch(double [] exactY, double [] solutinY)
        {
            _exactY = exactY;
            _solutionY = solutinY;
        }

        public double[] Solve(double[] xArray, double initY, double step)
        {
            if(_exactY.Length != _solutionY.Length) throw new Exception("There is different array lengths");
            double[] yArray = new double[_exactY.Length];
            for(int i = 0; i < yArray.Length; i++){
                yArray[i] = _exactY[i] - _solutionY[i];
            }
            return yArray;
        }
    }
}