using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevjatkovaAA.Sprint4.Task5.V18.Lib;


namespace Tyuiu.DevjatkovaAA.Sprint4.Task5.V18
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
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Девяткова Анастасия Александровна | АСОиУБ-23-3              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -6 до 7. Заменить отрицательные    *");
            Console.WriteLine("* элементы массива на 0.                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Random rnd = new Random();

            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов в массиве: ");
            int colums = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, colums];

            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    matrix[i, j] = rnd.Next(-6, 8);
                }
            }

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Новый массив, где все отрицательные элементы заменены на 0 ");

            int[,] res = ds.Calculate(matrix);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
