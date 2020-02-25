using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string country;
            do
            {
                Console.WriteLine("What's your name?");
                name = Console.ReadLine();
            }
            while (!Regex.IsMatch(name, "^[a-zA-Z]+$"));
            do
            {
                Console.WriteLine("Where are you from?");
                country = Console.ReadLine();
            }
            while (!Regex.IsMatch(name, "^[a-zA-Z]+$"));
            Console.WriteLine("Hi ,I am " + name + " from " + country);
            Console.Read();
        }
    }
}
