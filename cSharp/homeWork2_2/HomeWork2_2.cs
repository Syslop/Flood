//A complex solution to the problem. Type conversion is not used.
int randomNumber = new Random().Next(1, 55555);

int requiredNumberOfCharacters = 3;
int[] tempNumberArray = new int[requiredNumberOfCharacters];

int remains = randomNumber % 10;
int wholePart = randomNumber / 10;

int iterationCounter = 0;

Console.WriteLine(randomNumber);

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
    Console.WriteLine(tempNumberArray[1]);
}
