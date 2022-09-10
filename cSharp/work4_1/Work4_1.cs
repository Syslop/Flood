/*Task 1

Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5


*/

Console.WriteLine("Please enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Count number = {GetCountNumber()}");

int GetCountNumber()
{
    int countNumber = 1;
    int wholePart = number / 10;

    while (wholePart != 0)
    {
        wholePart = wholePart / 10;
        countNumber++;
    }
    return countNumber;
}