using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy6rpm
{
    public class Student : Person // Определяем класс "Студент", наследуемый от "Персона"
    {
        private string StudentNumber; // Поле "Номер студенческого" (приватное)
        private string Major; // Поле "Специальность" (приватное)

        public Student(string Name, int Age, string StudentNumber, string Major) // Конструктор класса "Студент"
            : base(Name, Age) // Инициализация базового класса
        {
            this.StudentNumber = StudentNumber; // Инициализация поля "Номер студенческого"
            this.Major = Major; // Инициализация поля "Специальность"
        }

        public override string GetInfo() => // Переопределение метода "GetInfo"
            base.GetInfo() + $"\nНомер студента: {StudentNumber}\nСпециальность: {Major}"; // Возвращает информацию о студенте

        public void Study() => Console.WriteLine($"{Name} обучается!"); // Метод "Study" (выводит сообщение, что студент учится)
    }
}
