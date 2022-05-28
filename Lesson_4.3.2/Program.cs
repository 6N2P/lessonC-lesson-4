using System;

namespace Lesson_4._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int columnMasiv = 0;
            int stringMasiv = 0;
            bool flag = false;
            string operation = string.Empty;

            flag = false;
            while (flag == false)
            {
                Console.WriteLine("Ведите количество строк матрицы не больше 10");

                stringMasiv = Convert.ToInt32(Console.ReadLine());
                if (stringMasiv > 10 || stringMasiv < 0)
                {
                    Console.WriteLine("Веденно не верное число");
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }

            while (flag == false)
            {
                Console.WriteLine("Ведите колличество столбцов матрицы не больше 10");

                columnMasiv = Convert.ToInt32(Console.ReadLine());
                if (columnMasiv > 10 || columnMasiv < 0)
                {
                    Console.WriteLine("Веденно не верное число");
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }


            int[,] masive1 = new int[stringMasiv, columnMasiv];
            int[,] masive2 = new int[stringMasiv, columnMasiv];
            int[,] masive3 = new int[stringMasiv, columnMasiv];

            Random random = new Random();

            Console.WriteLine("Первая матрица");

            for (int i = 0; i < stringMasiv; i++)
            {
                for (int j = 0; j < columnMasiv; j++)
                {
                    masive1[i, j] = random.Next(10);
                    Console.Write($"{masive1[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Вторая матрица");

            for (int i = 0; i < stringMasiv; i++)
            {
                for (int j = 0; j < columnMasiv; j++)
                {
                    masive2[i, j] = random.Next(10);
                    Console.Write($"{masive2[i, j]} ");
                }
                Console.WriteLine();
            }

            flag = false;
            while (flag == false)
            {
                Console.WriteLine("Какую операцию вы хотите сделать? сложение или вычитание");
                operation = Console.ReadLine();
                if (operation == "+" || operation == "-")
                {
                    flag = true;
                }
                else
                {

                    Console.WriteLine("Нужно ввести либо + либо -");
                    flag = false;
                }
            }
            Console.WriteLine("Результат");
            switch (operation)
            {
                case "+":
                    for (int i = 0; i < stringMasiv; i++)
                    {
                        for (int j = 0; j < columnMasiv; j++)
                        {
                            masive3[i, j] = masive1[i, j] + masive2[i, j];
                            Console.Write($"{masive3[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case "-":
                    for (int i = 0; i < stringMasiv; i++)
                    {
                        for (int j = 0; j < columnMasiv; j++)
                        {
                            masive3[i, j] = masive1[i, j] - masive2[i, j];
                            Console.Write($"{masive3[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
