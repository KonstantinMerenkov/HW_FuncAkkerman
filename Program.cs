// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задача 64 и 66. Введите числа M и N.");
        Console.Write("Введите M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine();
        Console.Write("Введите N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (m <= n) 
        {
            Console.Write($"Натуральные числа в промежутке от {m} до {n} -> ");
            // Решение задачи 64
            GetNaturalNumsInterval(m, n);
            // Решение задачи 66
            Console.WriteLine();
            Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} -> {GetSumInterval(m, n)}");
        }
else
        {
            Console.WriteLine("Для решения задач число M должно быть < или = числу N");
        }
//Вычисление функции Аккермана с помощью рекурсии.
Console.WriteLine("Задача 68 - функция Аккерамана. Введите числа m и n.");
Console.Write("m: ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("n: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вычисление функции Аккермана с помощью рекурсии. Даны два неотрицательных числа {m} и {n} -> {AkkermanFunc(m, n)}");


        static void GetNaturalNumsInterval(int start, int end)
        {
            Console.Write($"{start}");
            for (int i = start + 1; i <= end; i++)
            {
                Console.Write($", {i}");
            }
        }

        static int GetSumInterval(int start, int end)
        {
            int result = 0;
            for (int i = start; i <= end; i++)
            {
                result += i;
            }
            return result;
        }

        static int AkkermanFunc(int m, int n)
        {
            int result;
            if (m == 0) 
                 result = n + 1;
            else if (m > 0 && n == 0) 
                 result = AkkermanFunc(m-1, 1);
            else
            {
                 result = AkkermanFunc(m-1, AkkermanFunc(m, n -1));
            }
            return result;
        }
    }
}