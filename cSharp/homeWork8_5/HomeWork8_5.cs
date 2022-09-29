/*Task 62

Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/

Console.WriteLine("Please enter size of array (if 4x4 then size =4): ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[sizeArray, sizeArray];

PrintArray(GetSpireArray(sizeArray));

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

int[,] GetSpireArray(int sizeArray)
{
    var spireArray = new int[sizeArray, sizeArray];
    for (int currentChar = 1, padding = 0; padding < sizeArray / 2; padding++)
    {
        for (int j = padding; j < sizeArray - padding; j++)
        {
            spireArray[padding, j] = currentChar;
            currentChar++;
        }

        for (int i = padding + 1; i < sizeArray - padding - 1; i++)
        {
            spireArray[i, sizeArray - padding - 1] = currentChar;
            currentChar++;
        }

        for (int j = padding; j < sizeArray - padding; j++)
        {
            spireArray[sizeArray - padding - 1, sizeArray - j - 1] = currentChar;
            currentChar++;
        }

        for (int i = padding + 1; i < sizeArray - padding - 1; i++)
        {
            spireArray[sizeArray - i - 1, padding] = currentChar;
            currentChar++;
        }
    }
    if (sizeArray % 2 != 0) 
    {
        spireArray[(sizeArray)/2, (sizeArray)/2] = spireArray[(sizeArray)/2, (sizeArray - 2)/2] + 1;
    }
    return spireArray;
}