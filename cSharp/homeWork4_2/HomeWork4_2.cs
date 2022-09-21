/* Task 27

Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

*/

Console.WriteLine("Please enter number:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of all digits in the number {number} is equal to {GetSumNum(number)}");

int GetSumNum(int number)
{
    int sum = number % 10;
    int wholePart = number / 10;

    while (wholePart != 0)
    {
        sum = sum + wholePart % 10;
        wholePart = wholePart / 10;
    }

    return sum;
}