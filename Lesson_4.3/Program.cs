using System;

namespace Lesson_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите максимальное число диапазона");

            int maxNumber = Convert.ToInt32(Console.ReadLine());
            int hiddenNumber = 0;
            int chislo = 0;
            int[] masive = new int[maxNumber];

            for (int i = 0; i < maxNumber; i++)
            {
                masive[i] = chislo;
                chislo = chislo+1;
            }

            Random randomNumber = new Random ();
            hiddenNumber = randomNumber.Next(0, maxNumber + 1);

            int numberPleyer = 0;
            bool flag = false;
            while(flag == false)
            {
                Console.WriteLine("Ведите число");
                string input = Console.ReadLine();

                if (input=="")
                {
                    Console.WriteLine($"загаданное число было: {hiddenNumber}");
                    break;
                }

                numberPleyer = Convert.ToInt32(input);
                if(numberPleyer==hiddenNumber)
                {
                    Console.WriteLine($"Загаданное число: {hiddenNumber}");
                    flag = true;
                }
                else if (numberPleyer<hiddenNumber)
                {
                    Console.WriteLine("Ваше число меньше загаданного");
                    flag = false;
                }
                else if (numberPleyer>hiddenNumber)
                {
                    Console.WriteLine("Ваше число больше загаданног");
                    flag = false;
                }               
                


            }

        }
    }
}
