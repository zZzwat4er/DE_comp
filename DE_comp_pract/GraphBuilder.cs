using System;
using solutions;

namespace DE_comp_pract
{
    public class GraphBuilder
    {
        private double [] _xArray;
        private double [] _yArray;
        private double _step;
        private Solution _solMethod;
        
        public double[] XArray => _xArray;
        public double[] YArray => _yArray;
        
        
        public GraphBuilder(double initialX, double finaleX, double initialY, int stepAmount, Solution solMethod){
            Build(initialX, finaleX, initialY, stepAmount, solMethod);
        }

        public GraphBuilder(Solution solMethod) : this(1, 10, 2, 9, solMethod){}

        private void Build(double initialX, double finaleX, double initialY, int stepAmount, Solution solMethod)
        {
            _xArray = new double[stepAmount + 1];
            _yArray = new double[stepAmount + 1];
            _yArray[0] = initialY;
            _xArray[0] = initialX;
            _solMethod = solMethod;
            if (stepAmount < 0) throw new Exception("N cannot be negative");
            if (stepAmount == 0) throw new Exception("N cannot be equal to zero");
            _step = (finaleX - initialX) / stepAmount;
            if(_step <= 0) throw new Exception("Initial value if \"x\" cannot be greater than finale one");
            for (int i = 1; i < stepAmount + 1; i++)
            {
                _xArray[i] = _xArray[i - 1] + _step;
            }
            _yArray = _solMethod.Solve(_xArray, initialY, _step);
        }

        public void Rebuild(double initialX, double finaleX, double initialY, int stepAmount)
        {
            Build(initialX, finaleX, initialY, stepAmount, _solMethod);
        }
    }
}