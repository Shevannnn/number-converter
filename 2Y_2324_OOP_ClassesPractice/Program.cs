using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2Y_2324_OOP_ClassesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter convert = new Converter();
            UserInput input = new UserInput();
            int num = 0;

            Console.WriteLine("Please enter a number between 0 and 65535.");
            num = input.uInput();

            Console.WriteLine("\nBinary:\t" + convert.Binary(num));
            Console.WriteLine("Octal:\t" + convert.Octal(num));
            Console.WriteLine("Hexadecimal:\t" + convert.Hexadecimal(num));
        }
    }
}
