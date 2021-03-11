using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;

namespace HashSetTest4._1
{
    public class Program
    {
        static void Main(string[] args)
        {

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

            /*
            var hashSet = new HashSet<User>();

            var user = new User() { FirstName = "Barbara", SecondName = "Santa" };

            hashSet.Add(user);

            var searchUsser = new User() { FirstName = "Barbara", SecondName = "Santa" };

            Console.WriteLine($"contains user {hashSet.Contains(user)}, contains searchUsser {hashSet.Contains(searchUsser)}");

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            */
        }


        public class BechmarkClass
        {
            Array testArray = new Array();

            [Benchmark]
            public void TestVal()
            {
                string value = testArray.GetValue(5000);
            }
        }
    }
}

