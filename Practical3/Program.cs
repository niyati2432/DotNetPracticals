﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimalToBinary();
            decimalToHex();
            decimalToOctal();
            binaryToDecimal();
            Console.Read();
        }
        static void decimalToBinary()
        {
            Console.Write("\n Enter number for Decimal To Binary Conversion:");
            int x = Int32.Parse(Console.ReadLine().ToString());
            int reminder, i = 0;
            int[] binary = new int[100];
            while (x > 0)
            {
                reminder = x % 2;
                binary[i] = reminder;
                x /= 2;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(binary[j]);
            }

        }
        static void decimalToOctal()
        {
            Console.Write("\n Enter number for Decimal To Octal Conversion:");
            int x = Int32.Parse(Console.ReadLine().ToString());
            int[] octalNum = new int[100];
            int i = 0;
            while (x != 0)
            {

                octalNum[i] = x % 8;
                x = x / 8;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(octalNum[j]);
            }
        }
        static void decimalToHex()
        {
            Console.Write("\n Enter number for Decimal To Hex Conversion:");
            int x = Int32.Parse(Console.ReadLine().ToString());
            int reminder, i = 0;
            char[] hex = new char[100];
            while (x > 0)
            {
                reminder = x % 16;
                if (reminder > 9)
                {
                    hex[i] = (char)(reminder + 55);
                }
                else
                {
                    hex[i] = (char)(reminder + 48);
                }
                x /= 16;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(hex[j]);
            }


        }
        public static void binaryToDecimal()
        {
            Console.Write("\n Enter number for Binary To Decimal Conversion:");
            int binaryNumber = Int32.Parse(Console.ReadLine().ToString());
            int base1 = 1;
            int decimalValue = 0;
            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.WriteLine(decimalValue);
            Console.Read();
        }
    }
}