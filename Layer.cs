using System.Collections.Generic;

namespace NeuralNetworks
{
    public class Layer
    {
        public List<Neuron> Neurons { get; }
        public int Count => Neurons?.Count ?? 0;

        public Layer(List<Neuron> neurons, NeuronType type = NeuronType.Normal)
        {
            // TODO: проверить все необходимые нейроны на соответствие типу
            
            Neurons = neurons;
        }

    }
}
