int MinMax(int num1, int num2) 
{
    int max = 0;
    if (num1 > num2) 
    {
        max = num1;
    }
    else 
    {
        max = num2;
    }
    return max;
}

int randomNumber = new Random().Next(10, 100);

Console.Write("Random number = ");
Console.Write(randomNumber);
Console.WriteLine();

int firstNum = randomNumber / 10;
int secondNum = randomNumber % 10;

Console.Write("Max number = ");
Console.Write(MinMax(firstNum, secondNum));