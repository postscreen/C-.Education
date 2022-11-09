/*

Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    
    Массив размером 2 x 2 x 2
    66(0,0,0) 25(0,1,0)
    34(1,0,0) 41(1,1,0)
    27(0,0,1) 90(0,1,1)
    26(1,0,1) 55(1,1,1)

*/

// To show it ...
Console.Clear();

// Check that m or n is correct and return it if it's true ...
int CheckArraySize(string incomingString)
{

    int attr = -1;

    bool mOk = int.TryParse(incomingString, out attr);
    if (!mOk)
    {

        Console.WriteLine("Value is not numeric ... ");
        return -1;

    }
    else if (attr <= 0)
    {

        Console.WriteLine("Value is equal or less than zero ... ");
        return -1;

    }

    return attr;

}

// Set variables ...
var userData = String.Empty;
Dictionary<string, int> sizeOfMatrices = new Dictionary<string, int>() { { "X-size", 0 }, { "Y-size", 0 }, { "Z-size", 0 } };

// Get matrices size from user ...
while (sizeOfMatrices.Values.Contains(0))
{

    var currentSize = sizeOfMatrices.First(item => item.Value == 0);
    if (currentSize.Value <= 0)
    {
        Console.WriteLine($"Set size for {currentSize.Key}:");
        userData = Console.ReadLine();
        Console.Clear();
        if (userData != null)
            sizeOfMatrices[currentSize.Key] = CheckArraySize(userData);
    }

}

// Set variables ... 
Random rnd = new Random();
int totalCountOfValue = sizeOfMatrices["X-size"] * sizeOfMatrices["Y-size"] * sizeOfMatrices["Z-size"];
int[,,] A = new int[sizeOfMatrices["X-size"],sizeOfMatrices["Y-size"],sizeOfMatrices["Z-size"]];
int[] used = new int[totalCountOfValue];
//int[] randomNumbers = Enumerable.Range(10, 100).OrderBy(x => rnd.Next()).Take(totalCountOfValue).ToArray();

// Check size ...
if(totalCountOfValue > 90){

    Console.WriteLine($"Impossible to fill array. Need {totalCountOfValue} unique values, but we have only 90  ... ");
    return;

}

// Fill array ... 
for (int i = 0; i < A.GetLength(0); i++){

    for (int j = 0; j < A.GetLength(1); j++){

        for (int k = 0; k < A.GetLength(2); k++){

            bool searching = true;
            while(searching){

                int nextRandomValue = rnd.Next(10, 100);
                int copy = Array.Find(used, item => item == nextRandomValue);
                if (copy < 10)
                {

                    searching = false;
                    A[i, j, k] = nextRandomValue;
                    Console.WriteLine($"{A[i, j, k]} ({i},{j},{k})");

                }

            }

        }

    }

}
