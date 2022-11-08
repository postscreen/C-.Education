// Print array ...
void printArray(int[,] arrayToShow){

    for (int i = 0; i < arrayToShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToShow.GetLength(1); j++)
            Console.Write($"{arrayToShow[i, j]} ");

        Console.WriteLine();

    }

    Console.WriteLine();

}

// Sort array ...
int[,] sortArray(int[,] arrayToSort){

    int[,] sortedArrayData = new int[arrayToSort.GetLength(0), arrayToSort.GetLength(1)];
    for (int i = 0; i < arrayToSort.GetLength(0); i++){

        for (int collectID = 0; collectID < arrayToSort.GetLength(1); collectID++){

            int maxID = 0;
            for (int j = 0; j < arrayToSort.GetLength(1); j++)
                if (arrayToSort[i, j] > arrayToSort[i, maxID])
                    maxID = j;

            sortedArrayData[i, collectID] = arrayToSort[i, maxID];
            arrayToSort[i,maxID] = 0;

        }

    }

    return sortedArrayData;

}

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
int m = 0;
int n = 0;
var userData = String.Empty;

// Get array size from user ...
while (m <= 0 || n <= 0)
{

    if (m <= 0)
    {
        Console.WriteLine("Set rows count (m):");
        userData = Console.ReadLine();
        if(userData != null)
            m = CheckArraySize(userData);
    }

    if (n <= 0)
    {
        Console.WriteLine("Set columns count (n):");
        userData = Console.ReadLine();
        if (userData != null)
            n = CheckArraySize(userData);
    }

}

int[,] array = new int[m, n];
Random rnd = new Random();
Console.Clear();

for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = rnd.Next(1, 10);

Console.WriteLine($"Base array [{m} x {n}]: ");

printArray(array);
array = sortArray(array);

Console.WriteLine($"Sorted array: [{m} x {n}]");
printArray(array);

