/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Введите координаты для первой прямой:");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты для второй прямой:");
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());
double x;
double y;

void CreateArray()
{
if (k1 != k2)
{
    x = ((b1 - b2) / (k2 - k1));
    y = k1 * x + b1;
    Console.WriteLine($"Точки пересечения двух прямых [{Math.Round(x,2)}; {Math.Round(y,2)}]");
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые совпадают или параллельны");
}
else
{
    Console.WriteLine("Точек пересечения нет");
}
}
CreateArray();





