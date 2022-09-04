//for hardcode
/*
int firstNumber = 57;
*/

//for code with user
Console.WriteLine("Please enter number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("All even numbers up to the entered number:");

int startNumber = 2;

while (startNumber <= firstNumber)
{
    Console.Write(startNumber);
    Console.Write("  ");
    startNumber += 2;
}