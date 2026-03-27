using System;
using System.ComponentModel;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float minTarget = 0.015f;
            int counter = 0;

            for (float i = 1.0f; i > minTarget; i = i * 0.5f, counter++)
            {
                Console.WriteLine("1: " + i);
                System.Threading.Thread.Sleep(150);
            }

            Console.WriteLine(counter);

            for (int i = 1; ; i++)
            {
                Console.WriteLine("2: " + i);
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
