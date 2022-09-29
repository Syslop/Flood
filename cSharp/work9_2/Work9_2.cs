/*Task 67

Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9

*/

Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(PrintNumber(num));
int PrintNumber(int num)
{
    if (num == 0)
    {
        return 0;
    }
    return(num % 10 + PrintNumber(num / 10));
}