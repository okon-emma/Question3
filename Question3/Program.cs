using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Empty String");
            } else
            {
                int lengthInput = input.Trim().Length;
                if (lengthInput == 1)
                {
                    Console.WriteLine(input);
                } else
                {
                    char a = input.First();
                    string b = input.Substring(1, input.Length - 2);
                    char c = input.Last();

                    string output = c + b + a;
                    Console.WriteLine(output);
                }
            }
            Console.ReadKey();
        }
    }
}
