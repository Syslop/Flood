/* Task 2.

Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

*/

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
