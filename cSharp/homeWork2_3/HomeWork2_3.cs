/* task 15

Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/

Console.WriteLine("Please enter number day of week: ");
FindWeekend();

void FindWeekend()
    {
    bool correctnessFlag = true;
    while (correctnessFlag)
        {
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        if (dayNumber < 1 || dayNumber > 7) 
        {
            Console.WriteLine("Please enter correct number day of week: ");
        } 
        else if (dayNumber == 6 || dayNumber == 7) 
        {
            Console.WriteLine("Day is weekend.");
            correctnessFlag = false;
        } 
        else
        {
            Console.WriteLine("Day is not weekend.");
            correctnessFlag = false;
        }
    }
}