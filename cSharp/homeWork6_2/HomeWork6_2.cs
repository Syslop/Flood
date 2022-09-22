/*Task 43

Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/

Console.WriteLine("Please enter k1:");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter b1:");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter b2:");
double b2 = Convert.ToDouble(Console.ReadLine());


GetPointIntersectionStraightLines(k1, b1, k2, b2);

void GetPointIntersectionStraightLines(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine("The point of intersection of the lines has coordinates:");
    Console.WriteLine($"x = {x}");
    Console.WriteLine($"y = {y}");
}