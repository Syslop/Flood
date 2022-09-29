/*Task 69

Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8

*/

Console.WriteLine("Enter number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(PrintNumber(num1, num2));

int PrintNumber(int num, int rank)
{
    if (rank == 0)
    {
        return 1;
    }
    if (rank == 1)
    {
        return num;
    }
    return(num * PrintNumber(num, rank - 1));
}