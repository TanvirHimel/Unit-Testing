using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Testing.Fundamentals;

namespace Testing.UnitTests
{
    [TestFixture]
    public class DemeritsPointCalculatorTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritsPoint_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {
            var calculator = new DemeritsPointCalculator();

            Assert.That(() => calculator.CalculateDemeritsPoint(speed), 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(65,0)]
        [TestCase(66,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]
        public void CalculateDemeritsPoint_WhenCalled_ReturnDemeritsPoint(int speed, int expectedResult)
        {
            var calculator = new DemeritsPointCalculator();

            var result = calculator.CalculateDemeritsPoint(speed);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
