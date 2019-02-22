using System;

namespace ML1
{
    class WeightGenerator
    {
        private Random _random;

        public WeightGenerator()
        {
            _random = new Random((int)DateTime.Now.Ticks);
        }
        public double Get()
        {
            return (_random.NextDouble() - 0.5) * 2;
        }
    }
}
