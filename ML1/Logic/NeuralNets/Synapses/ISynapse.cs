using ML1.NeuralNetwork.Neurons;

namespace ML1.NeuralNetwork.Synapses
{
    interface ISynapse
    {
        INeuron P { get; set; }
        INeuron Q { get; set; }
        double N { get; set; }
        double W { get; set; }

        void ForwardPropagation();
        void BackPropagation();
    }
}
