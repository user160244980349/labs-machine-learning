namespace ML0.NeuralNetwork
{
    interface INeuralNet
    {
        double Run(double[] inputs, double[] results, out double[] output);
        double Train(double[] inputs, double[] results);
    }
}
