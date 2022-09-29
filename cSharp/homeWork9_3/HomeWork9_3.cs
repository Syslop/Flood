/*Task 68

Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/

Console.WriteLine("Please enter M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter N: ");
int numN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Value of Akkerman function equals = {GetAkkermanValue(numM, numN)}");

int GetAkkermanValue(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if (numM > 0 && numN == 0)
    {
        return GetAkkermanValue((numM - 1), 1);
    }
    else if (numM > 0 && numN > 0)
    {
        return GetAkkermanValue((numM - 1), GetAkkermanValue(numM, (numN - 1)));
    }
    return -1;
}