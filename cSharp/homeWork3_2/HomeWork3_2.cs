/* Task 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

*/

Console.WriteLine("Please enter x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double length = Math.Sqrt(Math.Pow(GetDelta(x1, x2), 2) + Math.Pow(GetDelta(y1, y2), 2) + Math.Pow(GetDelta(z1, z2), 2));

Console.Write("Length = ");
Console.Write(length);

int GetDelta(int num1, int num2)
{
    int delta = num1 - num2;
    return delta;
}