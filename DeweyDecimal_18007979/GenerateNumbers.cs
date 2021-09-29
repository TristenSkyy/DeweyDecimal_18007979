using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimal_18007979
{
    class GenerateNumbers
    {
        Random random;
        public GenerateNumbers()
        {
            random = new Random();
        }
        public string generates_call_numbers()
        {
            List<string> callNumbers = new List<string>();

            int Call_Number = random.Next(999);

            string myNumbers = Call_Number.ToString();

            if (myNumbers.Length < 3)
            {
                int runTimes = 3 - myNumbers.Length;
                for (int i = 0; i < runTimes; i++)
                {
                    myNumbers = myNumbers.Insert(0, "0");

                }
            }

            myNumbers += ".";
            Call_Number = random.Next(9999);
            myNumbers += Call_Number.ToString();

            string Author = " ";
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < 3; i++)
            {
                Author += letters[random.Next(letters.Length)];
            }
            myNumbers += Author;


            return myNumbers;
        }

    }
}
    

