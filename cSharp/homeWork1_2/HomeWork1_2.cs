int firstNumber = 57;
int secondNumber = 56;
int thirdNumber = 11;


if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber) 
    {
        Console.Write("max = firstNumber = ");
        Console.Write(firstNumber);
        Console.Write(".");
    } 
    else
    {
        Console.Write("max = thirdNumber = ");
        Console.Write(thirdNumber);
        Console.Write(".");
    } 
} 
else
{
    if (secondNumber > thirdNumber) 
    {
        Console.Write("max = secondNumber = ");
        Console.Write(secondNumber);
        Console.Write(".");
    } 
    else
    {
        Console.Write("max = thirdNumber = ");
        Console.Write(thirdNumber);
        Console.Write(".");
    } 
}