using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            // Ввод количества элементов в массиве
            Console.WriteLine("Введите кол-во элементов в массиве: ");
            int a = int.Parse(Console.ReadLine());

            // Объявление и инициализация массива
            int[] nums = new int[a];

            // Ввод искомого числа
            Console.WriteLine("Введите искомое число: ");
            int n = int.Parse(Console.ReadLine());

            // Ввод элементов массива
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"Введите {i} элемент массива: ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            // Сортировка массива методом пузырька
            for (int i = 0; i < nums.Length; i++)
            {
                int j = i;
                while (j > 0 && nums[j] < nums[j - 1])
                {
                    int temp = nums[j];
                    nums[j] = nums[j - 1];
                    nums[j - 1] = temp;
                    j = j - 1;
                }
            }

          /*  // Вывод элементов массива
            foreach (int i in nums)
            {
                Console.WriteLine($"mass = {i}");
            }*/

            // Линейный поиск
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == n)
                {
                    res = i;
                }
            }
            Console.WriteLine($"номер искомого элемента в массиве - {res}");

            // Бинарный поиск
            int b = Binary(nums, n); // Переменная для бинарного поиска

            // Проверка, найден ли элемент
            if (b == -1)
            {
                Console.WriteLine("Соответствующих элементов в массиве нет");
            }
            else
            {
                Console.WriteLine($"nums {b} = {nums[b]}");
            }

            Console.ReadKey();





        }
        // Функция бинарного поиска
        static int Binary(int[] mass, int m)
        {
            int left = 0; // левая граница
            int right = mass.Length - 1; // правая граница

            // Цикл поиска
            while (left <= right)
            {
                int midle = left + (right - left) / 2; // середина

                // Проверка равенства
                if (mass[midle] == m)
                {
                    return midle;
                }

                // Сравнение с серединой
                if (mass[midle] < m)
                {
                    left = midle + 1; // переход к правой половине
                }
                else
                {
                    right = midle - 1; // переход к левой половине
                }
            }

            // Элемент не найден
            return -1;
        }
    }
    }