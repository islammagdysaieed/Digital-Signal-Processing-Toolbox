using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPAlgorithms.DataStructures;
using System.Numerics;

namespace DSPAlgorithms.Algorithms
{
    public class InverseDiscreteFourierTransform : Algorithm
    {
        public Signal InputFreqDomainSignal { get; set; }
        public Signal OutputTimeDomainSignal { get; set; }

        public override void Run()
        {
            int N = InputFreqDomainSignal.Frequencies.Count;
            // double Fs = InputSamplingFrequency;

            List<float> samples = new List<float>();

            for (int n = 0; n < N; n++)
            {
                Complex addtion = new Complex(0, 0);
                for (int k = 0; k < N; k++)
                {
                    double x = ((double)(2 * Math.PI * k * n) / (double)N);
                    Complex right_Mul = new Complex(Math.Cos(x), Math.Sin(x));
                    Complex left_Mul = Complex.FromPolarCoordinates(InputFreqDomainSignal.FrequenciesAmplitudes[k], InputFreqDomainSignal.FrequenciesPhaseShifts[k]);
                    Complex mul_Result = Complex.Multiply(left_Mul, right_Mul);
                    addtion = Complex.Add(addtion, mul_Result);
                }
                addtion = Complex.Divide(addtion, new Complex(N, 0));
                samples.Add((float)Math.Round(addtion.Real));
            }
            OutputTimeDomainSignal = new Signal(samples, false);
        }
    }
}
