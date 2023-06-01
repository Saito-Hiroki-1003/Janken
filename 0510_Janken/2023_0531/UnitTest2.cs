using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _0510_Janken;

namespace _2023_0531
{
    [TestClass]
    public class Janken_JudgeUnitTest2
    {
        Janken_Judge jankenJudge = new Janken_Judge();

        [TestMethod] public void TestMethod2()
        {
            int exp = 3; 
            int winOrLose = jankenJudge.Judge(1, 1);
            Assert.AreEqual(winOrLose , exp);
        }
    }
}
