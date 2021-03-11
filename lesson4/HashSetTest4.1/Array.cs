using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HashSetTest4._1
{
    public class Array
    {
        static string[] array { get; set; }

        static Array()
        {
            array = new string[10000];
        }
        public void AddValue()
        {
            array = new string[10000];

            for (int i = 0; i < array.Length; i++)
            {
                string text = $"string{i}";

                array[i] = text;
            }
        }

        
        public string GetValue(int index)
        {
            return array[index];
        }
    }
}