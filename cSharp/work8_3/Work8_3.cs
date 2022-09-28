/*Task 57

Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Набор данных
{ 1, 9, 9, 0,
2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза

*/



Console.WriteLine("Please enter count rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter count columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
int[] checkArray = new int[array.Length];
//int checkArrayPosition = 0;

//FillArrayRandomNumbers(array);
//PrintArray(array);

//Console.WriteLine();

//PrintDictionary(array);

//1

void PrintDictionary(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (!Contain(array[i,j]))
            {
                System.Console.WriteLine($"Element {array[i,j]} meet {GetCount(array[i,j])}");
            }
        }
    }
}

bool Contain(int num)
{
    for (int i = 0; i <= checkArrayPosition; i++)
    {
        if (num == checkArray[i]) 
        {
             return true;
        } 
        else
        {
            checkArray[checkArrayPosition] = num;
            checkArrayPosition++;
            return false;
        } 
    }
    return false;
}

int GetCount(int num)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (num == array[i, j])
            {
                count++;
            }
        }
    }
    return count;
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

//2

void PrintDictionary(int[,] array)
{
    Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int value;
            if(keyValuePairs.TryGetValue(array[i,j], out value))
            {
                keyValuePairs[array[i,j]]++;
            }
            else
            {
                keyValuePairs.Add(array[i,j], 1);
            }
        }
    }

    foreach(var element in keyValuePairs)
    {
        Console.WriteLine($"Element {element.Key} meet {element.Value}");
    }
}