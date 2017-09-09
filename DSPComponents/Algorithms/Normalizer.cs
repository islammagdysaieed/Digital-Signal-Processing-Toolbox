using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPAlgorithms.DataStructures;

namespace DSPAlgorithms.Algorithms
{
    public class Normalizer : Algorithm
    {
        public Signal InputSignal { get; set; }
        public float InputMinRange { get; set; }
        public float InputMaxRange { get; set; }
        public Signal OutputNormalizedSignal { get; set; }

        public override void Run()
        {
           List<float> outSamples = new List<float>();
           float Xmax =  InputSignal.Samples.Max();
           float Xmin = InputSignal.Samples.Min();

           for (int i = 0; i < InputSignal.Samples.Count; i++)
           {
               float Xi = InputSignal.Samples[i];
               float Xnorm = InputMinRange + (((Xi-Xmin)*(InputMaxRange-InputMinRange))/(Xmax-Xmin));
               outSamples.Add(Xnorm);
           }
            OutputNormalizedSignal = new Signal(outSamples, false);
        }
    }
}
