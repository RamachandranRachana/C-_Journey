using System;
using System.Text.RegularExpressions;

namespace RegexExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\racha\Documents\GitHub\CSharp-Journey\RegexExample\input\input.txt");
            foreach (string l in lines)
            {
                if (l.Contains("split"))
                {
                    string[] outs = l.Split(" ");
                    Console.WriteLine(outs[4]);
                }
            }

            string pattern = @"\d{2,3}";
            Regex regex = new Regex(pattern);

            string[] lines2 = System.IO.File.ReadAllLines(@"C:\Users\racha\Documents\GitHub\CSharp-Journey\RegexExample\input\input2.txt");
            foreach (string l in lines2)
            {
                MatchCollection matches = regex.Matches(l);
                foreach (Match match in matches)
                {
                    int iVal = int.Parse(match.Value);
                    Console.Write((char)iVal);
                }
            }
        }
    }
}
