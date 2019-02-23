using System;

namespace ML0.Activations
{
    class Sigmoid : IActivation
    {
        public double Real(double l, double input)
        {
            return 1 / (1 + Math.Pow(Math.E, -l * input));
        }
        public double Derivative(double l, double input)
        {
            return Real(l, input) * (1 - Real(l, input));
        }
    }
}
