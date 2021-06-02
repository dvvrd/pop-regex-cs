using System;

namespace RegexMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "^he*l*o";
            Console.WriteLine(RegEx.Match(pattern, "hello"));
        }
    }
}