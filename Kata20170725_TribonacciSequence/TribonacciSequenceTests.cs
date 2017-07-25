using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170725_TribonacciSequence
{
    [TestClass]
    public class TribonacciSequenceTests
    {
        [TestMethod]
        public void input_array_0_0_1_and_n_0_return_empty()
        {
            var xbonacci = new Xbonacci();
            var acutal = xbonacci.Tribonacci(new double[] {0, 0, 1}, 0);
            CollectionAssert.AreEqual(new double[]{}, acutal);
        }
    }

    public class Xbonacci
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            return new double[]{};
        }
    }
}
