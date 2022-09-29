/*Task 56

Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

Console.WriteLine("Please enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

while (rows == columns)
{
    Console.WriteLine("Please change number of columns to enter rectangular matrix: ");
    columns = Convert.ToInt32(Console.ReadLine());
}

int[,] array = new int[rows, columns];


FillArrayRandomNumbers(array);
PrintArray(array);
Console.WriteLine();
GetMinSumArrayRowElement(array);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void GetMinSumArrayRowElement(int[,] array)
{
    int minSumArrayElementInRow = 0;
    int numberRowWithMinSumArrayElement = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumArrayElementInRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArrayElementInRow += array[i, j];
        }
        if (i == 0 || (sumArrayElementInRow < minSumArrayElementInRow))
        {
            minSumArrayElementInRow = sumArrayElementInRow;
            numberRowWithMinSumArrayElement = i;
        }
    }
    Console.WriteLine($"Row with minimal sum element = {numberRowWithMinSumArrayElement}. Sum = {minSumArrayElementInRow}");
}