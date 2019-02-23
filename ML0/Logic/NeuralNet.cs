using ML0.Activations;
using ML0.NeuralNetwork.Neurons;
using ML0.NeuralNetwork.Synapses;
using System;
using System.Text;
using System.Windows;

namespace ML0.NeuralNetwork
{
    class NeuralNet : INeuralNet
    {
        private int[] _layers;
        private int _inputCount;
        private int _outputCount;
        private int _neuronsCount;
        private int _synapsesCount;
        private INeuron[] _neurons;
        private ISynapse[] _synapses;
        private ICoast _coast;
        private WeightGenerator _generator;

        public NeuralNet(int[] layers, double learningRate, double bias, double excess, IActivation activation, ICoast coast)
        {
            _coast = coast;
            _generator = new WeightGenerator();
            _layers = layers;
            _inputCount = layers[0];
            _outputCount = layers[layers.Length - 1];

            _neuronsCount = GetNeuronsCount(layers);
            _synapsesCount = GetSynapsesCount(layers);

            _neurons = CreateNeurons(_neuronsCount, _inputCount, _outputCount, bias, excess, activation);
            _synapses = CreateSynapses(layers, _synapsesCount, learningRate);
        }
        public double Run(double[] inputs, double[] results, out double[] outputs)
        {
            Input(inputs);
            ForwardPropagation();
            var error = Coast(Output(), results);
            outputs = Output();
            Purge();
            return error;
        }
        public double Train(double[] inputs, double[] results)
        {
            Input(inputs);
            ForwardPropagation();
            var error = Coast(Output(), results);
            BackPropagation();
            Purge();
            return error;
        }

        private void Input(double[] inputs)
        {
            for (var i = 0; i < _inputCount; i++)
            {
                _neurons[i].Z = inputs[i];
            }
        }
        private double[] Output()
        {
            var outputs = new double[_outputCount];
            for (var i = 0; i < _outputCount; i++)
            {
                outputs[i] = _neurons[_neurons.Length - _outputCount + i].A;
            }
            return outputs;
        }
        private int GetNeuronsCount(int[] layers)
        {
            var neuronsCount = 0;
            for (var i = 0; i < layers.Length; i++)
            {
                neuronsCount += layers[i];
            }
            return neuronsCount;
        }
        private int GetSynapsesCount(int[] layers)
        {
            var synapsesCount = 0;
            for (var i = 0; i < layers.Length - 1; i++)
            {
                synapsesCount += layers[i] * layers[i + 1];
            }
            return synapsesCount;
        }
        private INeuron[] CreateNeurons(int neuronsCount, int inputCount, int outputCount, double bias, double excess, IActivation activation)
        {
            var neurons = new INeuron[neuronsCount];
            for (var i = 0; i < _inputCount; i++)
            {
                neurons[i] = new InputNeuron
                {
                    B = bias,
                };
            }
            for (var i = _inputCount; i < neuronsCount - _outputCount; i++)
            {
                neurons[i] = new HiddenNeuron
                {
                    Activation = activation,
                    L = 0.5 + 0.25 * 1,
                    B = bias,
                };
            }
            for (var i = neuronsCount - _outputCount; i < neuronsCount; i++)
            {
                neurons[i] = new OutputNeuron
                {
                    Activation = activation,
                    L = 0.5 + 0.25 * 3,
                    B = bias,
                };
            }
            return neurons;
        }
        private ISynapse[] CreateSynapses(int[] layers, int synapsesCount, double learningRate)
        {
            var synapseIndex = 0;
            var firstNeuronInLayer = 0;
            var synapses = new ISynapse[synapsesCount];
            for (var i = 0; i < layers.Length - 1; i++)
            {
                var prevLayerBegin = firstNeuronInLayer;
                var nextLayerBegin = firstNeuronInLayer + layers[i];
                for (var j = prevLayerBegin; j < prevLayerBegin + layers[i]; j++)
                {
                    for (var k = nextLayerBegin; k < nextLayerBegin + layers[i + 1]; k++)
                    {
                        synapses[synapseIndex] = new Synapse
                        {
                            P = _neurons[j],
                            Q = _neurons[k],
                            N = learningRate,
                            W = _generator.Get(),
                        };
                        synapseIndex++;
                    }
                }
                firstNeuronInLayer += layers[i];
            }
            return synapses;
        }
        private void Purge()
        {
            for (var i = 0; i < _neuronsCount; i++)
            {
                _neurons[i].Z = 0;
                _neurons[i].E = 0;
            }
        }
        private void ForwardPropagation()
        {
            for (var i = 0; i < _synapses.Length; i++)
            {
                _synapses[i].ForwardPropagation();
            }
        }
        private double Coast(double[] outputs, double[] results)
        {
            double loss = 0;
            for (var i = 0; i < _outputCount; i++)
            {
                _neurons[_neuronsCount - _outputCount + i].E = _coast.Derivative(results[i], outputs[i]);
                loss += _coast.Real(results[i], outputs[i]);
            }
            return loss;
        }
        private void BackPropagation()
        {
            for (var i = _synapses.Length - 1; i > -1; i--)
            {
                _synapses[i].BackPropagation();
            }
        }
    }
}
