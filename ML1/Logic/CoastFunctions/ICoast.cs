namespace ML1.NeuralNetwork
{
    interface ICoast
    {
        double Real(double expected, double actual);
        double Derivative(double expected, double actual);
    }
}