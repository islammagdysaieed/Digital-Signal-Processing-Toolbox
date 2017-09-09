using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPAlgorithms.DataStructures;
using System.Numerics;
namespace DSPAlgorithms.Algorithms
{
    public class InverseFastFourierTransform : Algorithm
    {
        public Signal InputFreqDomainSignal { get; set; }
        public Signal OutputTimeDomainSignal { get; set; }

        public override void Run()
        {
            int N = InputFreqDomainSignal.Frequencies.Count;
            
            List<Complex> inputFreq = new List<Complex>();
            for (int k = 0; k < N; k++)
            {
                inputFreq.Add( Complex.FromPolarCoordinates(InputFreqDomainSignal.FrequenciesAmplitudes[k], 
                    InputFreqDomainSignal.FrequenciesPhaseShifts[k]));
            }
            List<Complex> results = IFFT(inputFreq, N);
            List<float> samples = new List<float>();           
            for (int n = 0; n < N; n++)
            {
                results[n] = Complex.Divide(results[n], new Complex(N, 0));
                samples.Add((float)Math.Round(results[n].Real));
            }
            OutputTimeDomainSignal = new Signal(samples, false);
        }
        private List<Complex> IFFT(List<Complex> x, int N)
        {
            if (N == 2)
            {
                List<Complex> ret = new List<Complex>();
                ret.Add(x[0] + x[1]);
                ret.Add(x[0] - x[1]);
                return ret;
            }
            else
            {
                List<Complex> L1 = new List<Complex>();
                for (int i = 0; i < x.Count; i += 2)
                    L1.Add(x[i]);
                List<Complex> L2 = new List<Complex>();
                for (int i = 1; i < x.Count; i += 2)
                    L2.Add(x[i]);
                List<Complex> fft_1 = new List<Complex>();
                List<Complex> fft_2 = new List<Complex>();
                fft_1 = IFFT(L1, N / 2);
                fft_2 = IFFT(L2, N / 2);
                List<Complex> returnList = new List<Complex>(N);
                for (int k = 0; k <= N; k++) returnList.Add(new Complex(0, 0));
                for (int k = 0; k <= N / 2 - 1; k++)
                {
                    double val = ((double)(2 * Math.PI * k) / (double)N);
                    Complex W = new Complex(Math.Cos(val), Math.Sin(val));

                    returnList[k] = butterflyTop(fft_1[k], fft_2[k], W);
                    returnList[k + N / 2] = butterflyDown(fft_1[k], fft_2[k], W);
                }
                return returnList;
            }
        }
        Complex butterflyTop(Complex X1, Complex X2, Complex W)
        {
            Complex Mul = Complex.Multiply(X2, W);
            Complex res = Complex.Add(X1, Mul);
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
