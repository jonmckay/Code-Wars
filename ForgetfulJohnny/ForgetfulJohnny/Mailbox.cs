using System;
using System.Collections.Generic;

namespace ForgetfulJohnny
{
    class Mailbox
    {
        public static string Pass(string mail)
        {
            if ("" == mail) return null;
            mail = mail.Substring(0, mail.IndexOf("@"));
            var password = mail.ToCharArray();
            var numbers = new List<char>();
            var letters = new List<char>();
            foreach (var character in password)
            {
                if (char.IsDigit(character))
                {
                    numbers.Add(character);
                }
                else
                {
                    letters.Add(char.IsUpper(character) ? char.ToLower(character) : char.ToUpper(character));
                }
            }

            var pass = string.Join("", numbers) + string.Join("", letters);

            return pass;
        }


        static void Main(string[] args)
        {
            Pass("exampl1e3@gmail.com");

        }
    }
}
