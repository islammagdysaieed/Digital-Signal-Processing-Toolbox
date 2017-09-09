using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPAlgorithms.DataStructures;
using System.Numerics;
namespace DSPAlgorithms.Algorithms
{
    public class FastFourierTransform : Algorithm
    {
        public Signal InputTimeDomainSignal { get; set; }
        public int InputSamplingFrequency { get; set; }
        public Signal OutputFreqDomainSignal { get; set; }
        public override void Run()
        {
            double Ts = (double)1 / (double)InputSamplingFrequency;
            List<Complex> Results = FFT(InputTimeDomainSignal.Samples, InputTimeDomainSignal.Samples.Count);
            List<float> freqs = new List<float>();
            List<float> phases = new List<float>();
            List<float> Amps = new List<float>();
            for (int k = 0; k < InputTimeDomainSignal.Samples.Count; k++)
            {     
                freqs.Add((float)(k * Ts));
                phases.Add((float)Results[k].Phase);
                Amps.Add((float)Results[k].Magnitude);
            }
            OutputFreqDomainSignal = new Signal(false, freqs, Amps, phases);  
          
        }

        private List<Complex> FFT(List<float> x, int N)
        {
            if (N == 2)
            {
                List<Complex> ret = new List<Complex>();
                ret.Add( new Complex( x[0] + x[1],0));
                ret.Add(new Complex(x[0] - x[1], 0));
                return ret;
            }
            else
            {
                List<float> L1 = new List<float>();
                for (int i = 0; i < x.Count; i += 2)
                    L1.Add(x[i]);
                List<float> L2 = new List<float>();
                for (int i = 1; i < x.Count; i += 2)
                    L2.Add(x[i]);
                List<Complex> fft_1 = FFT(L1, N / 2);
                List<Complex> fft_2 = FFT(L2, N / 2);
                List<Complex> returnList = new List<Complex>();
                for (int k = 0; k <= N; k++) returnList.Add(new Complex(0, 0));
                for( int k = 0 ;k <= N/2-1;k++)
                {
                    double val = ((double)(2 * Math.PI * k) / (double)N);
                    Complex W = new Complex(Math.Cos(val), -1*Math.Sin(val));

                    returnList[k] = butterflyTop(fft_1[k], fft_2[k], W);
                    returnList[k+N/2] = butterflyDown(fft_1[k], fft_2[k], W);
                }
                return returnList;
                }
            }


        Complex butterflyTop(Complex X1, Complex X2, Complex W)
        {
            Complex Mul = Complex.Multiply(X2,W);
            Complex res = Complex.Add(X1 ,Mul);
            return res;
        }

        Complex butterflyDown(Complex X1, Complex X2, Complex W)
        {
            Complex Mul = Complex.Multiply(X2, W);
            Complex res = Complex.Subtract(X1, Mul);
            return res;
        }
    
}
}