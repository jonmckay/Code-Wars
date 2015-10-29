using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailTest
{
    [TestClass]
    public class Mail
    {
        [TestMethod]
        public void TestMethod1()
        {
            Pass()
        }

        [TestMethod]
        public void testExampleOne()
        {
            Assert.AreEqual("VASUAussr", Mailbox.Pass("vasuaUSSR@yandex.ru"));
        }

        [TestMethod]
        public void testExampleTwo()
        {
            Assert.AreEqual("111hIrOdOt", Mailbox.Pass("HiRoDoT111@gmail.com"));
        }
    

    }
}
