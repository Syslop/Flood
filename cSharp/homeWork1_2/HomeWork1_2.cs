//for hardcode
/*
int firstNumber = 57;
int secondNumber = 56;
int thirdNumber = 11;
*/

//for code with user
Console.WriteLine("Please enter first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter third number:");
int thirdNumber = Convert.ToInt32(Console.ReadLine());


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