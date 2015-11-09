using System;

namespace LargerNumbers
{
    class Program
    {

        public static int[] getLargerNumbers(int[] a, int[] b)
        {
            var newArray = a;
            for (var i = 0; i < a.Length; i++)
            {
                newArray[i] = Math.Max(a[i], b[i]);
            }
            return newArray;
        }

        static void Main(string[] args)
        {

        }
    }
}
