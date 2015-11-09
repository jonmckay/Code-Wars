using NUnit.Framework;

namespace EmailObfuscator
{
    [TestFixture]
    public class EmailObfuscatorTest
    {

        [Test]
        public void test1()
        {
            Assert.AreEqual("test [at] 123 [dot] com",
            Program.Obfuscate("test@123.com"));
        }
        [Test]
        public void test2()
        {
            Assert.AreEqual("Code_warrior [at] foo [dot] ac [dot] uk",
            Program.Obfuscate("Code_warrior@foo.ac.uk"));
        }
    }
}
