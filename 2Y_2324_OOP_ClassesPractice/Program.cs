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
            num = input.GetuInput();

            Console.WriteLine("\nBinary: " + convert.Converted(num)[0]);
            Console.WriteLine("Octal: " + convert.Converted(num)[1]);
            Console.WriteLine("Hexadecimal: " + convert.Converted(num)[2]);
            Console.ReadKey();
        }
    }
}
