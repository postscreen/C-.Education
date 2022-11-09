/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3

    Результирующая матрица будет:
    18 20
    15 18

*/

/*
    FUNCTIONS    
*/

// ...
Console.Clear();

// Print array ...
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

// Check that m or n is correct and return it if it's true ...
int CheckArraySize(string incomingString)
{

    int attr = -1;

    bool mOk = int.TryParse(incomingString, out attr);
    if (!mOk)
    {

        Console.WriteLine("Value is not numeric ... ");
        return 0;

    }
    else if (attr <= 0)
    {

        Console.WriteLine("Value is equal or less than zero ... ");
        return 0;

    }

    return attr;

}

// Set Array ...
int[,] setArray(int cols, int rows)
{

    int[,] array = new int[rows, cols];
    Random rnd = new Random();
    Console.Clear();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(1, 10);

    return array;

}

// Function to get single value of multyply two matrices (row * coll)
int singlRowCollMultiply(int[,] first, int[,] second, int firstRow, int secondColl){

    int result = 0;
    for(int i = 0; i < first.GetLength(0); i++)
        result += first[firstRow,i] * second[i,secondColl];

    return result;

}

/*
    APPLICATION 
*/

// Set variables ...
var userData = String.Empty;
Dictionary<string,int> sizeOfMatrices = new Dictionary<string, int>() { {"Coll#1", 0}, {"Row#1", 0}, {"Coll#2", 0}, {"Row#2", 0} };

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

// Create matrices ...
int[,] firstArray = setArray(sizeOfMatrices["Coll#1"], sizeOfMatrices["Row#1"]);
int[,] secondArray = setArray(sizeOfMatrices["Coll#2"], sizeOfMatrices["Row#2"]);

// Show them ...
Console.Clear();
Console.WriteLine("First matrix: ");
printArray(firstArray);
Console.WriteLine("Second matrix: ");
printArray(secondArray);

// If it impossible to calculate or not ...
if(sizeOfMatrices["Coll#1"] == sizeOfMatrices["Row#2"] && sizeOfMatrices["Row#1"] == sizeOfMatrices["Coll#2"]){

    // Calculate multiply of them ...
    int[,] resultMatrix = new int[sizeOfMatrices["Row#1"], sizeOfMatrices["Coll#2"]];

    for(int i = 0; i < sizeOfMatrices["Row#1"]; i++){

        for(int j = 0; j < sizeOfMatrices["Coll#2"]; j++){

            resultMatrix[i,j] = singlRowCollMultiply(firstArray, secondArray, i, j);

        }

    }

    Console.WriteLine("Result of multiply: ");
    printArray(resultMatrix);

} else {

    Console.WriteLine($"Impossible to calculate Coll#1 [{sizeOfMatrices["Coll#1"]}] != Row#2 [{sizeOfMatrices["Row#2"]}]");
    Console.WriteLine();

}
