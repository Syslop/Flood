/* Task 25

Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

*/

Console.WriteLine("Please enter number A:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter number B:");
int numberB = Convert.ToInt32(Console.ReadLine());

RaiseNumberToPower(numberA, numberB);

void RaiseNumberToPower(int number, int power)
{
    Console.WriteLine($"The number {number} in the power {power} is equal to {Math.Pow(number, power)}");
}