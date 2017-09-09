using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPAlgorithms.DataStructures;

namespace DSPAlgorithms.Algorithms
{
    public class Folder : Algorithm
    {
        public Signal InputSignal { get; set; }
        public Signal OutputFoldedSignal { get; set; }

        public override void Run()
        {
            List<float> samples = new List<float>();
            List<int> indices = new List<int>();

            for (int i = InputSignal.Samples.Count-1; i >=0 ; i--)
            {
                samples.Add(InputSignal.Samples[i]);
                indices.Add(-1 * InputSignal.SamplesIndices[i]);
            }
           // indices.Sort();
            OutputFoldedSignal = new Signal(samples,indices, false);
        }
    }
}
