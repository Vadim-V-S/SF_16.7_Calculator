using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SF_16._7_Calculator;

namespace CalculatorMethods.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        public Calculator calculator = new Calculator();


        [Test]
        public void AdditionalShouldReturnNotNullValue()
        {
            Assert.AreEqual(10, calculator.Additional(6, 4));
        }

        [Test]
        public void SubtractionShouldReturnNotNullValue()
        {
            Assert.That(calculator.Subtraction(6, 4)==2);
        }

        [Test]
        public void MiltiplicationShouldReturnNotNullValue()
        {
            Assert.That(calculator.Miltiplication(6, 4), Is.EqualTo (24));
        }

        [Test]
        public void DivisionShouldReturnNotNullValue()
        {
            Assert.That(calculator.Division(8, 4), Is.EqualTo(2));
        }
    }
}
