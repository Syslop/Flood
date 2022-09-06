/* task 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

*/
Console.WriteLine("Please enter x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

int length = (int)Math.Sqrt(GetDelta(x1, x2)*GetDelta(x1, x2) + GetDelta(y1, y2)*GetDelta(y1, y2));

Console.Write("Length = ");
Console.Write(length);

int GetDelta(int num1, int num2)
{
    int delta = num1 - num2;
    return delta;
}