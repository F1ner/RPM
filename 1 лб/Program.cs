using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел в массиве:"); // Выводим приглашение для ввода количества чисел
            int length = Convert.ToInt32(Console.ReadLine()); // Считываем количество чисел и преобразуем в целое число

            int[] array = new int[length]; // Создаем новый массив заданной длины

            for (int i = 0; i < length; i++) // Цикл для заполнения массива
            {
                Console.WriteLine($"Введите число {i + 1}:"); // Выводим приглашение для ввода числа
                array[i] = Convert.ToInt32(Console.ReadLine()); // Считываем число и сохраняем в массив
            }

            int[] factorials = new int[length]; // Создаем массив для хранения результатов факториалов

            for (int i = 0; i < length; i++) // Цикл для вычисления факториалов
            {
                factorials[i] = Factorial(array[i]); // Вычисляем факториал числа и сохраняем результат
            }

            Array.Sort(factorials); // Сортируем массив результатов факториалов

            Console.WriteLine("Отсортированные факториалы:"); // Выводим сообщение о выводе отсортированных факториалов

            foreach (int factorial in factorials) // Цикл для вывода каждого элемента массива
            {
                int i = 0;
                Console.WriteLine($"{array[i++]} = {factorial}"); // Выводим отсортированный факториал
            }

            Console.ReadKey();
        }

        // Метод для вычисления факториала числа n
        static int Factorial(int n)
        {
            int result = 1; // Инициализируем переменную для результата
            for (int i = 1; i <= n; i++) // Цикл для вычисления факториала
            {
                result *= i; // Умножаем результат на текущее число
            }
            return result; // Возвращаем результат вычисления факториала
        }


    }
}