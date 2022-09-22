/* Task 34

Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/
Console.WriteLine("Please enter array length: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int[] arrayNumber = new int[arrayLength];

Console.WriteLine("Array after fill:");
ArrayFill(arrayNumber);
Console.WriteLine();
GetCountEvenNumbers(arrayNumber);

void ArrayFill(int[] arrayNumber)
{
    for (int i = 0; i < arrayNumber.Length; i++)
    {
        arrayNumber[i] = new Random().Next(100, 1000);
        Console.Write($"{arrayNumber[i]} ");
    }
}

void GetCountEvenNumbers(int[] arrayNumber)
{
    int count = 0;
    for (int i = 0; i < arrayNumber.Length; i++)
    {
        if ((arrayNumber[i] % 2) == 0) 
        {
            count++;
        }
    }
    Console.WriteLine($"Count of even number = {count}");
}

