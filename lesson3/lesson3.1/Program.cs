
using BenchmarkDotNet.Attributes;

using BenchmarkDotNet.Running;

using lesson3._1;

using System;

namespace GeekBrainsAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }

        PointClassFloat pointOne = new PointClassFloat();
        pointOne.X = 10.213;
        pointOne.X = 15.123;



        public static float ClassFloat(PointClassFloat pointOne, PointClassFloat pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public static float StructFloat(PointStructFloat pointOne, PointStructFloat pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public static double StructDouble(PointStructDouble pointOne, PointStructDouble pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((float)((x * x) + (y * y)));
        }

        public static float StructFloatNoSqr(PointStructFloat pointOne, PointStructFloat pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }

    }

    public class BechmarkClass
    {
       

        public int SumValueType(int value)
        {
            return 9 + value;
        }

        public int SumRefType(object value)
        {
            return 9 + (int)value;
        }

        [Benchmark]
        public void TestSum()
        {
            SumValueType(99);
        }

        [Benchmark]
        public void TestSumBoxing()
        {
            object x = 99;
            SumRefType(x);
        }
    }
}


