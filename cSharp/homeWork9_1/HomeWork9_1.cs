/*Task 64

Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

Console.WriteLine("Please enter N: ");
int end = Convert.ToInt32(Console.ReadLine());
int start = 1;

Console.WriteLine(PrintNumber(start, end));

string PrintNumber(int start, int end)
{
    if (start == end)
    {
        return end.ToString();
    }
    return(end + "," + PrintNumber(start, end - 1));
}