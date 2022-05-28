using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите колличество строк матрицы:");
            int stringMatrix = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите колличество столбцов матрицы:");
            int columnMatrix = Convert.ToInt32(Console.ReadLine());

            //Создаю матрицу
            int[,] matrx = new int[stringMatrix, columnMatrix];

            //Создаю экземпляр для создания рандомных чисел
            Random random = new Random();

            //переменная для хранения суммы матрицы
            int sum = 0;

            //Цикал. создаёт в строке столбики с рандомными значениями.
            //выводит эту строку значений
            //считает и записывает сумму стороки
            //Затем переходит на новую строку и делает всё тоже самое.
            for (int i = 0; i < stringMatrix; i++)
            {
                for (int j = 0; j < columnMatrix; j++)
                {
                    matrx[i, j] = random.Next(10);
                    Console.Write($"{matrx[i, j]} ");
                    sum += matrx[i, j];
                }
                Console.WriteLine();
            }

            //выводит сумму всех строк матрицы.
            Console.WriteLine($"Сумма матрицы = :{sum}");           

            Console.ReadKey();
        }
    }
}
