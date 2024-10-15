using System;
using System.Collections.Generic;

namespace FormattingString
{
     class Program
    {
        static void Main(string[] args)
        {
            string director = "Sam Raimi", movie = "Spider man";
            string msg=string.Format("{0} is the director of {1}", director, movie);
            string msg2 = $"{director} is the director of {movie}";
            Console.WriteLine(msg);
            Console.WriteLine(msg2);
            Console.ReadKey();
        }
    }
}
