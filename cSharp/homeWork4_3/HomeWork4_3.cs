/* Task 29

Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/

int[] arrayNumber = new int[8];

ArrayPrint(arrayNumber);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Array after fill:");
ArrayFill(arrayNumber);
Console.WriteLine();
ArrayPrint(arrayNumber);

void ArrayFill(int[] arrayNumber)
{
    for (int i = 0; i < arrayNumber.Length; i++)
    {
        arrayNumber[i] = new Random().Next(1, 100);
        Console.WriteLine($"Element №{i} equal {arrayNumber[i]}");
    }
}

void ArrayPrint(int[] arrayNumber)
{
    for (int i = 0; i < arrayNumber.Length; i++)
    {
        Console.Write(arrayNumber[i]);

        if (i == arrayNumber.Length - 1) 
        {
            break;
        }

        Console.Write(", ");
    }
}