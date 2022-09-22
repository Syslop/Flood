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

void ArrayFill(int[] arrayNumber)
{
    for (int i = 0; i < arrayNumber.Length; i++)
    {
        arrayNumber[i] = new Random().Next(-5, 6);
        Console.Write($"{arrayNumber[i]} ");
    }
}