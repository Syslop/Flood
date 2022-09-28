/*Task 53

Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

*/

Console.WriteLine("Please enter count rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter count columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

FillArrayRandomNumbers(array);
PrintArray(array);
Console.WriteLine();
int lastRow = array.GetLength(0) - 1;

for (int j = 0; j < array.GetLength(1); j++)
{
    int tmp = array[0,j];
    array[0,j] = array[lastRow,j];
    array[lastRow,j] = tmp;
}

PrintArray(array);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
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