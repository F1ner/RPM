using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiyrpm7
{
    public struct Warehouse
    {
        // 3 поля:
        public string Name; // Наименование
        public int Quantity; // Количество
        public decimal Price; // Цена

        // 2 метода:
        public void Add(int quantity) // Добавить
        {
            Quantity += quantity;
        }

        public void Remove(int quantity) // Удалить
        {
            if (Quantity >= quantity)
            {
                Quantity -= quantity;
            }
            else
            {
                throw new Exception("Недостаточно товара на складе!");
            }
        }
    }

}
