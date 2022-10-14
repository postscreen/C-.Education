/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] SetArray(int size)
{

    Random rnd = new Random();
    int[] resultArray = new int[size];

    for (int i = 0; i < size; i++)
        resultArray[i] = rnd.Next(1, 10);

    return resultArray;

}

void PrintArray(int[] array)
{

    Console.WriteLine("\r\nWe have array:");

    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();

}

int CheckNoEvenSum(int[] array)
{

    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 != 0)
            sum += array[i];

    return sum;

}

int arraySize = 0;
bool ok = false;
Console.WriteLine("Pleace, set array size:");

while (!ok)
{
    ok = int.TryParse(Console.ReadLine(), out arraySize);
    Console.WriteLine(" Error it's not natural numeric ... Pleace, re-enter value ... ");
}

int[] array = SetArray(arraySize);
int resultCount = CheckNoEvenSum(array);

PrintArray(array);

Console.WriteLine($"\r\nTotal sum of no even elements - {resultCount} ... ");