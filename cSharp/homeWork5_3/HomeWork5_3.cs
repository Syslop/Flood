/*Task 38

Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/

Console.WriteLine("Please enter array length: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

double[] arrayNumber = new double[arrayLength];

Console.WriteLine("Array after fill:");
ArrayFill(arrayNumber);
Console.WriteLine();

void ArrayFill(double[] arrayNumber)
{
    for (int i = 0; i < arrayNumber.Length; i++)
    {
        double number = new Random().NextDouble();
        arrayNumber[i] = Math.Round(number * 10000) / 100.0;
        Console.Write($"{arrayNumber[i]} ");
    }
}