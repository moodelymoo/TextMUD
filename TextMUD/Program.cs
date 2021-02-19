using System;

namespace TextMUD
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Runner runner = new Runner(1, "Frank");
            runner.Diving();
            Console.WriteLine(runner.ToString().Length);
        }
    }
}