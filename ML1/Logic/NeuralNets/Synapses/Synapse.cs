using ML1.NeuralNetwork.Neurons;

namespace ML1.NeuralNetwork.Synapses
{
    class Synapse : ISynapse
    {
        public INeuron P { get; set; }
        public INeuron Q { get; set; }
        public double N { get; set; }
        public double W { get; set; }
        
        public void ForwardPropagation()
        {
            Q.Z += P.A * W;
        }
        public void BackPropagation()
        {
            W += N * Q.D * P.A;
            P.E += Q.D * W;
        }
    }
}
