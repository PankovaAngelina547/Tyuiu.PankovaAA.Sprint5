using Tyuiu.PankovaAA.Sprint5.Task2.V18.Lib;
namespace Tyuiu.PankovaAA.Sprint5.Task2.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            Console.Title = "Спринт #5 [Выполнила: Панькова А.А.] ПИН6-25-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                  *");
            Console.WriteLine("* Тема: Запись структурированных данных в текстовый файл                     *");
            Console.WriteLine("* Задание #02                                                                *");
            Console.WriteLine("* Вариант #18                                                                *");
            Console.WriteLine("* Выполнила: Панькова Ангелина Алексеевна | ПИН6-25-1                        *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("*******************************************************************************");

            int[,] array = new int[3, 3]
            {
                { 3, 8, 4 },
                { -5, -4, -3 },
                { -9, 0, 2 }
            };

            Console.WriteLine("Исходный массив:");
            PrintArray(array);


            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("*******************************************************************************");

            Console.WriteLine("Преобразованный массив:");
            PrintTransformedArray(array);

            string res = ds.SaveToFileTextData(array);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{array[i, j],4} ");
                }
                Console.WriteLine();
            }
        }

        static void PrintTransformedArray(int[,] array)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int value = array[i, j] > 0 ? 1 : 0;
                    Console.Write($"{value,2} ");
                }
                Console.WriteLine();
            }
        }
    }
}
