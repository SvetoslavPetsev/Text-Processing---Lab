using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "end")
            {           
                string revursed = string.Empty;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    revursed += input[i];
                }
                Console.WriteLine($"{input} = {revursed}");
                input = Console.ReadLine();
            }
        }
    }
}
