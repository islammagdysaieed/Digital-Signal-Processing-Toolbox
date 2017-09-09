using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSPAlgorithms.Algorithms;
using DSPAlgorithms.DataStructures;

namespace DSPComponentsUnitTest
{
    /// <summary>
    /// Summary description for CorrelationTestCases
    /// </summary>
    [TestClass]
    public class CorrelationTestCases
    {
        #region auto direct correlation
        [TestMethod]
        public void AutoDirectNonNormalizedNonPeriodicCorrelationTestMethod1()
        {
            DirectCorrelation dc = new DirectCorrelation();
            
            var expectedOutput = new Signal(new List<float>() {
                                           #region expectedOutput
                                             0.145421785526316f,
                                             0.138081417236842f,
                                             0.116893336710526f,
                                             0.0842478046052632f,
                                             0.0437965078947368f,
                                             2.04578947368297E-06f,
                                            -0.0424052639473684f,
                                            -0.0789912913157894f,
                                            -0.106129404078947f,
                                            -0.121395045789474f,
                                            -0.123797207894737f,
                                            -0.113823824605263f,
                                            -0.0933042086842105f,
                                            -0.0651154942105263f,
                                            -0.0327795488157895f,
                                            -8.52473684210641E-06f,
                                             0.0297398318421053f,
                                             0.0536414389473684f,
                                             0.0697769055263157f,
                                             0.0772691096052631f,
                                             0.0762819707894737f,
                                             0.0678935060526316f,
                                             0.0538717793421052f,
                                             0.0363920059210526f,
                                             0.0177368727631579f,
                                             1.97153947368421E-05f,
                                            -0.0150374419736842f,
                                            -0.026249842631579f,
                                            -0.0330314565789474f,
                                            -0.0353755215789474f,
                                            -0.0337678826315789f,
                                            -0.0290536638157895f,
                                            -0.0222810428947368f,
                                            -0.0145453471052632f,
                                            -0.0068530502631579f,
                                            -1.97076315789476E-05f,
                                             0.00539094657894737f,
                                             0.00908619631578947f,
                                             0.0110266622368421f,
                                             0.0113808013157895f,
                                             0.01046259f,
                                             0.00866362342105263f,
                                             0.00638948394736842f,
                                             0.00400771947368421f,
                                             0.00181188171052632f,
                                             2.79171052631575E-06f,
                                            -0.00131417105263158f,
                                            -0.00211892763157895f,
                                            -0.00245804868421053f,
                                            -0.00242200355263158f,
                                            -0.00212233302631579f,
                                            -0.00167188263157895f,
                                            -0.00116998842105263f,
                                            -0.000693406578947368f,
                                            -0.000292726184210526f,
                                             6.65802631578946E-06f,
                                             0.000200442105263158f,
                                             0.000299563815789474f,
                                             0.000323960263157895f,
                                             0.000296976973684211f,
                                             0.000240971447368421f,
                                             0.000174514078947368f,
                                             0.000110982236842105f,
                                             5.84151315789474E-05f,
                                             2.02028947368421E-05f,
                                            -3.73815789473684E-06f,
                                            -1.56878947368421E-05f,
                                            -1.89286842105263E-05f,
                                            -1.68118421052632E-05f,
                                            -1.22202631578947E-05f,
                                            -7.23144736842105E-06f,
                                            -3.09973684210526E-06f,
                                            -3.57894736842105E-07f,
                                             9.89473684210526E-07f,
                                             1.22552631578947E-06f,
                                             7.59473684210526E-07f
#endregion
                                                 }, false);

            
            dc.InputSignal1 = new Signal(new List<float>() {
                    #region input
                     0.0078f,
                     0.0070f,
                     0.0042f,
                    -0.0010f,
                    -0.0089f,
                    -0.0195f,
                    -0.0321f,
                    -0.0453f,
                    -0.0570f,
                    -0.0644f,
                    -0.0645f,
                    -0.0541f,
                    -0.0308f,
                     0.0065f,
                     0.0569f,
                     0.1168f,
                     0.1802f,
                     0.2385f,
                     0.2815f,
                     0.2985f,
                     0.2802f,
                     0.2203f,
                     0.1175f,
                    -0.0234f,
                    -0.1910f,
                    -0.3680f,
                    -0.5324f,
                    -0.6608f,
                    -0.7313f,
                    -0.7272f,
                    -0.6400f,
                    -0.4719f,
                    -0.2360f,
                     0.0441f,
                     0.3374f,
                     0.6095f,
                     0.8269f,
                     0.9624f,
                     0.9988f,
                     0.9313f,
                     0.7686f,
                     0.5314f,
                     0.2493f,
                    -0.0436f,
                    -0.3133f,
                    -0.5307f,
                    -0.6752f,
                    -0.7370f,
                    -0.7172f,
                    -0.6271f,
                    -0.4853f,
                    -0.3147f,
                    -0.1384f,
                     0.0227f,
                     0.1530f,
                     0.2430f,
                     0.2899f,
                     0.2967f,
                     0.2707f,
                     0.2220f,
                     0.1611f,
                     0.0979f,
                     0.0404f,
                    -0.0062f,
                    -0.0393f,
                    -0.0585f,
                    -0.0654f,
                    -0.0628f,
                    -0.0537f,
                     0.0070f,
                    -0.0413f,
                    -0.0281f,
                    -0.0160f,
                    -0.0062f,
                     0.0009f,
                     0.0053f,
                     0.0074f
#endregion
                   }, false);
            
            dc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, dc.OutputNonNormalizedCorrelation));
        }

        [TestMethod]
        public void AutoDirectNonNormalizedPeriodicCorrelationTestMethod1()
        {
            DirectCorrelation dc = new DirectCorrelation();

            var expectedOutput = new Signal(new List<float>() {
                                           #region expectedOutput
                                              0.145421785526316f,
                                              0.138082176710526f,
                                              0.116894562236842f,
                                              0.0842487940789474f,
                                              0.04379615f,
                                             -1.05394736842229E-06f,
                                             -0.0424124953947368f,
                                             -0.0790035115789473f,
                                             -0.106146215921053f,
                                             -0.121413974473684f,
                                             -0.123812895789474f,
                                             -0.113827562763158f,
                                             -0.0932840057894737f,
                                             -0.0650570790789474f,
                                             -0.0326685665789474f,
                                              0.000165989342105262f,
                                              0.0299808032894737f,
                                              0.0539384159210526f,
                                              0.0701008657894736f,
                                              0.0775686734210526f,
                                              0.0764824128947369f,
                                              0.0679001640789474f,
                                              0.0535790531578947f,
                                              0.0356985993421053f,
                                              0.0165668843421053f,
                                             -0.00165216723684211f,
                                             -0.017159775f,
                                             -0.0286718461842105f,
                                             -0.0354895052631579f,
                                             -0.0374944492105263f,
                                             -0.0350820536842105f,
                                             -0.0290508721052632f,
                                             -0.0204691611842105f,
                                             -0.010537627631579f,
                                             -0.000463566315789475f,
                                              0.00864391578947368f,
                                              0.0158535365789474f,
                                              0.0204669976315789f,
                                              0.0220533244736842f,
                                              0.0204669976315789f,
                                              0.0158535365789474f,
                                              0.00864391578947368f,
                                             -0.000463566315789471f,
                                             -0.010537627631579f,
                                             -0.0204691611842105f,
                                             -0.0290508721052632f,
                                             -0.0350820536842105f,
                                             -0.0374944492105263f,
                                             -0.0354895052631579f,
                                             -0.0286718461842105f,
                                             -0.017159775f,
                                             -0.00165216723684211f,
                                              0.0165668843421053f,
                                              0.0356985993421053f,
                                              0.0535790531578947f,
                                              0.0679001640789474f,
                                              0.0764824128947369f,
                                              0.0775686734210526f,
                                              0.0701008657894736f,
                                              0.0539384159210526f,
                                              0.0299808032894737f,
                                              0.000165989342105263f,
                                             -0.0326685665789474f,
                                             -0.0650570790789474f,
                                             -0.0932840057894737f,
                                             -0.113827562763158f,
                                             -0.123812895789474f,
                                             -0.121413974473684f,
                                             -0.106146215921053f,
                                             -0.0790035115789473f,
                                             -0.0424124953947368f,
                                             -1.05394736841954E-06f,
                                              0.04379615f,
                                              0.0842487940789474f,
                                              0.116894562236842f,
                                              0.138082176710526f

#endregion
                                                 }, true);


            dc.InputSignal1 = new Signal(new List<float>() {
                      #region input
                     0.0078f,
                     0.0070f,
                     0.0042f,
                    -0.0010f,
                    -0.0089f,
                    -0.0195f,
                    -0.0321f,
                    -0.0453f,
                    -0.0570f,
                    -0.0644f,
                    -0.0645f,
                    -0.0541f,
                    -0.0308f,
                     0.0065f,
                     0.0569f,
                     0.1168f,
                     0.1802f,
                     0.2385f,
                     0.2815f,
                     0.2985f,
                     0.2802f,
                     0.2203f,
                     0.1175f,
                    -0.0234f,
                    -0.1910f,
                    -0.3680f,
                    -0.5324f,
                    -0.6608f,
                    -0.7313f,
                    -0.7272f,
                    -0.6400f,
                    -0.4719f,
                    -0.2360f,
                     0.0441f,
                     0.3374f,
                     0.6095f,
                     0.8269f,
                     0.9624f,
                     0.9988f,
                     0.9313f,
                     0.7686f,
                     0.5314f,
                     0.2493f,
                    -0.0436f,
                    -0.3133f,
                    -0.5307f,
                    -0.6752f,
                    -0.7370f,
                    -0.7172f,
                    -0.6271f,
                    -0.4853f,
                    -0.3147f,
                    -0.1384f,
                     0.0227f,
                     0.1530f,
                     0.2430f,
                     0.2899f,
                     0.2967f,
                     0.2707f,
                     0.2220f,
                     0.1611f,
                     0.0979f,
                     0.0404f,
                    -0.0062f,
                    -0.0393f,
                    -0.0585f,
                    -0.0654f,
                    -0.0628f,
                    -0.0537f,
                     0.0070f,
                    -0.0413f,
                    -0.0281f,
                    -0.0160f,
                    -0.0062f,
                     0.0009f,
                     0.0053f,
                     0.0074f
#endregion
                   }, true);

            dc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, dc.OutputNonNormalizedCorrelation));
        
        }

        [TestMethod]
        public void AutoDirectNormalizedNonPeriodicCorrelationTestMethod1()
        {

            DirectCorrelation dc = new DirectCorrelation();

            var expectedOutput = new Signal(new List<float>() {
                                           #region expectedOutput
                                              1f,
                                              0.949523599487469f,
                                              0.803822730462714f,
                                              0.579334136906313f,
                                              0.301168822375732f,
                                              1.40679710834163E-05f,
                                             -0.291601865524438f,
                                             -0.54318746692527f,
                                             -0.729804022793696f,
                                             -0.834778952480306f,
                                             -0.851297537344116f,
                                             -0.782715080779044f,
                                             -0.641610941211597f,
                                             -0.447769871445726f,
                                             -0.225410166001968f,
                                             -5.862076862317E-05f,
                                              0.20450740399363f,
                                              0.36886797086989f,
                                              0.47982429368321f,
                                              0.531344800406679f,
                                              0.524556692199805f,
                                              0.466873005354108f,
                                              0.370451917827377f,
                                              0.250251403456101f,
                                              0.121968470535305f,
                                              0.000135573873374525f,
                                             -0.10340570306753f,
                                             -0.180508322990084f,
                                             -0.227142422020186f,
                                             -0.243261499306414f,
                                             -0.232206491684619f,
                                             -0.199788936098105f,
                                             -0.15321667805203f,
                                             -0.100021788706693f,
                                             -0.0471253343393845f,
                                             -0.000135520489640675f,
                                              0.0370711070520573f,
                                              0.0624816720748159f,
                                              0.075825380612224f,
                                              0.0782606352590134f,
                                              0.0719465103672975f,
                                              0.0595758289564176f,
                                              0.0439375979619791f,
                                              0.0275592784064597f,
                                              0.0124594929430187f,
                                              1.91973335784036E-05f,
                                             -0.00903696133199908f,
                                             -0.0145709091929386f,
                                             -0.0169028916493788f,
                                             -0.0166550255442524f,
                                             -0.0145943265559185f,
                                             -0.0114967824492596f,
                                             -0.00804548243454835f,
                                             -0.00476824415570037f,
                                             -0.00201294588119023f,
                                              4.57842426545135E-05f,
                                              0.001378349911863f,
                                              0.00205996518819571f,
                                              0.0022277285482736f,
                                              0.00204217664230556f,
                                              0.00165705190935655f,
                                              0.00120005457446256f,
                                              0.000763174763949117f,
                                              0.000401694501051058f,
                                              0.000138926190898585f,
                                             -2.57056250630369E-05f,
                                             -0.000107878573214212f,
                                             -0.000130164020074564f,
                                             -0.000115607452105041f,
                                             -8.40332355545403E-05f,
                                             -4.97274004871329E-05f,
                                             -2.13154915605429E-05f,
                                             -2.46108061145584E-06f,
                                              6.80416404343673E-06f,
                                              8.42739147613959E-06f,
                                              5.22255782695702E-06f
#endregion
                                                 }, false);


            dc.InputSignal1 = new Signal(new List<float>() {
                      #region input
                     0.0078f,
                     0.0070f,
                     0.0042f,
                    -0.0010f,
                    -0.0089f,
                    -0.0195f,
                    -0.0321f,
                    -0.0453f,
                    -0.0570f,
                    -0.0644f,
                    -0.0645f,
                    -0.0541f,
                    -0.0308f,
                     0.0065f,
                     0.0569f,
                     0.1168f,
                     0.1802f,
                     0.2385f,
                     0.2815f,
                     0.2985f,
                     0.2802f,
                     0.2203f,
                     0.1175f,
                    -0.0234f,
                    -0.1910f,
                    -0.3680f,
                    -0.5324f,
                    -0.6608f,
                    -0.7313f,
                    -0.7272f,
                    -0.6400f,
                    -0.4719f,
                    -0.2360f,
                     0.0441f,
                     0.3374f,
                     0.6095f,
                     0.8269f,
                     0.9624f,
                     0.9988f,
                     0.9313f,
                     0.7686f,
                     0.5314f,
                     0.2493f,
                    -0.0436f,
                    -0.3133f,
                    -0.5307f,
                    -0.6752f,
                    -0.7370f,
                    -0.7172f,
                    -0.6271f,
                    -0.4853f,
                    -0.3147f,
                    -0.1384f,
                     0.0227f,
                     0.1530f,
                     0.2430f,
                     0.2899f,
                     0.2967f,
                     0.2707f,
                     0.2220f,
                     0.1611f,
                     0.0979f,
                     0.0404f,
                    -0.0062f,
                    -0.0393f,
                    -0.0585f,
                    -0.0654f,
                    -0.0628f,
                    -0.0537f,
                     0.0070f,
                    -0.0413f,
                    -0.0281f,
                    -0.0160f,
                    -0.0062f,
                     0.0009f,
                     0.0053f,
                     0.0074f
#endregion
                   }, false);

            dc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, dc.OutputNormalizedCorrelation));
        
        }

        [TestMethod]
        public void AutoDirectNormalizedPeriodicCorrelationTestMethod1()
        {
            DirectCorrelation dc = new DirectCorrelation();

            var expectedOutput = new Signal(new List<float>() {
                                           #region expectedOutput
                                             1,
                                             0.949528822045295f,
                                             0.80383115785419f,
                                             0.579340941070357f,
                                             0.301166361295121f,
                                            -7.24752047712662E-06f,
                                            -0.291651592924925f,
                                            -0.543271500160825f,
                                            -0.729919630245801f,
                                            -0.834909116500381f,
                                            -0.85140541591733f,
                                            -0.782740786404107f,
                                            -0.641472015020699f,
                                            -0.447368176944675f,
                                            -0.224646991238019f,
                                             0.00114143380583939f,
                                             0.206164455902986f,
                                             0.370910147512195f,
                                             0.482052022231483f,
                                             0.533404765594874f,
                                             0.525935042111668f,
                                             0.466918789596762f,
                                             0.368438971946187f,
                                             0.245483159300401f,
                                             0.113922988100757f,
                                            -0.0113612085758851f,
                                            -0.118000029623448f,
                                            -0.197163348534336f,
                                            -0.244045313669564f,
                                            -0.257832408499353f,
                                            -0.241243453016618f,
                                            -0.199769738764527f,
                                            -0.140757185109011f,
                                            -0.0724625103002331f,
                                            -0.00318773637740534f,
                                             0.0594403084667769f,
                                             0.109017617419355f,
                                             0.140742307333829f,
                                             0.151650761224448f,
                                             0.140742307333829f,
                                             0.109017617419355f,
                                             0.0594403084667769f,
                                            -0.00318773637740532f,
                                            -0.0724625103002331f,
                                            -0.140757185109011f,
                                            -0.199769738764527f,
                                            -0.241243453016618f,
                                            -0.257832408499353f,
                                            -0.244045313669564f,
                                            -0.197163348534336f,
                                            -0.118000029623448f,
                                            -0.0113612085758851f,
                                             0.113922988100757f,
                                             0.245483159300401f,
                                             0.368438971946187f,
                                             0.466918789596762f,
                                             0.525935042111668f,
                                             0.533404765594874f,
                                             0.482052022231484f,
                                             0.370910147512195f,
                                             0.206164455902986f,
                                             0.00114143380583939f,
                                            -0.224646991238019f,
                                            -0.447368176944675f,
                                            -0.641472015020699f,
                                            -0.782740786404107f,
                                            -0.85140541591733f,
                                            -0.834909116500381f,
                                            -0.729919630245801f,
                                            -0.543271500160825f,
                                            -0.291651592924925f,
                                            -7.24752047710771E-06f,
                                             0.301166361295121f,
                                             0.579340941070357f,
                                             0.80383115785419f,
                                             0.949528822045296f
#endregion
                                                 }, true);


            dc.InputSignal1 = new Signal(new List<float>() {
                      #region input
                     0.0078f,
                     0.0070f,
                     0.0042f,
                    -0.0010f,
                    -0.0089f,
                    -0.0195f,
                    -0.0321f,
                    -0.0453f,
                    -0.0570f,
                    -0.0644f,
                    -0.0645f,
                    -0.0541f,
                    -0.0308f,
                     0.0065f,
                     0.0569f,
                     0.1168f,
                     0.1802f,
                     0.2385f,
                     0.2815f,
                     0.2985f,
                     0.2802f,
                     0.2203f,
                     0.1175f,
                    -0.0234f,
                    -0.1910f,
                    -0.3680f,
                    -0.5324f,
                    -0.6608f,
                    -0.7313f,
                    -0.7272f,
                    -0.6400f,
                    -0.4719f,
                    -0.2360f,
                     0.0441f,
                     0.3374f,
                     0.6095f,
                     0.8269f,
                     0.9624f,
                     0.9988f,
                     0.9313f,
                     0.7686f,
                     0.5314f,
                     0.2493f,
                    -0.0436f,
                    -0.3133f,
                    -0.5307f,
                    -0.6752f,
                    -0.7370f,
                    -0.7172f,
                    -0.6271f,
                    -0.4853f,
                    -0.3147f,
                    -0.1384f,
                     0.0227f,
                     0.1530f,
                     0.2430f,
                     0.2899f,
                     0.2967f,
                     0.2707f,
                     0.2220f,
                     0.1611f,
                     0.0979f,
                     0.0404f,
                    -0.0062f,
                    -0.0393f,
                    -0.0585f,
                    -0.0654f,
                    -0.0628f,
                    -0.0537f,
                     0.0070f,
                    -0.0413f,
                    -0.0281f,
                    -0.0160f,
                    -0.0062f,
                     0.0009f,
                     0.0053f,
                     0.0074f
#endregion
                   }, true);

            dc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, dc.OutputNormalizedCorrelation));

        }


        [TestMethod]
        public void AutoDirectNonNormalizedNonPeriodicCorrelationTestMethod2()
        {
            DirectCorrelation dc = new DirectCorrelation();

            dc.InputSignal1 = UnitTestUtitlities.LoadSignal("TestingSignals/AutoCorrelationNonPeriodic_TestCase.ds");
            Signal expectedOutput = UnitTestUtitlities.LoadSignal("TestingSignals/AutoCorrelationNonNormalizedNonPeriodic_TestCase.ds");

            dc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, dc.OutputNonNormalizedCorrelation));
        
        }

        [TestMethod]
        public void AutoDirectNonNormalizedPeriodicCorrelationTestMethod2()
        {
            DirectCorrelation dc = new DirectCorrelation();

            dc.InputSignal1 = UnitTestUtitlities.LoadSignal("TestingSignals/AutoCorrelationPeriodic_TestCase.ds");
            Signal expectedOutput = UnitTestUtitlities.LoadSignal("TestingSignals/AutoCorrelationNonNormalizedPeriodic_TestCase.ds");

            dc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, dc.OutputNonNormalizedCorrelation));
        
        }

        [TestMethod]
        public void AutoDirectNormalizedNonPeriodicCorrelationTestMethod2()
        {

            DirectCorrelation dc = new DirectCorrelation();

            dc.InputSignal1 = UnitTestUtitlities.LoadSignal("TestingSignals/AutoCorrelationNonPeriodic_TestCase.ds");
            Signal expectedOutput = UnitTestUtitlities.LoadSignal("TestingSignals/AutoCorrelationNormalizedNonPeriodic_TestCase.ds");

            dc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, dc.OutputNonNormalizedCorrelation));
        
       
        }

        [TestMethod]
        public void AutoDirectNormalizedPeriodicCorrelationTestMethod2()
        {

            DirectCorrelation dc = new DirectCorrelation();

            dc.InputSignal1 = UnitTestUtitlities.LoadSignal("TestingSignals/AutoCorrelationPeriodic_TestCase.ds");
            Signal expectedOutput = UnitTestUtitlities.LoadSignal("TestingSignals/AutoCorrelationNormalizedPeriodic_TestCase.ds");

            dc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, dc.OutputNonNormalizedCorrelation));
        
       
        }

        #endregion auto direct correlation

        #region auto fast correlation
        [TestMethod]
        public void AutoFastNormalizedCorrelationTestMethod1()
        {
            FastCorrelation fc = new FastCorrelation();

            var expectedOutput = new Signal(new List<float>() { 1, 0.5f, 0, 0.5f}, false);

            fc.InputSignal1 = new Signal(new List<float>() { 1, 0, 0, 1 }, false);

            fc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, fc.OutputNormalizedCorrelation));
        }
       
        [TestMethod]
        public void AutoFastNonNormalizedCorrelationTestMethod1()
        {
            FastCorrelation fc = new FastCorrelation();

            var expectedOutput = new Signal(new List<float>() { 0.5f, 0.25f, 0, 0.25f }, false);

            fc.InputSignal1 = new Signal(new List<float>() { 1, 0, 0, 1 }, false);

            fc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, fc.OutputNonNormalizedCorrelation));
        }

        [TestMethod]
        public void AutoFastNormalizedCorrelationTestMethod2()
        {
            FastCorrelation fc = new FastCorrelation();
            var expectedOutput = UnitTestUtitlities.LoadSignal("TestingSignals/FastAutoCorrelationNormalized_TestCase.ds");
            fc.InputSignal1 = UnitTestUtitlities.LoadSignal("TestingSignals/FastAutoCorrelation.ds");
            fc.Run();
            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, fc.OutputNonNormalizedCorrelation));
        }

        [TestMethod]
        public void AutoFastNonNormalizedCorrelationTestMethod2()
        {
            FastCorrelation fc = new FastCorrelation();
            var expectedOutput = UnitTestUtitlities.LoadSignal("TestingSignals/FastAutoCorrelationNonNormalized_TestCase.ds");
            fc.InputSignal1 = UnitTestUtitlities.LoadSignal("TestingSignals/FastAutoCorrelation.ds");
            fc.Run();
            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, fc.OutputNonNormalizedCorrelation));
        }

        #endregion 
        
        #region cross direct correlation

        [TestMethod]
        public void CrossDirectNonNormalizedNonPeriodicCorrelationTestMethod1()
        {
            DirectCorrelation fc = new DirectCorrelation();

            var expectedOutput = new Signal(new List<float>() { 4.83333333333333f, 2.83333333333333f, 2, 0, 0, 0 }, false);

            fc.InputSignal1 = new Signal(new List<float>() { 4, 3, 1, 6 }, false);
            fc.InputSignal2 = new Signal(new List<float>() { 5, 2, 3}, false);

            fc.Run();
            //islam
            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, fc.OutputNonNormalizedCorrelation));
        }

        [TestMethod]
        public void CrossDirectNonNormalizedPeriodicCorrelationTestMethod1()
        {
            DirectCorrelation fc = new DirectCorrelation();

            var expectedOutput = new Signal(new List<float>() { 4.83333333333333f, 2.83333333333333f, 2, 5, 2.83333333333333f, 5.83333333333333f }, false);

            fc.InputSignal1 = new Signal(new List<float>() { 4, 3, 1, 6 }, true);
            fc.InputSignal2 = new Signal(new List<float>() { 5, 2, 3 }, true);

            fc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, fc.OutputNormalizedCorrelation));
        }

        [TestMethod]
        public void CrossDirectNormalizedNonPeriodicCorrelationTestMethod1()
        {
            DirectCorrelation fc = new DirectCorrelation();

            var expectedOutput = new Signal(new List<float>() { 0.597462091486989f, 0.35023639845789f, 0.247225693029099f, 0, 0, 0 }, false);

            fc.InputSignal1 = new Signal(new List<float>() { 4, 3, 1, 6 }, false);
            fc.InputSignal2 = new Signal(new List<float>() { 5, 2, 3 }, false);

            fc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, fc.OutputNormalizedCorrelation));
        }

        [TestMethod]
        public void CrossDirectNormalizedPeriodicCorrelationTestMethod1()
        {
            DirectCorrelation fc = new DirectCorrelation();

            var expectedOutput = new Signal(new List<float>() {0.597462091486989f, 0.35023639845789f, 0.247225693029099f, 0.618064232572747f, 0.35023639845789f, 0.721074938001538f}, false);

            fc.InputSignal1 = new Signal(new List<float>() { 4, 3, 1, 6 }, true);
            fc.InputSignal2 = new Signal(new List<float>() { 5, 2, 3 }, true);

            fc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, fc.OutputNormalizedCorrelation));
        }

        [TestMethod]
        public void CrossDirectNonNormalizedNonPeriodicCorrelationTestMethod2()
        {
            DirectCorrelation fc = new DirectCorrelation();

            var expectedOutput = new Signal(new List<float>() { 0.714285714285714f, 0.857142857142857f, 1.14285714285714f, 0, 0, 0, 0 }, false);

            fc.InputSignal1 = new Signal(new List<float>() { 2, 1 , 0, 0, 3 }, false);
            fc.InputSignal2 = new Signal(new List<float>() { 2, 1, 4 }, false);

            fc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, fc.OutputNonNormalizedCorrelation));
        }

        [TestMethod]
        public void CrossDirectNonNormalizedPeriodicCorrelationTestMethod2()
        {
            DirectCorrelation fc = new DirectCorrelation();

            var expectedOutput = new Signal(new List<float>() { 0.714285714285714f, 0.857142857142857f, 1.14285714285714f, 0.857142857142857f, 0.428571428571429f, 1.71428571428571f, 0.285714285714286f }, false);

            fc.InputSignal1 = new Signal(new List<float>() { 2, 1, 0, 0, 3 }, true);
            fc.InputSignal2 = new Signal(new List<float>() { 2, 1, 4 }, true); fc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, fc.OutputNormalizedCorrelation));
        }

        [TestMethod]
        public void CrossDirectNormalizedNonPeriodicCorrelationTestMethod2()
        {
            DirectCorrelation fc = new DirectCorrelation();

            var expectedOutput = new Signal(new List<float>() { 0.291605921759902f, 0.349927106111883f, 0.466569474815843f, 0, 0, 0, 0 }, false);
            
            fc.InputSignal1 = new Signal(new List<float>() { 2, 1, 0, 0, 3 }, false);
            fc.InputSignal2 = new Signal(new List<float>() { 2, 1, 4 }, false); fc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, fc.OutputNormalizedCorrelation));
        }

        [TestMethod]
        public void CrossDirectNormalizedPeriodicCorrelationTestMethod2()
        {
            DirectCorrelation fc = new DirectCorrelation();

            var expectedOutput = new Signal(new List<float>() { 0.291605921759902f, 0.349927106111883f, 0.466569474815843f, 0.349927106111883f, 0.174963553055941f, 0.699854212223765f, 0.116642368703961f }, false);

            fc.InputSignal1 = new Signal(new List<float>() { 2, 1, 0, 0, 3 }, true);
            fc.InputSignal2 = new Signal(new List<float>() { 2, 1, 4 }, true);
            
            fc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, fc.OutputNormalizedCorrelation));
        }

        #endregion 
        
        #region cross fast correlation
        [TestMethod]
        public void CrossFastNormalizedCorrelationTestMethod1()
        {
            FastCorrelation fc = new FastCorrelation();

            var expectedOutput = new Signal(new List<float>() { 0.966724839388562f, 0.735255511647639f, 0.680792140414481f, 0.857798096922246f }, false);

            fc.InputSignal1 = new Signal(new List<float>() { 4, 3, 1, 6 }, false);
            fc.InputSignal1 = new Signal(new List<float>() { 5, 2, 3, 7 }, false);

            fc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, fc.OutputNormalizedCorrelation));
        }

        [TestMethod]
        public void CrossFastNonNormalizedCorrelationTestMethod1()
        {
            FastCorrelation fc = new FastCorrelation();

            var expectedOutput = new Signal(new List<float>() { 17.75f, 13.5f, 12.5f, 15.75f }, false);

            fc.InputSignal1 = new Signal(new List<float>() { 4, 3, 1, 6 }, false);
            fc.InputSignal1 = new Signal(new List<float>() { 5, 2, 3, 7 }, false);

            fc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, fc.OutputNormalizedCorrelation));

        }

        [TestMethod]
        public void CrossFastNormalizedCorrelationTestMethod2()
        {
            FastCorrelation fc = new FastCorrelation();

            fc.InputSignal1 = UnitTestUtitlities.LoadSignal("TestingSignals/CrossCorrelation_Signal1.ds");
            fc.InputSignal2 = UnitTestUtitlities.LoadSignal("TestingSignals/CrossCorrelation_Signal2.ds");

            Signal expectedOutput = UnitTestUtitlities.LoadSignal("TestingSignals/CrossCorrelationNormalized_TestCase.ds");

            fc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, fc.OutputNormalizedCorrelation));
        }

        [TestMethod]
        public void CrossFastNonNormalizedCorrelationTestMethod2()
        {
            FastCorrelation fc = new FastCorrelation();

            fc.InputSignal1 = UnitTestUtitlities.LoadSignal("TestingSignals/CrossCorrelation_Signal1.ds");
            fc.InputSignal2 = UnitTestUtitlities.LoadSignal("TestingSignals/CrossCorrelation_Signal2.ds");

            Signal expectedOutput = UnitTestUtitlities.LoadSignal("TestingSignals/CrossCorrelationNonNormalized_TestCase.ds");

            fc.Run();

            Assert.IsTrue(UnitTestUtitlities.SignalsSamplesAreEqual(expectedOutput.Samples, fc.OutputNormalizedCorrelation));
        }

        #endregion
    }
}
