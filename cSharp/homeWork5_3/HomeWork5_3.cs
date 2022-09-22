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
Console.WriteLine($"Delta of max and min elements in array = {GetDeltaMinAndMax(arrayNumber)}");

void ArrayFill(double[] arrayNumber)
{
    for (int i = 0; i < arrayNumber.Length; i++)
    {
        double number = new Random().NextDouble();
        arrayNumber[i] = Math.Round(number * 10000) / 100.0;
        Console.Write($"{arrayNumber[i]} ");
    }
}

double GetDeltaMinAndMax(double[] arrayNumber)
{
    double min = arrayNumber[0];
    double max = arrayNumber[0];
    double delta = 0.0;
    for (int i = 1; i < arrayNumber.Length; i++)
    {
        if (arrayNumber[i] <= min)
        {
            min = arrayNumber[i];
        }
        if (arrayNumber[i] >= max)
        {
            max = arrayNumber[i];
        }
    }
    delta = max - min;
    return delta;
}