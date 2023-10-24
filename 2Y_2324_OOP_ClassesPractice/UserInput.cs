using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Y_2324_OOP_ClassesPractice
{
    internal class UserInput
    {
        public int GetuInput()
        {
            string uInput = "";
            int num = 0;

            while (true)
            {
                uInput = Console.ReadLine();
                if(int.TryParse(uInput, out num))
                {
                    if (num >= 0 && num <= 65535)
                        break;
                    else
                        Console.WriteLine("Invalid. Try again.");
                }
                else
                    Console.WriteLine("Invalid. Try again.");
            }

            return num;
        }
    }
}
