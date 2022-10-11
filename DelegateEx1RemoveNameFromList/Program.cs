using System;
using System.Collections.Generic;

namespace DelegateEx1RemoveNameFromList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Rachana", "Rajdeep", "Diploo", "Keerthana", "Arpana" };

            Console.Write("before filter: ");

            //before filter
            foreach (string s in list)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine();

            //apply filter
            list.RemoveAll(Filter);

            Console.Write("after filter: ");
            //after filter
            foreach (string s in list)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine();

        }

        static bool Filter(string s)
        {
            return s.Contains("r");
        }
    }
}
