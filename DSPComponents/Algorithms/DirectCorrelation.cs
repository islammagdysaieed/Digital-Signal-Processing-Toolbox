using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPAlgorithms.DataStructures;

namespace DSPAlgorithms.Algorithms
{
    public class DirectCorrelation : Algorithm
    {
        public Signal InputSignal1 { get; set; }
        public Signal InputSignal2 { get; set; }
        public List<float> OutputNonNormalizedCorrelation { get; set; }
        public List<float> OutputNormalizedCorrelation { get; set; }
        float NormlizationValue()
        {
            int N = ((InputSignal1.Samples.Count + InputSignal2.Samples.Count) - 1);
            float R0S1 = 0;
            for (int i = 0; i < InputSignal1.Samples.Count; i++)
            {
                R0S1 += (InputSignal1.Samples[i] * InputSignal1.Samples[i]);
            }
           //  R0S1/= InputSignal1.Samples.Count;
            float R0S2 = 0;
            for (int i = 0; i < InputSignal2.Samples.Count; i++)
            {
                R0S2 += (InputSignal2.Samples[i] * InputSignal2.Samples[i]);
            }     
            float total = R0S1 * R0S2;
            total = (float)Math.Sqrt((double)total);
            return total/N;
        }
        public override void Run()
        {
         //  if (InputSignal2 == null)
         // InputSignal2 = InputSignal1;//new Signal(InputSignal1.Samples,InputSignal1.SamplesIndices,);
            int N = ((InputSignal1.Samples.Count + InputSignal2.Samples.Count) - 1);
            int minIndex = InputSignal1.SamplesIndices[0] + InputSignal2.SamplesIndices[0];
            int maxIndex = minIndex + N ;
            float normalizationValue = NormlizationValue();
            OutputNonNormalizedCorrelation = new List<float>();
            OutputNormalizedCorrelation = new List<float>();
            for (int i = minIndex; i < maxIndex; i++)
            {
                float sum = 0;
                int S1S = InputSignal1.SamplesIndices[0], S1E = InputSignal1.SamplesIndices[InputSignal1.SamplesIndices.Count - 1];
                int S2S = InputSignal2.SamplesIndices[0], S2E = InputSignal2.SamplesIndices[InputSignal2.SamplesIndices.Count - 1];
                for (int j = minIndex; j < maxIndex; j++)
                {
                    if (j < S1S || j > S1E) continue;
                    if (i + j < S2S || i + j > S2E) continue;
                    sum += (InputSignal1.Samples[j - S1S] * InputSignal2.Samples[(i + j) - S2S]);
                }
                float nonNormlizedValue = sum / N;
                OutputNonNormalizedCorrelation.Add(nonNormlizedValue);
                OutputNormalizedCorrelation.Add(nonNormlizedValue / normalizationValue);
               //  if (InputSignal2.Periodic)
               //     InputSignal2.Samples.Insert(0,(InputSignal2.Samples[InputSignal2.Samples.Count - 1]));
            }   
           
        }
    }
}