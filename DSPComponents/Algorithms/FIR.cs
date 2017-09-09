using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPAlgorithms.DataStructures;

namespace DSPAlgorithms.Algorithms
{
    public class FIR : Algorithm
    {
        public Signal InputTimeDomainSignal { get; set; }
        public FILTER_TYPES InputFilterType { get; set; }
        public float InputFS { get; set; }
        public float? InputCutOffFrequency { get; set; }
        public float? InputF1 { get; set; }
        public float? InputF2 { get; set; }
        public float InputStopBandAttenuation { get; set; }
        public float InputTransitionBand { get; set; }//***
        public Signal OutputHn { get; set; }
        public Signal OutputYn { get; set; }
        int N;
        public override void Run()
        {
            List<double> W = GenerateWindow();
            List<double> H = GenerateIdealResponse();
            OutputHn = GenerateFilter(H, W);
            Convolution CN = new Convolution();
            CN.InputSignal1 = InputTimeDomainSignal;
            CN.InputSignal2 = OutputHn;
            CN.Run();
            OutputYn = CN.OutputConvolvedSignal;
        }
       Signal GenerateFilter(List<double> H ,List<double> W)
        {
          List<float>Hn = new List<float>();
          for (int i = 0; i <= (N - 1) / 2; i++)
          {
              Hn.Add((float)(H[i] * W[i]));
          }
          Signal tmp1 = new Signal(Hn,false);
          Folder fo = new Folder();
          fo.InputSignal = tmp1;
          fo.Run();
          Signal tmp2 = fo.OutputFoldedSignal;
          tmp2.Samples.RemoveAt(tmp2.Samples.Count - 1);
          tmp2.SamplesIndices.RemoveAt(tmp2.SamplesIndices.Count - 1);
          tmp2.SamplesIndices.AddRange(tmp1.SamplesIndices);
          tmp2.Samples.AddRange(tmp1.Samples);
          return tmp2;
        }
        List<double> GenerateIdealResponse()
        {
            List<double> h = new List<double>();
          
            for (int i = 0; i <= (N - 1) / 2; i++) //not tested yet
            {
                double val = ApplyResponseRule(i);
                h.Add(val);
            }
            return h;
        }
        double ApplyResponseRule(int n)
        {
            double DF = InputTransitionBand / (double)InputFS;
              double Fc = 0,F1 = 0 , F2 = 0;
              double Fcd,F1D,F2D,Wc,W1,W2;
              if (InputCutOffFrequency != null) Fc = (double)InputCutOffFrequency / (double)InputFS;
              if (InputF1 != null && InputF2 != null) { F1 = (double)InputF1 / (double)InputFS; F2 = (double)InputF2 / (double)InputFS; }
              
              
            switch (InputFilterType)
            {
                case FILTER_TYPES.LOW:
                     Fcd = Fc + (DF / 2);
                     Wc = Fcd * 2 * Math.PI;
                     if (n == 0) return 2 * Fcd;
                     return CommonRule(Fcd,Wc,n);
                case FILTER_TYPES.HIGH:
                     Fcd = Fc - (DF / 2);
                     Wc = Fcd * 2 * Math.PI;
                     if (n == 0) return 1- (2 * Fcd);
                     return -1 * CommonRule(Fcd, Wc, n);
                case FILTER_TYPES.BAND_PASS:
                     F1D = F1 - (DF / 2);
                     W1 = F1D * 2 * Math.PI;
                     F2D = F2 + (DF / 2);
                     W2 = F2D * 2 * Math.PI;
                     if (n == 0) return (2 * (F2D-F1D));
                     return CommonRule(F2D, W2, n) - CommonRule(F1D, W1, n);
                case FILTER_TYPES.BAND_STOP:
                     F1D = F1 + (DF / 2);
                     W1 = F1D * 2 * Math.PI;
                     F2D = F2 - (DF / 2);
                     W2 = F2D * 2 * Math.PI;
                     if (n == 0) return 1 - (2 * (F2D - F1D));
                     return CommonRule(F1D, W1, n) - CommonRule(F2D, W2, n);
            }
            return 0;
        }
        double CommonRule( double f,double w  ,int n)
        {
            double ret = 2 * f * (Math.Sin(n * w) / (n * w));
            return ret; 
        }
        List<double> GenerateWindow()
        {
            int RN = -1;
            if (InputStopBandAttenuation <= 21)
            {
                RN = 1;
                N = (int)((0.9 * InputFS) / InputTransitionBand); //fs ??  
            }
            else if (InputStopBandAttenuation <= 44)
            {
                RN = 2;
                N = (int)((3.1 * InputFS) / InputTransitionBand);
            }
            else if (InputStopBandAttenuation <= 53)
            {
                RN = 3;
                N = (int)((3.3 * InputFS) / InputTransitionBand);
            }
            else if (InputStopBandAttenuation <= 74)
            {
                RN = 4;
                N = (int)((5.5 * InputFS) / InputTransitionBand);
            }
            if (N % 2 == 0) N++;
            List<double> w = new List<double>();
            for (int i = 0; i <= (N - 1) / 2; i++) //not tested yet
            {
                double val = ApplyWindowRule(i, RN);
                w.Add(val);
            }
            return w;
        }
        double ApplyWindowRule(int n, int RN)
        {
            switch (RN)
            {
                case 1:
                    return 1;
                case 2:
                    return 0.5 + 0.5 * Math.Cos((2 * Math.PI * n) / N);
                case 3:
                    return 0.54 + 0.46 * Math.Cos((2 * Math.PI * n) / N);
                case 4:
                    return 0.42 + 0.5 * Math.Cos((2 * Math.PI * n) / (N - 1)) + 0.08 * Math.Cos((4 * Math.PI * n) / (N - 1));
            }
            return 0;
        }
    }
}
