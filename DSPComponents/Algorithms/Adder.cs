using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPAlgorithms.DataStructures;

namespace DSPAlgorithms.Algorithms
{
    public class Adder : Algorithm
    {
        public List<Signal> InputSignals { get; set; }
        public Signal OutputSignal { get; set; }

        int GetMaxSignalSize()
        {
             List<int> sizes = new List<int>();
            for (int j = 0; j < InputSignals.Count; j++)
            { 
              sizes.Add(InputSignals[j].Samples.Count);
            }
            return sizes.Max();
        }

        public override void Run()
        {
            int MaxSize = GetMaxSignalSize();
            List<float> outSamples = new List<float>();
            for (int i = 0; i < MaxSize; i++)
            {
                float sum = 0;
                for (int j = 0; j < InputSignals.Count; j++)
                {
                    if (i >= InputSignals[j].Samples.Count) continue;
                    sum += InputSignals[j].Samples[i];
                }
                outSamples.Add(sum);
            }
            OutputSignal = new Signal(outSamples, false);
            //  throw new NotImplementedException();
        }
    }
}
