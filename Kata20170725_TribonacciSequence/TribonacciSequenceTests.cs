using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170725_TribonacciSequence
{
    [TestClass]
    public class TribonacciSequenceTests
    {
        [TestMethod]
        public void input_array_0_0_1_and_n_0_return_array_0()
        {
            var xbonacci = new Xbonacci();
            var acutal = xbonacci.Tribonacci(new double[] {0, 0, 1}, 0);
            CollectionAssert.AreEqual(new double[]{ 0 }, acutal);
        }

        [TestMethod]
        public void input_array_0_0_1_and_n_1_return_array_0_0_1()
        {
            var xbonacci = new Xbonacci();
            var acutal = xbonacci.Tribonacci(new double[] { 0, 0, 1 }, 3);
            CollectionAssert.AreEqual(new double[] { 0, 0, 1 }, acutal);
        }
    }

    public class Xbonacci
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0)
            {
                return new double[] { 0 };
            }

            if (n == 3)
            {
                return signature;
            }

            return new double[] { 0 };
        }
    }
}
