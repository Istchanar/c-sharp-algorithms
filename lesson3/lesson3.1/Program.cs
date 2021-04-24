using BenchmarkDotNet.Running;
using System;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

            Console.ReadLine();
        }
    }
}


