/*Task 50

Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

*/

Console.WriteLine("Please enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter number row element: ");
int elementRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number column element: ");
int elementColumn = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

int maxRow = array.GetLength(0);
int maxColumn = array.GetLength(1);

if (elementRow <= maxRow && elementColumn <= maxColumn)
{
    FillArrayRandomNumbers(array);
    PrintArray(array);
    Console.WriteLine(GetElement(array, elementRow - 1, elementColumn - 1));
} 
else
{
    Console.WriteLine("This element not found.");
}


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

int GetElement(int[,] array, int row, int column)
{
    int element = array[row, column];
    return element;
}