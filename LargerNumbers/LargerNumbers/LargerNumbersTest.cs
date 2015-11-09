using NUnit.Framework;

namespace LargerNumbers
{

    [TestFixture]
    public class LargerNumbersTest
    {
        [TestCase]
        public void getLargerNumber()
        {
            int[] arr1 = new int[] { 13, 64, 5, 7, 88 };
            int[] arr2 = new int[] { 23, 4, 53, 17, 80 };
            Assert.AreEqual(Program.getLargerNumbers(arr1, arr2), new int[] { 23, 64, 53, 17, 88 });
        }
    }
}
