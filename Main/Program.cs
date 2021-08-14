
using System;

namespace Main
{
    class Program
    {
        //static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        static void Main(string[] args)
        {
            Console.WriteLine(Algorithms.GreatestCommonDivisor.GetUsingEuclideanAlgorithm(3918848, 1653264));
        }
    }
}
