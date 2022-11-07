using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_24___Boss_Battles
{
    internal class PasswordValidator
    {



        public PasswordValidator() { }

        public static void CheckPassword()
        {
            while (true)
            {
                Console.Write("Enter a password: ");
                string password = Console.ReadLine();
                //requirements for correct password
                bool _ContainsUppercase = false;
                bool _ContainsLowercase = false;
                bool _ContainsNumber = false;
                bool _Length = false;
                bool _DoesNotContainSpecialChar = false;
                if (password.Length >= 6 && password.Length <= 13) _Length = true;
                if (!password.Contains("T") && !password.Contains("&")) _DoesNotContainSpecialChar = true;
                foreach (char letter in password)
                {
                    if (char.IsUpper(letter)) _ContainsUppercase |= true;
                    if (char.IsLower(letter)) _ContainsLowercase |= true;
                    if (char.IsDigit(letter)) _ContainsNumber |= true;
                }
                bool Requirements = _ContainsUppercase && _ContainsLowercase && _ContainsNumber && _Length && _DoesNotContainSpecialChar;
                Console.WriteLine(Requirements);
            }
            //return Requirements;
        }
    }
}

/*Password Rules
 * Atleast 6 letters long and no more than 13 letters
 * Must have 1 uppercase, 1 lowercase and 1 number
 * Cannot contain "T" or "&"
 * */