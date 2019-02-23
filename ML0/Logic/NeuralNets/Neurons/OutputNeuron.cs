using ML0.Activations;

namespace ML0.NeuralNetwork.Neurons
{
    class OutputNeuron : INeuron
    {
        public IActivation Activation { get; set; }
        public double L { get; set; }
        public double B { get; set; }
        public double Z { get; set; }
        public double A {
            get {
                return Activation.Real(L, Z + B);
            }
        }
        public double E { get; set; }
        public double D {
            get {
                return E * Activation.Derivative(L, Z + B);
            }
        }
    }
}
