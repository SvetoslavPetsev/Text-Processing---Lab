using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main()
        {
            StringBuilder numbers = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();

            string input = Console.ReadLine();

            foreach (var item in input)
            {
                if (item >= 48 && item <= 57)
                {
                    numbers.Append(item);
                }
                else if (item >= 65 && item <= 90 || item >= 97 && item <= 122)
                {
                    letters.Append(item);
                }
                else
                {
                    symbols.Append(item);
                }
            }
            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
