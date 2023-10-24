using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Y_2324_OOP_ClassesPractice
{
    internal class Converter
    {
        public string[] Converted (int num)
        {
            string[] convertedNums = new string[3];
            int[][] digits = new int[2][]; // this is only for binary and octal 
            digits[0] = new int[16];
            digits[1] = new int[6];
            char[] hex = new char[4];

            convertedNums[0] = Format(ToBinary(num, digits));
            convertedNums[1] = ToOctal(num, digits);
            convertedNums[2] = ToHexadecimal(num, hex);

            return convertedNums;
        }

        private string ToBinary (int num, int[][] digits)
        {
            string temp = "";
            for (int x = 0; x < digits[0].Length; x++)
            {
                if (num >= Math.Pow(2, 15 - x))
                {
                    digits[0][x] = 1;
                    num = num - (int)Math.Pow(2, (digits[0].Length - 1) - x);
                }
            }

            return temp = string.Join("", digits[0]);
        }

        private string Format(string temp)
        {
            for (int i = 4; i < temp.Length; i += 5)
            {
                temp = temp.Insert(i, " ");
            }
            return temp;
        }

        private string ToOctal (int num, int[][] digits) 
        {
            string temp = "";
            for (int x = 0; x < digits[1].Length; x++)
            {
                if (num >= Math.Pow(8, 5 - x))
                {
                    digits[1][x] = (int)(num / Math.Pow(8, 5 - x));
                    num = num % (int)Math.Pow(8, 5 - x);
                }
                else
                {
                    digits[1][x] = 0;
                }
            }
            return temp = string.Join("", digits[1]);
        }

        private string ToHexadecimal(int num, char[]hex)
        {
            for (int x = 0; x < hex.Length; x++)
            {
                int remainder = num % 16;
                hex[3 - x] = remainder < 10 ? (char)(remainder + '0') : (char)(remainder - 10 + 'A');
                num = num / 16;
            }

            return new string(hex);
        }
    }
}
