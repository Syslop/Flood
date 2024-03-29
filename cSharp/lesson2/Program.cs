﻿int Max(int[] array)
{
    int result = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > result) result = array[i];
    }
    return result;
}


//for hardcode

int firstNumber = 57;
int secondNumber = 56;
int thirdNumber = 11;
int fourthNumber = 31;
int fifthNumber = 41;
int sixthNumber = 61;
int seventhNumber = 71;
int eighthNumber = 81;
int ninthNumber = 91;



//for code with user
/*
Console.WriteLine("Please enter first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter third number:");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter fourthNumber number:");
int fourthNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter fifthNumber number:");
int fifthNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter sixthNumber number:");
int sixthNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter seventhNumber number:");
int seventhNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter eighthNumber number:");
int eighthNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter ninthNumber number:");
int ninthNumber = Convert.ToInt32(Console.ReadLine());
*/

//Array
int[] array = {firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber, sixthNumber, seventhNumber, eighthNumber, ninthNumber};


/*
int max = firstNumber;

//a direct solution in the forehead

if (secondNumber > max) max = secondNumber;
if (thirdNumber > max) max = thirdNumber;
if (fourthNumber > max) max = fourthNumber;
if (fifthNumber > max) max = fifthNumber;
if (sixthNumber > max) max = sixthNumber;
if (seventhNumber > max) max = seventhNumber;
if (eighthNumber > max) max = eighthNumber;
if (ninthNumber > max) max = ninthNumber;
*/

/*
//basic function
int max1 = Max(firstNumber, secondNumber, thirdNumber);
int max2 = Max(fourthNumber, fifthNumber, sixthNumber);
int max3 = Max(seventhNumber, eighthNumber, ninthNumber);
int max = Max(max1, max2, max3);

//int max = Max(Max(firstNumber, secondNumber, thirdNumber), Max(fourthNumber, fifthNumber, sixthNumber), Max(seventhNumber, eighthNumber, ninthNumber));
*/
int max = Max(array);

Console.WriteLine(max);