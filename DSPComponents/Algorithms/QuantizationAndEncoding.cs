using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPAlgorithms.DataStructures;

namespace DSPAlgorithms.Algorithms
{
    public struct Interval 
    { 
     public   double Start,End;
     public Interval(double Start, double End) 
        {
            this.Start = Start;
            this.End = End;
        }
    }
    public class QuantizationAndEncoding : Algorithm
    {
        // You will have only one of (InputLevel or InputNumBits), the other property will take a negative value
        // If InputNumBits is given, you need to calculate and set InputLevel value and vice versa
        public int InputLevel { get; set; }
        public int InputNumBits { get; set; }
        public Signal InputSignal { get; set; }
        public Signal OutputQuantizedSignal { get; set; }
        public List<int> OutputIntervalIndices { get; set; }
        public List<string> OutputEncodedSignal { get; set; }
        public List<float> OutputSamplesError { get; set; }
        string ToBinary(int num, int size)
        {
            string res = "";
            while (num != 0)
            {
                int mod = num % 2;
                num /= 2;
                res = mod.ToString()+res;
            }
            while(res.Length<size)
                res = '0' + res;
           
            return res;
        }
        public override void Run()
        {
         //   ToBinary(2, 4);
            if (InputNumBits == null || InputNumBits == 0)
            { InputNumBits = (int)Math.Log(InputLevel, 2); }

            if (InputLevel == null || InputLevel == 0)
            { InputLevel = (int)Math.Pow(2, InputNumBits); }

            List<float> InputSampels = new List<float>(InputSignal.Samples);
            InputSampels.Sort();
            double resolution = (InputSampels[InputSampels.Count-1] - InputSampels[0])/InputLevel;
            List<Interval> intervals = new List<Interval>();
            List<double> midPoints = new List<double>();
            List<string> codes = new List<string>();
            double tmpStart = InputSampels[0];
            for (int i = 0; i < InputLevel; i++)
            {
                double tmpEnd =  tmpStart + resolution;
                intervals.Add(new Interval(tmpStart, tmpEnd));
                double midPoint = (tmpStart + tmpEnd) / 2;
                midPoints.Add(midPoint);
                codes.Add(ToBinary(i,InputNumBits));
                tmpStart = tmpEnd ;
            }
            List<float> outSamples = new List<float>();
           OutputSamplesError = new List<float>();
           OutputEncodedSignal = new List<string>();
           OutputIntervalIndices = new List<int>();
            for (int i = 0; i < InputSignal.Samples.Count; i++)
            {
               // int index = -1;
                double sampleValue = InputSignal.Samples[i];
                for (int j = 0; j < InputLevel; j++)
                {
                    if (sampleValue >= intervals[j].Start && sampleValue <= intervals[j].End)
                    {
                        outSamples.Add((float)midPoints[j]);
                        OutputSamplesError.Add((float)(midPoints[j] - sampleValue));
                        OutputEncodedSignal.Add(codes[j]);
                        OutputIntervalIndices.Add(j+1);
                    }
                }
            }
            OutputQuantizedSignal = new Signal(outSamples,false);

        }
           
    }
}
