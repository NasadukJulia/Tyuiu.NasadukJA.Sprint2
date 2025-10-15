using Tyuiu.NasadukJA.Sprint2.Task5.V15.Lib;

// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнила: Насадюк Ю. А. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор Switch                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #15                                                             *");
Console.WriteLine("* Выполнила: Насадюк Юлия Андреевна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует оператор switch, определяет,     *");
Console.WriteLine("* каким днем недели является k-й день не високосного года, в котором      *");
Console.WriteLine("* 1 января понедельник.                                                   *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите номер дня: ");
int numDay = Convert.ToInt32(Console.ReadLine());

string res;

if ((numDay < 1) || (numDay > 365))
{
    res = "Введено неверное значение!";
}
else
{
    res = "День недели : " + ds.FindDayName(numDay);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(res);

Console.ReadKey();
