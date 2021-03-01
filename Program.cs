using System;

namespace AsciiArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
           string L1 = " ||  ||";
           string L2 = "\\";
           string L5 = "//";
           string L6 = "()";
           string L3 = "(__)";
           string L4 = "||    ||";

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(L1);
            Console.Write(" \\");
            Console.Write(L2);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(L6);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(L5); 
            Console.Write("//");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(L3);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\\");
            Console.WriteLine("\\");
            Console.WriteLine(L4);

            Console.ResetColor();
        }
    }
}
