/* task 10

Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

//int number = new Random().Next(100, 1000);
Console.WriteLine("Please enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Random number = ");
Console.Write(number);
Console.WriteLine();

FindSecondNum(number);

void FindSecondNum(int num1)
{
    int secondNum = (num1 / 10) % 10;

    Console.Write("A desired (second) number = ");
    Console.Write(secondNum);
}