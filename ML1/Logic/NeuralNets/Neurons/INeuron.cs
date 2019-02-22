using ML1.Activations;

namespace ML1.NeuralNetwork.Neurons
{
    interface INeuron
    {
        IActivation Activation { get; set; }
        double L { get; set; }
        double B { get; set; }
        double Z { get; set; }
        double A { get; }
        double E { get; set; }
        double D { get; }
    }
}
