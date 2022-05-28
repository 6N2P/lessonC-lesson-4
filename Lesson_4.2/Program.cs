using System;

namespace Lesson_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите длину массива:");

            int longMasive = Convert.ToInt32(Console.ReadLine());

            //Создаю массив
            int[] masive = new int[longMasive];

            Console.WriteLine("Ведиете последовательно числа:");

            //Заполняю массив числами вводимые пользователем
            for (int i = 0; i < longMasive; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                masive[i] = number;
            }

            //Создаю переменную для сравнения
            int min = int.MaxValue;

            for (int i = 0; i < longMasive; i++)
            {
                // сравнивает значения массива, если число меньше предыдущего числа массива, то оно записывается в переменную min
                if (min > masive[i])
                {
                    min = masive[i];
                    
                }
            }
            //вывожу минимальное число массива.
            Console.WriteLine($"Минимальное число массива: {min}");           

            Console.ReadKey();
            
        }
    }
}
