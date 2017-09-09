﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSPAlgorithms.Algorithms;
using System.Collections.Generic;

namespace DSPComponentsUnitTest
{
    [TestClass]
    public class DFTTestCases
    {
        [TestMethod]
        public void TestMethod1()
        {
            FastFourierTransform DFT = new FastFourierTransform();
            // test case 1 ..
            var sig1 = UnitTestUtitlities.LoadSignal("TestingSignals/DFT_Signal1.ds");

            DFT.InputTimeDomainSignal = sig1;
            DFT.InputSamplingFrequency = 360;

            List<float> amplitude =  new List<float>{ 64, 20.9050074380220f, 11.3137084989848f, 8.65913760233915f, 8, 8.65913760233915f, 11.3137084989848f, 20.9050074380220f };
            List<float> phase = new List<float> { 0, 1.96349540849362f, 2.35619449019235f, 2.74889357189107f, 3.14159265358979f, -2.74889357189107f, -2.35619449019235f, -1.96349540849362f };

            DFT.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(amplitude, DFT.OutputFreqDomainSignal.FrequenciesAmplitudes) && UnitTestUtitlities.SignalsSamplesAreEqual(phase, DFT.OutputFreqDomainSignal.FrequenciesPhaseShifts));
       
        }

        [TestMethod]
        public void TestMethod2()
        {
            InverseFastFourierTransform IDFT = new InverseFastFourierTransform();
            // test case 2
            var FrequenciesAmplitudes = new List<float> { 64, 20.9050074380220f, 11.3137084989848f, 8.65913760233915f, 8, 8.65913760233915f, 11.3137084989848f, 20.9050074380220f };
            var FrequenciesPhaseShifts = new List<float> { 0, 1.96349540849362f, 2.35619449019235f, 2.74889357189107f, 3.14159265358979f, -2.74889357189107f, -2.35619449019235f, -1.96349540849362f };
            var Frequencies = new List<float> { 0, 1, 2, 3, 4, 5, 6, 7};

            IDFT.InputFreqDomainSignal = new DSPAlgorithms.DataStructures.Signal(false, Frequencies, FrequenciesAmplitudes, FrequenciesPhaseShifts);

            IDFT.Run();
            
            List<float> outPutSamples = new List<float>{1 , 3 , 5 , 7 , 9 , 11 , 13 , 15};

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(outPutSamples, IDFT.OutputTimeDomainSignal.Samples) );
            
        }
    }
}
