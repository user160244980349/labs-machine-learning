using ML0.Activations;

namespace ML0.NeuralNetwork.Neurons
{
    class InputNeuron : INeuron
    {
        public IActivation Activation { get; set; }
        public double L { get; set; }
        public double B { get; set; }
        public double Z { get; set; }
        public double A {
            get {
                return Z;
            }
        }
        public double E { get; set; }
        public double D {
            get {
                return 0;
            }
        }
    }
}
