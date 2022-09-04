//for hardcode
/*
int firstNumber = 8;
int secondNumber = 9;
*/

//for code with user
Console.WriteLine("Please enter first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.Write("max = firstNumber = ");
    Console.Write(firstNumber);
    Console.Write("; min = secondNumber = ");
    Console.Write(secondNumber);
    Console.Write(".");
} 
else
{
    Console.Write("max = secondNumber = ");
    Console.Write(secondNumber);
    Console.Write("; min = firstNumber = ");
    Console.Write(firstNumber);
    Console.Write(".");
}
