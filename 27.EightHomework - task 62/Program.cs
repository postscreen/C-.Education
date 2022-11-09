/*

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

    Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07

*/

// ...
Console.Clear();

// ...
void printArray(int[,] arrayToShow)
{

    for (int i = 0; i < arrayToShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToShow.GetLength(1); j++)
            Console.Write($"{arrayToShow[i, j]} ");

        Console.WriteLine();

    }

    Console.WriteLine();

}

// Create array


// Show array
