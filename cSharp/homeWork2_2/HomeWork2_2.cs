/* task 13
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

//A simple solution through type conversion.
int randomNumber = new Random().Next(1, 55555);
int requiredNumberOfCharacters = 3;

Console.Write("Random number = ");
Console.Write(randomNumber);
Console.WriteLine();


string randomNumberStr = Convert.ToString(randomNumber);
int desiredNumber = int.Parse(Convert.ToString(randomNumberStr[requiredNumberOfCharacters - 1]));

Console.Write("The desired number = ");
Console.Write(desiredNumber);

/*
//A complex solution to the problem. Type conversion is not used.
int randomNumber = new Random().Next(1, 55555);

int requiredNumberOfCharacters = 3;
int[] tempNumberArray = new int[requiredNumberOfCharacters];

int remains = randomNumber % 10;
int wholePart = randomNumber / 10;

int iterationCounter = 0;

Console.Write("Random number = ");
Console.Write(randomNumber);
Console.WriteLine();

while ((wholePart != 0)) 
{
    tempNumberArray[0] = 0;
    for (int i = 1; i < tempNumberArray.Length; i++)
    {
        tempNumberArray[i - 1] = tempNumberArray[i];
    }
    tempNumberArray[tempNumberArray.Length - 1] = remains;
    remains = wholePart % 10;
    wholePart = wholePart / 10;
    iterationCounter++;
}
if (requiredNumberOfCharacters - 1 > iterationCounter) 
{
    Console.WriteLine("Number not found.");
} 
else 
{
    Console.Write("The desired number = ");
    Console.Write(tempNumberArray[1]);
}
*/