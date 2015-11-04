using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfACircle
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class AreaOfCircleTests
    {
        [Test]
        public void ShouldFailNegativeNumber()
        {
            Assert.Throws<ArgumentException>(delegate { Program.CalculateAreaOfCircle("-123"); });
            //Assert.Throws(typeof(ArgumentException), Kata.CalculateAreaOfCircle("-123"));
        }

        [Test]
        public void ShouldFailAlphaNumeric()
        {
            Assert.Throws<ArgumentException>(delegate { Program.CalculateAreaOfCircle("number"); });
        }

        [Test]
        public void ShouldPass1()
        {
            Assert.AreEqual(5881.25, Program.CalculateAreaOfCircle("43.2673"));
        }
    }
}
