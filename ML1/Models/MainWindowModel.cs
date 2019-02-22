using ML1.Activations;
using ML1.NeuralNetwork;
using System;
using System.Windows;

namespace ML1.Models
{
    public class MainWindowModel : DependencyObject
    {
        public ColumnChartModel Columns { get; set; }
        public LinearChartModel Lines { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public int E { get; set; }
        public double L { get; set; }
        public double LearnNoise { get; set; }
        public double TestNoise { get; set; }
        public int TestSample { get; set; }
        public double[][] Trainigs { get; set; }

        private INeuralNet _neuralNet;
        private double[][] _expectations;

        public MainWindowModel()
        {
            Columns = new ColumnChartModel();
            Lines = new LinearChartModel();

            _expectations = new double[][] {
                new double[] { 0, 0, 0, 1 }, // 1
                new double[] { 0, 0, 1, 0 }, // 2
                new double[] { 0, 1, 0, 0 }, // 3
                new double[] { 1, 0, 0, 0 }, // 4
            };
        }
        public void Train()
        {
            _neuralNet = new NeuralNet(new int[] { Trainigs[0].Length, X, Y, 4 }, L, 0, 1, new Sigmoid(), new MeanSquare());

            var noises = new double[2][][];
            for (var j = 0; j < noises.Length; j++)
            {
                noises[j] = new double[Trainigs.Length][];
                for (var k = 0; k < Trainigs.Length; k++)
                {
                    noises[j][k] = AddNoise(Trainigs[k], LearnNoise);
                }
            }

            var learnErrors = new double[E];
            var testErrors = new double[E];
            for (var i = 0; i < E; i++)
            {
                testErrors[i] = 0;
                for (var j = 0; j < noises.Length; j++)
                {
                    for (var k = 0; k < Trainigs.Length; k++)
                    {
                        testErrors[i] += _neuralNet.Run(noises[j][k], _expectations[k], out double[] outputs);
                    }
                }
                testErrors[i] /= noises.Length * Trainigs.Length;

                learnErrors[i] = 0;
                for (var j = 0; j < Trainigs.Length; j++)
                {
                    learnErrors[i] += _neuralNet.Train(Trainigs[j], _expectations[j]);
                }
                learnErrors[i] /= Trainigs.Length;
            }

            Lines.SetLines(learnErrors, testErrors);
        }
        public void Run()
        {
            if (_neuralNet == null) return;
            _neuralNet.Run(AddNoise(Trainigs[TestSample], TestNoise), _expectations[TestSample], out double[] outputs);
            Columns.SetColumns(outputs);
        }
        private double[] AddNoise(double[] input, double noise)
        {
            var random = new Random((int)DateTime.Now.Ticks);
            var newInput = new double[input.Length];
            var inverted = 0;
            for (var i = 0; i < input.Length; i++)
            {
                if (random.NextDouble() < noise && 
                    inverted < input.Length * noise)
                {
                    newInput[i] = 1 - input[i];
                    inverted++;
                }
                else
                    newInput[i] = input[i];
            }
            return newInput;
        }
    }
}
