/*Task 54

Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

*/


Console.WriteLine("Please enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

int[] arrayArithmeticMean = new int[array.GetLength(1)];


FillArrayRandomNumbers(array);
PrintArray(array);
Console.WriteLine();
ArraySort(array);
Console.WriteLine();
PrintArray(array);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100);
        }
    }
}

void ArraySort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int maxElement;
        int tmpColumn;
        for (int j = 1; j < array.GetLength(1); j++)
        {
            maxElement = array[i,j];
            tmpColumn = j;
            while (tmpColumn > 0 && array[i, tmpColumn - 1] < maxElement)
            {
                int tempElement = array[i, tmpColumn];
                array[i, tmpColumn] = array[i, tmpColumn - 1];
                array[i, tmpColumn - 1] = tempElement;
                tmpColumn -= 1;
            }
            array[i, tmpColumn] = maxElement;
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