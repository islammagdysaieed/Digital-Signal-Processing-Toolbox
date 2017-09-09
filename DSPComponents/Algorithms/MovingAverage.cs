using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPAlgorithms.DataStructures;

namespace DSPAlgorithms.Algorithms
{
    public class MovingAverage : Algorithm
    {
        public Signal InputSignal { get; set; }
        public int InputWindowSize { get; set; }
        public Signal OutputAverageSignal { get; set; }

        public override void Run()
        {
            List<float> outSamples = new List<float>();
            for (int i = 0; i < InputSignal.Samples.Count-(InputWindowSize-1); i++)
            {
                float avg = 0;
                for (int k = i; k < i+InputWindowSize; k++)
                {
                    avg += InputSignal.Samples[k];
                }
                avg /= InputWindowSize;
                outSamples.Add(avg);
            }
            OutputAverageSignal = new Signal(outSamples, false);
            
        }
    }
}
