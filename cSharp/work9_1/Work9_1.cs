/*Task 63

Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"

Task 65
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"

*/

Console.WriteLine("Please enter number start: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number end: ");
int end = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumber(start, end));

string PrintNumber(long start, long end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return(start + "," + PrintNumber(start + 1, end));
}