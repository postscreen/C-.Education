/*

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

    Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07

*/

// Clear place after begin ...
Console.Clear();

// ...
void printArray(int[,] arrayToShow)
{

    for (int i = 0; i < arrayToShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToShow.GetLength(1); j++)
            Console.Write(string.Format("{0:00}  ", arrayToShow[i, j]));

        Console.WriteLine();

    }

    Console.WriteLine();

}

// Create array
int sideSize = 4;
int placeSize = sideSize * sideSize;
int[,] A = new int[sideSize,sideSize];

// Coordinates
var C = new (int Row, int Coll)[] {

                        (0,0), (0,1), (0,2), (0,3),
                        (1,3), (2,3), (3,3), (3,2),
                        (3,1), (3,0), (2,0), (1,0),
                        (1,1), (1,2), (2,2), (2,1)

                    };

// Set variables
int v = 1;
int i = 0;
int j = 0;

// Fill array
while(v <= placeSize){

    i = C[v - 1].Row;
    j = C[v - 1].Coll;

    A[i,j] = v;
    v += 1;

}

// Show array
printArray(A);
