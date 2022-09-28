/*Task 52

Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/

Console.WriteLine("Please enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

int[] arrayArithmeticMean = new int[array.GetLength(1)];


FillArrayRandomNumbers(array);
PrintArray(array);
GetArithmeticMeanOfColumn(array);
Console.WriteLine();


for (int i = 0; i < arrayArithmeticMean.Length; i++)
{
    Console.WriteLine(arrayArithmeticMean[i]);
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

void GetArithmeticMeanOfColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            arrayArithmeticMean[j] += array[i, j];
        }
    }
    for (int i = 0; i < arrayArithmeticMean.Length; i++)
    {
        arrayArithmeticMean[i] = arrayArithmeticMean[i] / array.GetLength(0);
    }
}