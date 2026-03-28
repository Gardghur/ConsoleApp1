using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input triangles width: ");
            int width = int.Parse(Console.ReadLine()) + 1;

            // Справа на лево
            // Вниз вверх
            for (int h = 0; h < width; h++)
            {
                for (int w = 0; w < h; w++)
                {
                    Console.Write("■");
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            // Свеврху вниз
            for (int h = 0; h < width; h++)
            {
                for (int w = width - h; w > 1; w--)
                {
                    Console.Write("■");
                }

                Console.WriteLine();
            }



            // Справа на лево
            // Вниз вверх
            for (int h = 0; h < width; h++)
            {
                for (int w = 0; w < width - h - 1; w++)
                {
                    Console.Write(" ");
                }

                for (int w = 0; w < h; w++)
            {
                    Console.Write("■");
            }

                Console.WriteLine();
            }
            Console.WriteLine();
            // Свеврху вниз
            for (int h = 0; h < width; h++)
            {
                for (int w = 0; w < h; w++)
                {
                    Console.Write(" ");
                }

                for (int w = width - h; w > 1; w--)
            {
                    Console.Write("■");
                }

                Console.WriteLine();
            }
        }
    }
}
