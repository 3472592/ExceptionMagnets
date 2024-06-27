using System;

namespace ExceptionMagnets
{
    class Program
    {
        public static void Main()
        {
            Console.Write("when it ");
            ExTestDrive.Zero("yes");
            Console.Write(" it ");
            ExTestDrive.Zero("no");
            Console.WriteLine(".");
            Console.ReadLine();
        }
    }
}
