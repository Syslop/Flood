int randomNumber = new Random().Next(10, 100);

Console.Write("Random number = ");
Console.Write(randomNumber);
Console.WriteLine();

int firstNum = randomNumber / 10;
int secondNum = randomNumber % 10;


if (firstNum > secondNum) 
{
    Console.Write("Max number = first number = ");
    Console.Write(firstNum);
}
else 
{
    Console.Write("Max number = second number = ");
    Console.Write(secondNum);
}