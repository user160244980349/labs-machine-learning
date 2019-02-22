using ML1.Activations;

namespace ML1.NeuralNetwork.Neurons
{
    class HiddenNeuron : INeuron
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
