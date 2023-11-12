using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevjatkovaAA.Sprint4.Task6.V2.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint4.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Девяткова А. А. | АСОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Девяткова Анастасия Александровна | АСОиУБ-23-3              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Белый, Черный, Зеленый, Синий,             *");
            Console.WriteLine("* Красный, Желтый, Фиолетовый], используя класс Array, выведите           *");
            Console.WriteLine("* элементы массива, длина которых больше 5 символов.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var array = new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Элементы массива, длина которых больше 5 символов: ");

            string[] res = ds.Calculate(array);

            for (int i = 0; i < res.Length - 1; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}
