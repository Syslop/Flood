﻿//for hardcode
/*
int firstNumber = 57;
*/

//for code with user
Console.WriteLine("Please enter a number to check for parity:");
int firstNumber = Convert.ToInt32(Console.ReadLine());

if ((firstNumber % 2) == 0)
{
    Console.WriteLine("An even number");
}
else
{
    Console.WriteLine("Odd number");
}