using Tyuiu.NasadukJA.Sprint2.Task7.V6.Lib;

// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнила: Насадюк Ю. А. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнила: Насадюк Юлия Андреевна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка                 *");
Console.WriteLine("* с координатами X,Y в заштрихованной области.                            *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение переменной X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
double y = Convert.ToDouble(Console.ReadLine());

bool res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

if (res)
{
    Console.WriteLine("Точка находится в заштрихованной области");
}
else
{
    Console.WriteLine("Точка вне заштрихованной области");
}

Console.ReadKey();
