using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPAlgorithms.DataStructures;

namespace DSPAlgorithms.Algorithms
{
    public class Convolution : Algorithm
    {
        public Signal InputSignal1 { get; set; }
        public Signal InputSignal2 { get; set; }
        public Signal OutputConvolvedSignal { get; set; }

        /// <summary>
        /// Convolved InputSignal1 (considered as X) with InputSignal2 (considered as H)
        /// </summary>
        public override void Run()
        {
            int minIndex = InputSignal1.SamplesIndices[0] + InputSignal2.SamplesIndices[0];
            int maxIndex = minIndex + ((InputSignal1.Samples.Count + InputSignal2.Samples.Count) - 1);
            List<int> resultIndices = new List<int>();
            List<float> resultSamples = new List<float>();
            for (int i = minIndex; i < maxIndex; i++)
            {
                double sum = 0;
                int S1S = InputSignal1.SamplesIndices[0], S1E = InputSignal1.SamplesIndices[InputSignal1.SamplesIndices.Count-1];
                int S2S = InputSignal2.SamplesIndices[0], S2E = InputSignal2.SamplesIndices[InputSignal2.SamplesIndices.Count - 1];
                for (int j = minIndex; j < maxIndex; j++)
                {
                    if (j < S1S || j > S1E) continue;
                    if (i-j < S2S || i-j > S2E) continue;
                    sum += (((double)InputSignal1.Samples[j - S1S]) * ((double)InputSignal2.Samples[(i - j) - S2S]));
                }
                resultSamples.Add((float)sum);
                resultIndices.Add(i);
            }
            OutputConvolvedSignal = new Signal(resultSamples, resultIndices, false);
        }
    }
}
