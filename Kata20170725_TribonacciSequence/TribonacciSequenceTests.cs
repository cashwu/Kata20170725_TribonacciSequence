using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Kata20170725_TribonacciSequence
{
    [TestClass]
    public class TribonacciSequenceTests
    {
        [TestMethod]
        public void input_array_0_0_1_and_n_0_return_array_0()
        {
            AssertSignatureShouldBe(new double[] { 0, 0, 1 }, 0, new double[] { 0 });
        }

        [TestMethod]
        public void input_array_0_0_1_and_n_1_return_array_0()
        {
            AssertSignatureShouldBe(new double[] { 0, 0, 1 }, 0, new double[] { 0 });
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

        [TestMethod]
        public void input_array_0_0_1_and_n_10_return_array_0_0_1_1_2_4_7_13_24_44()
        {
            AssertSignatureShouldBe(new double[] { 0, 0, 1 }, 10, new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 });
        }

        [TestMethod]
        public void input_array_0_1_1_and_n_10_return_array_0_1_1_2_4_7_13_24_44_81()
        {
            AssertSignatureShouldBe(new double[] { 0, 1, 1 }, 10, new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 });
        }

        [TestMethod]
        public void input_array_1_1_1_and_n_10_return_array_1_1_1_3_5_9_17_31_57_105()
        {
            AssertSignatureShouldBe(new double[] { 1, 1, 1 }, 10, new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 });
        }

        [TestMethod]
        public void input_array_1_2_3_and_n_1_return_array_1()
        {
            AssertSignatureShouldBe(new double[] { 1, 2, 3 }, 1, new double[] { 1 });
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

            var result = new List<double>();

            for (int i = 0; i < n; i++)
            {
                result.Add(GetTribonacciItem(signature, result, i));
            }

            return result.ToArray();
        }

        private double GetTribonacciItem(double[] signature, List<double> result, int i)
        {
            if (i < 3)
            {
                return signature[i];
            }

            return result[i - 1] + result[i - 2] + result[i - 3];
        }
    }
}