using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
//Реализовать класс, в котором указанные значения представлены в виде свойств.
//Для свойств предусмотреть проверку корректности данных.
//Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы.
//Создать объект на основе разработанного класса. Осуществить использование объекта в программе.



namespace Task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle angle;
            do
            {
                Console.Write("Введите градусы: ");
                int = = .ToInt32(Console.ReadLine());
                Console.Write("Введите минуты: ");
                int = = .ToInt32(Console.ReadLine());
                Console.Write("Введите секунды: ");
                int = = .ToInt32(Console.ReadLine());

                angle = Angle(gradus_, min_, sec_);

                if (!angle.isCorrect)
                    Console.WriteLine("\nОшибка. Повторите ввод.");

            } while (angle.isCorrect == false);

            double  = = .ToRadians();
            Console.Write($"Радианы: {radian}");
            Console.ReadLine();
        }
    }
}
