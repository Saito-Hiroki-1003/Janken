using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _0510_Janken;

namespace _2023_0531
{
    [TestClass]
    public class Janken_InputUnitTest1
    {
        Janken_Input jankenInput = new Janken_Input();
        [TestMethod] public void TestMethod1()
        {
            int myHand = jankenInput.InputJudge(2);
            int max = 3;
            int min = 1;
            Assert.IsTrue(myHand >= min && myHand <= max);
        }
    }
}
