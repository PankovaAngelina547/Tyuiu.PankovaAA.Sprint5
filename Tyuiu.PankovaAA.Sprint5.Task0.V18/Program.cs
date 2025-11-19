using System;
using System.IO;
using Tyuiu.PankovaAA.Sprint5.Task0.V18.Lib;

namespace Tyuiu.PankovaAA.Sprint5.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3;

            Console.Title = "Спринт #5 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #5                                                              *");
            Console.WriteLine("*  Тема: Запись данных в текстовый файл                                   *");
            Console.WriteLine("*  Задание 00                                                             *");
            Console.WriteLine("*  Вариант #18                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");

            string res = ds.SaveToFileTextData(x); 
            Console.WriteLine("Файл: " + res); 
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}