using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPAlgorithms.DataStructures;
using System.Numerics;
namespace DSPAlgorithms.Algorithms
{
    public class DiscreteFourierTransform : Algorithm
    {
        public Signal InputTimeDomainSignal { get; set; }
        public float InputSamplingFrequency { get; set; }
        public Signal OutputFreqDomainSignal { get; set; }

        public override void Run()
        {
            int N = InputTimeDomainSignal.Samples.Count;
            double Fs = InputSamplingFrequency;
            double sigma = (2*Math.PI*Fs)/N;
            double Ts = (double)1 / (double)Fs;
            List<float> freqs = new List<float>();
            List<float> phases = new List<float>();
            List<float> Amps = new List<float>();
            for (int k = 0; k < N; k++)
            {
                Complex addtion = new Complex(0,0); 
                for (int n = 0; n < N; n++)
                {
                    double x =  sigma * k * n * Ts;
                    Complex right_Mul = new Complex(Math.Cos(x), -1 *Math.Sin(x));           
                    Complex left_Mul = new Complex(InputTimeDomainSignal.Samples[n], 0);
                    Complex mul_Result = Complex.Multiply(left_Mul, right_Mul);
                    addtion =  Complex.Add(addtion, mul_Result);
                }
                freqs.Add((float)(k * Ts));
                phases.Add((float)addtion.Phase);
                Amps.Add((float)addtion.Magnitude);
            }
            OutputFreqDomainSignal = new Signal(false,freqs,Amps,phases);      
        }
    }
}
