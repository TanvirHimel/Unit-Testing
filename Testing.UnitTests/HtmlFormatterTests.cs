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
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseStringWithStrongTag()
        {
            var formatter = new HtmlFormatter();

            var result  = formatter.FormatAsBold("ABC");

            Assert.That(result, Is.EqualTo("<strong>ABC</strong>").IgnoreCase);
        }
    }
}
