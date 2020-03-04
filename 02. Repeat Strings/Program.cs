using System;
using System.Linq;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();

            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write(item);
                }
            }
        }
    }
}
