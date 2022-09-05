/* task 10

Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

int randomNumber = new Random().Next(100, 1000);

Console.Write("Random number = ");
Console.Write(randomNumber);
Console.WriteLine();

int secondNum = (randomNumber / 10) % 10;

Console.Write("A desired (second) number = ");
Console.Write(secondNum);