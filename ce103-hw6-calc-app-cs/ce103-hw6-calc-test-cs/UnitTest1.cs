using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LesGraphingCalc;

namespace ce103_hw6_calc_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        public void CalculateTest1()
        {
            var expected = RPN.Calculate("50 + 20");
            var actual = 70;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest2()
        {
            var expected = RPN.Calculate("50 - 20");
            var actual = 30;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void CalculateTest3()
        {
            var expected = RPN.Calculate("sqrt(9");
            var actual = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest4()
        {
            var expected = RPN.Calculate("ln(e^2");
            var actual = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest5()
        {
            var expected = RPN.Calculate("lg(100");
            var actual = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest6()
        {
            var expected = RPN.Calculate(" %10");
            var actual = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest7()
        {
            var expected = RPN.Calculate(" !5");
            var actual = 120;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest8()
        {
            var expected = RPN.Calculate(" 20 * 5");
            var actual = 100;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest9()
        {
            var expected = RPN.Calculate(" 20 / 5");
            var actual = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest10()
        {
            var expected = RPN.Calculate(" 2^6");
            var actual = 64;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest11()
        {
            var expected = RPN.Calculate(" 2^3");
            var actual = 8;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest12()
        {
            var expected = RPN.Calculate(" 0^z");
            var actual = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest13()
        {
            var expected = RPN.Calculate("(1/300");
            var actual = 0.03;
            Assert.AreEqual(expected, actual);
        }
    }
}
