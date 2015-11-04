using System;
using System.Text.RegularExpressions;

namespace AreaOfACircle
{
    class Program
    {
        public static double CalculateAreaOfCircle(string radius)
        {
            if (Regex.IsMatch(radius, @"\d") && Convert.ToDouble(radius) > 0 && !radius.Contains(","))
            {
                return Math.Round(Math.PI * Math.Pow(Convert.ToDouble(radius), 2), 2);
            }
            throw new ArgumentException();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CalculateAreaOfCircle("number"));
        }
    }
}
