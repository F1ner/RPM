using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy6rpm
{
    public class Computer // Определяем класс "Компьютер"
    {
        protected string Name; // Поле "Название" (защищенное)
        protected string Manufacturer; // Поле "Производитель" (защищенное)

        public Computer(string Name, string Manufacturer) // Конструктор класса "Компьютер"
        {
            this.Name = Name; // Инициализация поля "Название"
            this.Manufacturer = Manufacturer; // Инициализация поля "Производитель"
        }

        public virtual string GetInfo() => $"Name: {Name}, Manufacturer: {Manufacturer}"; // Виртуальный метод "GetInfo" (возвращает информацию о компьютере)
    }

}
