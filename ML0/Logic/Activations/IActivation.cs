namespace ML0.Activations
{
    interface IActivation
    {
        double Real(double l, double input);
        double Derivative(double l, double input);
    }
}
