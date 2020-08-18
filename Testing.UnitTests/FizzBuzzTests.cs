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
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_InputIsDivisibleByThreeAndFive_ReturnFizzBuzz()
        {
            var fiz = new FizzBuzz();

            var result = fiz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_InputIsDivisibleByThreeOnly_ReturnFizz()
        {
            var fiz = new FizzBuzz();

            var result = fiz.GetOutput(9);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_InputIsDivisibleByFiveOnly_ReturnBuzz()
        {
            var fiz = new FizzBuzz();

            var result = fiz.GetOutput(10);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_InputIsNotDivisibleByThreeAndFive_ReturnSameNumber()
        {
            var fiz = new FizzBuzz();

            var result = fiz.GetOutput(1);

            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
