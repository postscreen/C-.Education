/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
    
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

/*
    FUNCTIONS    
*/

// ...
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

// Set Array ...
int[,] setArray(int cols, int rows){

    int[,] array = new int[rows, cols];
    Random rnd = new Random();
    Console.Clear();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(1, 10);

    return array;

}

/*
    APPLICATION 
*/

// Set variables ...
int x = 0;
var userData = String.Empty;

// Get array size from user ...
while (x <= 0)
{

    Console.Clear();
    if (x <= 0)
    {
        Console.WriteLine("Set square array size - single number:");
        userData = Console.ReadLine();
        if (userData != null)
            x = CheckArraySize(userData);
    }

}

// Prepare
int[,] array = setArray(x, x);
Console.Clear();
Console.WriteLine($"Base array [{x},{x}]:\r\n");

// currentRowSum, currentMinSum, currentMinRow
(int, int, int) sumOfTheStringData = (0, int.MaxValue, 0);

// Calculate 
for (int i = 0; i < array.GetLength(0); i++){

    sumOfTheStringData.Item1 = 0;
    for (int j = 0; j < array.GetLength(1); j++){
        sumOfTheStringData.Item1 += array[i, j];
        Console.Write($"{array[i, j]} ");
    }

    Console.WriteLine($"[Sum = {sumOfTheStringData.Item1}, Row = {i+1}]");

    if(sumOfTheStringData.Item1 < sumOfTheStringData.Item2){
        sumOfTheStringData.Item2 = sumOfTheStringData.Item1;
        sumOfTheStringData.Item3 = i;
    }

}

// Show result ... 
int Row = sumOfTheStringData.Item3;
Console.WriteLine($"\r\nThe row where sum of all elements is minimum = {Row+1}\r\n");
