using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy6rpm
{
    public class Motherboard : Computer // Определяем класс "МатеринскаяПлата", наследуемый от "Компьютер"
    {
        private string Chipset; // Поле "Чипсет" (приватное)
        private string FormFactor; // Поле "Форм-фактор" (приватное)

        public Motherboard(string Name, string Manufacturer, string Chipset, string FormFactor) // Конструктор класса "МатеринскаяПлата"
            : base(Name, Manufacturer) // Инициализация базового класса
        {
            this.Chipset = Chipset; // Инициализация поля "Чипсет"
            this.FormFactor = FormFactor; // Инициализация поля "Форм-фактор"
        }

        public override string GetInfo() => // Переопределение метода "GetInfo"
            base.GetInfo() + $"\nChipset: {Chipset}\nForm Factor: {FormFactor}"; // Возвращает информацию о материнской плате
    }

}
