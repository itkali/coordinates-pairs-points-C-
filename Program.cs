using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 30;
            int[,] array = new int[n, 2];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Точка " + ++i + ": ");
                --i;
                for (int j = 0; j < 2; j++)
                {
                    array[i, j] = rnd.Next(-10, 10);
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n________________\n");

            double MaxL = 0;
            int[] Point1 = new int[2];
            int[] Point2 = new int[2];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = i + 1; j < array.GetLength(0); j++)
                    if (Math.Sqrt(Math.Pow(array[i, 0] - array[j, 0], 2) + Math.Pow(array[i, 1] - array[j, 1], 2)) > MaxL)
                    {
                        MaxL = Math.Sqrt(Math.Pow(array[i, 0] - array[j, 0], 2) + Math.Pow(array[i, 1] - array[j, 1], 2));
                        Point1[0] = array[i, 0];
                        Point1[1] = array[i, 1];
                        Point2[0] = array[j, 0];
                        Point2[1] = array[j, 1];
                    }
            Console.WriteLine("Первая точка " + Point1[0] + "\t" + Point1[1]);
            Console.WriteLine("Вторая точка " + Point2[0] + "\t" + Point2[1]);
            Console.WriteLine("Растояние между точками" + Math.Round(MaxL, 2));
        }
    }
}
