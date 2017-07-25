using System;
using System.Collections;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170725_TribonacciSequence
{
    [TestClass]
    public class TribonacciSequenceTests
    {
        [TestMethod]
        public void input_array_0_0_1_and_n_0_return_array_0()
        {
            AssertSignatureShouldBe(new double[] {0, 0, 1}, 0, new double[] {0});
        }

        [TestMethod]
        public void input_array_0_0_1_and_n_3_return_array_0_0_1()
        {
            AssertSignatureShouldBe(new double[] { 0, 0, 1 }, 3, new double[] { 0, 0, 1 });
        }

        [TestMethod]
        public void input_array_0_0_1_and_n_4_return_array_0_0_1_1()
        {
            AssertSignatureShouldBe(new double[] { 0, 0, 1 }, 4, new double[] { 0, 0, 1, 1 });
        }

        private static void AssertSignatureShouldBe(double[] signature, int n, double[] expected)
        {
            var xbonacci = new Xbonacci();
            var acutal = xbonacci.Tribonacci(signature, n);
            CollectionAssert.AreEqual(expected, acutal);
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

            var result = signature.ToList();

            if (n == 3)
            {
                return signature;
            }

            for (int i = 0; i < n - 3; i++)
            {
                result.Add(result[0] + result[1] + result[2]);                
            }

            return result.ToArray();
        }
    }
}
