using System;

namespace ML0
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
            return (_random.NextDouble() - 0.5) * 0.5;
        }
    }
}
