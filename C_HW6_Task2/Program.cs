// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Функция запроса и считывания данных введенных пользователем
double ReadDouble(string msg)
{
    System.Console.Write($"{msg} > ");
    return double.Parse(Console.ReadLine());
}

double b1 = ReadDouble("Введите b1");
double k1 = ReadDouble("Введите к1");
double b2 = ReadDouble("Введите b2");
double k2 = ReadDouble("Введите к2");

if(b1 == b2)
{
    System.Console.WriteLine("Прямые параллельны.");
}
else
{
double x = (b2 - b1) / (k1-k2);
double y = (k1 * x + b1);
    System.Console.WriteLine($"Прямые пересекутся в точке с координатами Х = {x}, Y = {y}.");
}

