/*Task 41

Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

*/

Console.WriteLine("Please enter count number: ");
int countNumber = Convert.ToInt32(Console.ReadLine());

GetQuantityGreaterZero(countNumber);

void GetQuantityGreaterZero(int countNumber)
{
    int quantityGreaterZero = 0;
    int sequenceNumber = 1;
    while (sequenceNumber <= countNumber)
    {
        Console.WriteLine($"Please enter your {sequenceNumber} number:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            quantityGreaterZero++;
        }
        sequenceNumber++;
    }
    Console.WriteLine($"The user entered {quantityGreaterZero} numbers greater than zero");
}