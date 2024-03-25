using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy6rpm
{
    
          public class Person // Определяем класс "Персона"
    {
        protected string Name; // Поле "Имя" (защищенное)
        protected int Age; // Поле "Возраст" (защищенное)

        public Person(string Name, int Age) // Конструктор класса "Персона"
        {
            this.Name = Name; // Инициализация поля "Имя"
            this.Age = Age; // Инициализация поля "Возраст"
        }

        public virtual string GetInfo() => $"Имя: {Name}, Возраст: {Age}"; // Виртуальный метод "GetInfo" (возвращает информацию о персоне)
    }
}
