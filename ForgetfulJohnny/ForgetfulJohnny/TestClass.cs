using NUnit.Framework;


namespace ForgetfulJohnny
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestExampleOne()
        {
            Assert.AreEqual("VASUAussr", Mailbox.Pass("vasuaUSSR@yandex.ru"));
        }

        [Test]
        public void TestExampleTwo()
        {
            Assert.AreEqual("111hIrOdOt", Mailbox.Pass("HiRoDoT111@gmail.com"));
        }

        [Test]
        public void TestExampleThree()
        {
            Assert.AreEqual("1323356ExAmPl", Mailbox.Pass("1eXaM32pL3356@gmail.com"));
        }

        [Test]
        public void EmptyMail()
        {
            Assert.AreEqual(null, Mailbox.Pass(""));
        }
    }
}
