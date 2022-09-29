/*Task 66

Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

Console.WriteLine("Please enter M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int sum = 0;

if (numM > numN)
{
    int temp = numM;
    numM = numN;
    numN = temp;
    Console.WriteLine($"Sum all natural number M = {numN} to N = {numM} equals {GetSum(numM, numN, sum)}");
} 
else
{
    Console.WriteLine($"Sum all natural number M = {numM} to N = {numN} equals {GetSum(numM, numN, sum)}");
}

int GetSum(int numM, int numN, int sum)
{
    if (numM == numN)
    {
        return sum += numM;
    }
    return(GetSum(numM + 1, numN, sum + numM));
}