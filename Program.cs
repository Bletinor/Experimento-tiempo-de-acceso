using System;
using System.Diagnostics;

namespace Experimento
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[100000000];

            var watch = new Stopwatch();

            watch.Start();
            int i = 0;
            while (i != 100000000)
            {
                //First(arrayOne);
                Last(arrayOne, arrayOne.Length);
                i++;
            }
            watch.Stop();

            Console.WriteLine($"Tiempo {watch.ElapsedMilliseconds} ms");
        }

        static public int[] First(int[] array)
        {
            array[0] = 1;
            return array;
        }

        static public int[] Last(int[] array, int max)
        {
            array[max-1] = 0;
            return array;
        }
    }
}
