using System;

namespace _25_27_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи - 25, 27, 29: ");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            switch (taskNumber)
            {
                case 25:
                    TaskTwentyfive();
                    break;
                case 27:
                    TaskTwentyseven();
                    break;
                case 29:
                    TaskTwentynine();
                    break;
                default:
                    Console.WriteLine("Такой задачи не существует");
                    break;
            }


            #region Задача 25
            /*Напишите цикл, который принимает на вход два числа(A и B) и возводит число A в натуральную степень B.
            3, 5-> 243(3⁵)
            2, 4-> 16*/

            static void TaskTwentyfive()
            {
                Console.WriteLine("Введите первое число");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите натуральную степень");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                if (secondNumber > 0)
                {
                    int result = 1;
                    for (int i = 0; i < secondNumber; i++)
                    {
                        result *= firstNumber;
                    }
                    Console.WriteLine(result);
                }
                else Console.WriteLine("Введена ненатуральная степень");
            }
            #endregion

            #region Задача 27
            /*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            452-> 11
            82-> 10
            9012-> 12*/

            static void TaskTwentyseven()
            {
                Console.WriteLine("Введите число");
                int N = Convert.ToInt32(Console.ReadLine());
                int result = 0; 
                while (N != 0)
                {
                    result += N % 10;
                    N /= 10;
                }
                Console.WriteLine(result);
            }
            #endregion

            #region Задача 29
            /*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран*/

            static void TaskTwentynine()
            {
                Console.WriteLine("Введите 8 чисел через пробел");
                string numbers = Console.ReadLine();
                numbers = numbers.Replace(".", "");
                numbers = numbers.Replace(",", "");
                string[] numbersArray = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (numbersArray.Length == 8) 
                {
                    Console.WriteLine("--------------------");
                    Console.Write("[");
                    for (int i = 0; i < numbersArray.Length; i++)
                    {
                        Console.Write($"{numbersArray[i]} ");
                    }
                    Console.Write("]");
                }
                else Console.WriteLine("Введено не 8 чисел");
            }
            #endregion
        }
    }
}
