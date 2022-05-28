using System;

namespace Lesson_4._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            Random random = new Random();

            int[,] mainMasiv = new int[3,3];
            int[,] resultMasiv = new int[3, 3];

            for (int i = 0; i < mainMasiv.GetLength(0); i++)
            {
                for (int j = 0; j < mainMasiv.GetLength(1); j++)
                {
                    mainMasiv[i, j] = random.Next(10);
                }
            }

            

            Console.WriteLine("Исходная матрица");
            for (int i = 0; i < mainMasiv.GetLength(0); i++)
            {
                for (int J = 0; J <mainMasiv.GetLength(1); J++)
                {
                    Console.Write($"{mainMasiv[i, J]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Умножаю на {number}");

            Console.WriteLine("Результат");
            for (int i = 0; i < mainMasiv.GetLength(0); i++)
            {
                for (int j = 0; j < mainMasiv.GetLength(1); j++)
                {
                    resultMasiv[i, j] = mainMasiv[i,j] *number;
                    Console.Write($"{resultMasiv[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
