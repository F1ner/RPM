using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy6rpm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111
            //Person person1 = new Person("Джон Дой", 40); // Создаем объект "person1" класса "Персона"
            //Student student1 = new Student("Питер Паркер", 20, "123456789", "Компьютерный специалист"); // Создаем объект "student1" класса "Студент"
            //Teacher teacher1 = new Teacher("Рукабуд Альхаламулакурапидокаров", 50, "АРАОК", "Профессор"); // Создаем объект "teacher1" класса "Преподаватель"

            //Console.WriteLine(person1.GetInfo()); // Выводим информацию о персоне
            //Console.WriteLine(); // Переход на новую строку

            //Console.WriteLine(student1.GetInfo()); // Выводим информацию о студенте
            //student1.Study(); // Вызываем метод "Study" для объекта "student1"
            //Console.WriteLine(); // Переход на новую строку

            //Console.WriteLine(teacher1.GetInfo()); // Выводим информацию о преподавателе
            //teacher1.Teach(); // Вызываем метод "Teach" для объекта "teacher1"

            ///22222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222
            Computer computer1 = new Computer("My Computer", "ASUS"); // Создаем объект "computer1" класса "Computer"
            Motherboard motherboard1 = new Motherboard("ROG Strix Z690-A Gaming WiFi", "ASUS", "Intel Z690", "ATX"); // Создаем объект "motherboard1" класса "Motherboard"
            HardDrive hardDrive1 = new HardDrive("WD Blue WD10EZEX", "Western Digital", "1TB", "SATA III"); // Создаем объект "hardDrive1" класса "HardDrive"

            Console.WriteLine(computer1.GetInfo()); // Выводим информацию о компьютере
            Console.WriteLine(); // Переход на новую строку

            Console.WriteLine(motherboard1.GetInfo()); // Выводим информацию о материнской плате
            Console.WriteLine(); // Переход на новую строку

            Console.WriteLine(hardDrive1.GetInfo()); // Выводим информацию о винчестере


            Console.ReadKey();
        }
    }
}
