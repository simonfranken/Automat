using System;
using System.Collections.Generic;

namespace Automat
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var x = Test(Console.ReadLine());
                Console.WriteLine(x);
                Console.WriteLine();
            }
        }

        private const int Start = 0;
        private static readonly List<int> Ends = new List<int>() { 3 };

        private static readonly int[,] Matrix = new int[,]
        {
            { 0, 1, 2, 3, 1, 2, 3, 1, 2, 3},
            { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1},
            { 2, 3, 1, 2, 3, 1, 2, 3, 1, 2},
            { 3, 1, 2, 3, 1, 2, 3, 1, 2, 3}
        };

        private static int GetNextState(int old, int input)
        {
            return Matrix[old, input];
        }

        public static bool Test(string s)
        {
            var z = Start;
            foreach (var c in s)
            {
                var x = int.Parse(c.ToString());
                z = GetNextState(z, x);
            }

            return Ends.Contains(z);
        }

    }
}