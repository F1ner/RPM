using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        // Этот метод вычисляет факториал числа n
        public static int fact(int n)
        {
            // Если n равно 1, то факториал равен 1
            if (n == 1) return 1;
            // Иначе, мы возвращаем n, умноженное на факториал (n - 1)
            return n * fact(n - 1);
        }

        // Этот метод является точкой входа в консольное приложение
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя число для вычисления факториала
            Write("Введите число: ");
            // Читаем введенное пользователем число
            int n = int.Parse(ReadLine());
            // Вычисляем факториал введенного числа
            int result = fact(n);
            // Выводим результат на экран
            WriteLine($"факториал числа {n} - {result}");
            // Ждем, пока пользователь нажмет любую клавишу
            // Запрашиваем у пользователя число для вычисления факториала
            Write("Введите число: ");
            // Читаем введенное пользователем число
            int b = int.Parse(ReadLine());
            // Вычисляем факториал введенного числа
            int result1 = fact(b);
            // Выводим результат на экран
            WriteLine($"факториал числа {b} - {result1}");
            // Ждем, пока пользователь нажмет любую клавишу
            ReadKey();
        }
    }
}
