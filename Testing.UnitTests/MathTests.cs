using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Testing.Fundamentals;
using Math = Testing.Fundamentals.Math;

namespace Testing.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        //setup attribute
        [SetUp]
        public void Setup()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnSUmOfTwoArguments()
        {
            //Act
            var result = _math.Add(1, 2);
            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2,1,2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void MAx_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            //Act
            var result = _math.Max(a, b);
            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbers()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.EquivalentTo(new int[] {1, 3, 5}));
        }
    }
}
