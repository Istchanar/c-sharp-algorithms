using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using lesson3._1;

namespace lesson3._1
{
    public class BechmarkClass
    {
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

        //public IEnumerable<int> ValuesForA => new[] { 100, 200 };

        public int [] ValuesForA = {100, 200, 300, 400, 500, 600};

        [ParamsSource(nameof(ValuesForA))]

        public float TestFloat { get; set; }

        [Params(200, 300)]

        public float TestFloat2 { get; set; }


        [Benchmark]
        public void TestClassFloat()
        {
            PointClassFloat pointOne = new PointClassFloat();

            pointOne.X = TestFloat;

            pointOne.Y = TestFloat;

            PointClassFloat pointTwo = new PointClassFloat();

            pointOne.X = TestFloat2;

            pointOne.Y = TestFloat2;

            ClassFloat(pointOne, pointTwo);
        }

        /*
        [Benchmark]
        public void TestStructFloat()
        {
            PointStructFloat pointOne = new PointStructFloat();

            pointOne.X = 120;

            pointOne.Y = 120;

            PointStructFloat pointTwo = new PointStructFloat();

            pointOne.X = 150;

            pointOne.Y = 150;

            StructFloat(pointOne, pointTwo);
        }

        [Benchmark]
        public void TestStructDouble()
        {
            PointStructDouble pointOne = new PointStructDouble();

            pointOne.X = 120;

            pointOne.Y = 120;

            PointStructDouble pointTwo = new PointStructDouble();

            pointOne.X = 150;

            pointOne.Y = 150;

            StructDouble(pointOne, pointTwo);
        }

        [Benchmark]
        public void TestStructFloatNoSqr()
        {
            PointStructFloat pointOne = new PointStructFloat();

            pointOne.X = 120;

            pointOne.Y = 120;

            PointStructFloat pointTwo = new PointStructFloat();

            pointOne.X = 150;

            pointOne.Y = 150;

            StructFloatNoSqr(pointOne, pointTwo);
        }
        */
    }
}
