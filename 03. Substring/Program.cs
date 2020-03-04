using System;
using System.Linq;
using System.Text;

namespace _03._Substring
{
    class Program
    {
        static void Main()
        {
            string key = Console.ReadLine().ToLower();
            string someText = Console.ReadLine();

            int index = someText.IndexOf(key);
            while (index != -1)
            {
                someText = someText.Remove(index, key.Length);
                index = someText.IndexOf(key);
            }
            Console.WriteLine(someText);
        }
    }
}
