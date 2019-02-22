using System;

namespace ML1.NeuralNetwork
{
    class MeanSquare : ICoast
    {
        public double Real(double expected, double actual)
        {
            return Math.Pow(expected - actual, 2);
        }
        public double Derivative(double expected, double actual)
        {
            return 2 * (expected - actual);
        }
    }
}
