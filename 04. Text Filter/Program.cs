using System;
using System.Text;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in input)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
