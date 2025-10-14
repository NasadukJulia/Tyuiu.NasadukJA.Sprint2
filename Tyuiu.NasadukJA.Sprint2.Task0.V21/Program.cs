using Tyuiu.NasadukJA.Sprint2.Task0.V21.Lib;

// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();

int x = 1705;
int y = 775;
bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);

Console.Title = "Спринт #2 | Выполнила: Насадюк Ю. А. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Операции сравнения                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнила: Насадюк Юлия Андреевна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=) и       *");
Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность: *");
Console.WriteLine("* (False, False, False, False, False, False), при x = 1705, y = 775       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("X = " + x);
Console.WriteLine("Y = " + y);


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

for (int i=0; i<6; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadLine();
