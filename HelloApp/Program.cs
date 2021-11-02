using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
            BlackGreet();
            WhiteGreet();
        }
        public static void WhiteGreet()
        {
            Console.WriteLine("hello white");
        }
        public static void BlackGreet()
        {
            Console.WriteLine("hello black");
        }
    }
}
