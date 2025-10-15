using Tyuiu.NasadukJA.Sprint2.Task3.V6.Lib;

// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнила: Насадюк Ю. А. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнила: Насадюк Юлия Андреевна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
Console.WriteLine("* использованием вложенных оператор if - else, где пользователь вводит    *");
Console.WriteLine("* значение переменной X с клавиатуры.                                     *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение переменной X: ");
double x = Convert.ToDouble(Console.ReadLine());

double res = ds.Calculate(x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Значение функции = " + res);

Console.ReadKey();

