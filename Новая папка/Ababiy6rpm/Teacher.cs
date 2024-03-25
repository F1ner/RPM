using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy6rpm
{
    public class Teacher : Person // Определяем класс "Преподаватель", наследуемый от "Персона"
    {
        private string Department; // Поле "Кафедра" (приватное)
        private string Position; // Поле "Должность" (приватное)

        public Teacher(string Name, int Age, string Department, string Position) // Конструктор класса "Преподаватель"
            : base(Name, Age) // Инициализация базового класса
        {
            this.Department = Department; // Инициализация поля "Кафедра"
            this.Position = Position; // Инициализация поля "Должность"
        }

        public override string GetInfo() => // Переопределение метода "GetInfo"
            base.GetInfo() + $"\nКафедра: {Department}\nДолжность: {Position}"; // Возвращает информацию о преподавателе

        public void Teach() => Console.WriteLine($"{Name} преподает!"); // Метод "Teach" (выводит сообщение, что преподаватель преподает)
    }
}
