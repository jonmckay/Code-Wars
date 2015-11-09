using System;

namespace EmailObfuscator
{
    class Program
    {
        public static string Obfuscate(string email)
        {
            email = email.Replace("@", " [at] ");
            return email.Replace(".", " [dot] ");
        }


        static void Main(string[] args)
        {

            var email = Obfuscate("test@123.com");
            Console.WriteLine(email);
        }
    }
}
