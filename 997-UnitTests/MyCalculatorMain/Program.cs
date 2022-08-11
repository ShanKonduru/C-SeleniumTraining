using System;
using MyCalculator;

namespace MyCalculator{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine (MyCalculator.Add (10, 20));
            Console.WriteLine (MyCalculator.Division (10, 20));
            Console.WriteLine (MyCalculator.Power (2, 5));
        }
    }
}
