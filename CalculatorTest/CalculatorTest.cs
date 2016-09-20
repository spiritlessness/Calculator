using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace CalculatorTest
{
    public class CalculatorTest
    {
        [Test]
        public void SumPositiveIntegerNumbers()
        {
            int first = 14;
            int second = 3;
            Assert.AreEqual(17, Calculator.Calculator.Add(first, second));
        }

        [Test]
        public void SumNegativeIntegerNumbers()
        {
            int first = -14;
            int second = -3;
            Assert.AreEqual(-17, Calculator.Calculator.Add(first, second));
        }

        [Test]
        public void SumPositiveIntegerWithNegativeInteger()
        {
            int first = 14;
            int second = -3;
            Assert.AreEqual(11, Calculator.Calculator.Add(first, second));
        }

        [Test]
        public void MultiplePositiveNumbers()
        {
            int first = 4;
            int second = 3;
            Assert.AreEqual(12, Calculator.Calculator.Multiplier(first, second));
        }

        [Test]
        public void MultiplePostiveAndNegative()
        {
            int first = -14;
            int second = 2;
            Assert.AreEqual(-28, Calculator.Calculator.Multiplier(first, second));
        }

        [Test]
        public void MultipleNegativeNumbers()
        {
            int first = -11;
            int second = -3;
            Assert.AreEqual(33, Calculator.Calculator.Multiplier(first, second));
        }

        [Test]
        public void MinusPositiveNumbers()
        {
            int first = 14;
            int second = 3;
            Assert.AreEqual(11, Calculator.Calculator.Minus(first, second));
        }

        [Test]
        public void MinusPositiveAndNegative()
        {
            int first = 14;
            int second = -3;
            Assert.AreEqual(17, Calculator.Calculator.Minus(first, second));
        }

        [Test]
        public void MinusNegativeNumbers()
        {
            int first = 14;
            int second = -3;
            Assert.AreEqual(17, Calculator.Calculator.Minus(first, second));
        }

        [Test]
        public void DividePositiveNumbers()
        {
            int first = 12;
            int second = 3;
            Assert.AreEqual(4, Calculator.Calculator.Divide(first, second));
        }

        [Test]
        public void DividePostiveByNegative()
        {
            int first = 14;
            int second = -2;
            Assert.AreEqual(-7, Calculator.Calculator.Divide(first, second));

        }

        [Test]
        public void DivideNegativeNumbers()
        {
            int first = -21;
            int second = -3;
            Assert.AreEqual(7, Calculator.Calculator.Divide(first, second));
        }
    }
}
