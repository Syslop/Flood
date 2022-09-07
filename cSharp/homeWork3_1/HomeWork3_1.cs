/* Task 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да

*/

//int number = new Random().Next(1, 55555);
Console.WriteLine("Please enter a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

CheckPolydrome(CreateVerificationArray(number));

int[] CreateVerificationArray(int number)
{
    int arraySize = 5;
    int[] verificationArray = new int[arraySize];

    for (int i = 0; i < verificationArray.Length; i++) 
    {
        verificationArray[verificationArray.Length - 1 - i] = number % 10;
        number = number / 10;
    }
    return verificationArray;
}

void CheckPolydrome(int[] verificationArray) 
{
    for (int i = 0; i < verificationArray.Length / 2; i++) 
    {
        if (verificationArray[i] != verificationArray[verificationArray.Length - 1 - i])
        {
            Console.WriteLine("Number is not a polydrom.");
            break;
        }
        if (i == verificationArray.Length / 2 - 1)
        {
            Console.WriteLine("Number is a polydrom.");
        }
    }
}
