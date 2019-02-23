using ML0.NeuralNetwork.Neurons;

namespace ML0.NeuralNetwork.Synapses
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
