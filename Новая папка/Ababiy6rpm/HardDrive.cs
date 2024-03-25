using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy6rpm
{
    public class HardDrive : Computer // Определяем класс "Винчестер", наследуемый от "Компьютер"
    {
        private string Capacity; // Поле "Объем" (приватное)
        private string Interface; // Поле "Интерфейс" (приватное)

        public HardDrive(string Name, string Manufacturer, string Capacity, string Interface) // Конструктор класса "Винчестер"
            : base(Name, Manufacturer) // Инициализация базового класса
        {
            this.Capacity = Capacity; // Инициализация поля "Объем"
            this.Interface = Interface; // Инициализация поля "Интерфейс"
        }

        public override string GetInfo() => // Переопределение метода "GetInfo"
            base.GetInfo() + $"\nCapacity: {Capacity}\nInterface: {Interface}"; // Возвращает информацию о винчестере
    }

}
