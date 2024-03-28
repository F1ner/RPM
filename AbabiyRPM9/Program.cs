using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbabiyRPM9
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            // Магазин
            var products = new Product[]
            {
            new Product(1, "Товар 1", 100),
            new Product(2, "Товар 2", 200),
            new Product(3, "Товар 3", 300),
            new Product(4, "Товар 4", 400),
            new Product(5, "Товар 5", 500),
            new Product(6, "Товар 6", 600),
            new Product(7, "Товар 7", 700),
            new Product(8, "Товар 8", 800),
            new Product(9, "Товар 9", 900),
            new Product(10, "Товар 10", 1000),
            };

            for (int i = 0; i < products.Length; i++)
            {
                // Ввод ID
                Console.Write("Введите ID товара: ");
                int id = int.Parse(Console.ReadLine());


                // Поиск товара
                var product = FindById(products, id);

                // Вывод результата
                if (product != null)
                {
                    Console.WriteLine($"Найден товар: {product.Name} ({product.Price} руб.)");
                }
                else
                {
                    Console.WriteLine($"Товар с ID {id} не найден.");
                }
            }
            Console.ReadKey();
        }

        static Product FindById(Product[] products, int id)
        {
            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }

            return null;
        }
    }

   

}
