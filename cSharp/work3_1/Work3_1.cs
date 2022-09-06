/* task 18

Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

*/

Console.WriteLine("Please enter quarter number: ");
int quarterNumber = Convert.ToInt32(Console.ReadLine());

GetCoordinate(quarterNumber);

void GetCoordinate(int quarterNumber)
{
    if (quarterNumber == 1) 
    {
        Console.WriteLine("x > 0, y > 0"); 
    } 
    else if (quarterNumber == 2) 
    {
        Console.WriteLine("x < 0, y > 0"); 
    } 
    else if (quarterNumber == 3) 
    {
        Console.WriteLine("x < 0, y < 0"); 
    } 
    else if (quarterNumber == 4) 
    {
        Console.WriteLine("x > 0, y < 0"); 
    }
    else
    {
        Console.WriteLine("Please enter the correct quarter!"); 
    } 
}