using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Homework Task
            // Task 1 - Inputtable Array
            Console.Write("Input array lenght: ");
            int[] arr = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Input index " + i + " value: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nTask 1 Result: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            // Task 2 - Reverse Array
            Console.WriteLine("\n\nTask 2 (Reversed Array): ");
            arr = arr.Reverse().ToArray();
            for (int i = 0; i < arr.Length; i++)
                {
                Console.Write($"{arr[i]} ");
            }

            // Task 3 - Find a Summ of Even Numbers
            int Task3Result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int value = arr[i];
                if (value % 2 == 0)
                {
                    {
                        Task3Result = Task3Result + value;
                    }
                }
            }

            Console.WriteLine($"\n\nTask 3 Result: {Task3Result}");

            // Task 4 - Find a Minimal Number in an Array
            int Task4Result = 0;

            for (int i = 0; i < arr.Length; i++)
        {
                int value = arr[i];
                if (Task4Result > value)
            {
                    Task4Result = value;
                }
            }

            Console.WriteLine($"\nTask 4 Result (Minimal Number in an Array): {Task4Result}");
        }
    }
}
