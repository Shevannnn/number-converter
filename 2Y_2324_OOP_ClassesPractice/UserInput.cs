using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Y_2324_OOP_ClassesPractice
{
    internal class UserInput
    {
        public int uInput()
        {
            return GetuInput();
        }

        private int GetuInput()
        {
            while (true)
            {
                string temp = Console.ReadLine();
                int num = 0;

                int.TryParse(temp, out num);




                if (num >= 0 || num <= 65535)
                {
                    return num;
                }
            }
        }
    }
}
