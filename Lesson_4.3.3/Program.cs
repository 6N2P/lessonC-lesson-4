using System;

namespace Lesson_4._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Введите колличество строк 1-ой матрицы, до 10цифр");
            int numberSrtingMatrixA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите колличество столбцов 1-ой матрицы, до 10цифр");
            int numberColumnMatrixA = Convert.ToInt32(Console.ReadLine());
            int[,] matrixA = new int[numberSrtingMatrixA,numberColumnMatrixA];

            Console.WriteLine("Знчение первой матрицы");
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[i, j] = random.Next(10);
                    Console.Write($"{matrixA[i, j]} ");
                }
                Console.WriteLine();
            }

            bool flag = false;
            int numberSrtingMatrixB = 0;
            while (flag == false)
            {
                Console.WriteLine("Введите колличество строк 2-ой матрицы, до 10цифр. \nКолличество строк должно равнятся колличеству столбцов первой матрицы ");
                numberSrtingMatrixB = Convert.ToInt32(Console.ReadLine());
                if (numberSrtingMatrixB!=numberColumnMatrixA)
                {
                    Console.WriteLine("Колличество строк не равно колличеству столбцов 1-ой матрцы");
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }

            Console.WriteLine("Введите колличество столбцов 2-ой матрицы, до 10цифр");
            int numberColumnMatrixB = Convert.ToInt32(Console.ReadLine());
            int[,] matrixB = new int[numberSrtingMatrixB, numberColumnMatrixB];

            Console.WriteLine("Знчение второй матрицы");
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    matrixB[i, j] = random.Next(10);
                    Console.Write($"{matrixB[i, j]} ");
                }
                Console.WriteLine();
            }

            int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixB.GetLength(0); k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                        
                    }                    
                }                
            }
            Console.WriteLine("Результат");
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    Console.Write($"{matrixC[i,j]} ");
                }
                Console.WriteLine();
            }





        }
    }
}
