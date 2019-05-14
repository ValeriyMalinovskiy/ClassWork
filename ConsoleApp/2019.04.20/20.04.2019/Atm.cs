using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019Apr20
{
    class Atm
    {
        private static bool PinCodeValidator(string str)
        {
            bool isPinValid = false;
            int strLength = str.Length;
            if (strLength != 4 && strLength != 6)
            {
                return isPinValid;
            }
            isPinValid = true;
            for (int i = 0; i < strLength; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    isPinValid = false;
                }
            }
            return isPinValid;
        }

        public static void AtmPin()
        {
            Console.WriteLine("Enter your PIN to check");
            if(PinCodeValidator(Console.ReadLine()))
                Console.WriteLine("Your PIN code is valid");
            else Console.WriteLine("Your PIN code is invalid");
        }
    }
}
