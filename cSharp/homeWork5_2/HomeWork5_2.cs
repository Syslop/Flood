/*Task 36

Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

*/

Console.WriteLine("Please enter array length: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int[] arrayNumber = new int[arrayLength];

Console.WriteLine("Array after fill:");
ArrayFill(arrayNumber);
Console.WriteLine();
GetSumElements(arrayNumber);

void ArrayFill(int[] arrayNumber)
{
    for (int i = 0; i < arrayNumber.Length; i++)
    {
        arrayNumber[i] = new Random().Next(-5, 6);
        Console.Write($"{arrayNumber[i]} ");
    }
}

void GetSumElements(int[] arrayNumber)
{
    int numberOfElement = 1;
    int sum = 0;

    while (numberOfElement < arrayNumber.Length)
    {
        sum = sum + arrayNumber[numberOfElement];
        numberOfElement = numberOfElement + 2;
    }
    Console.WriteLine($"Sum of odd elements = {sum}");
}