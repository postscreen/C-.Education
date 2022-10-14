/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] SetArray(int size)
{

    Random rnd = new Random();
    double[] resultArray = new double[size];

    for (int i = 0; i < size; i++)
        resultArray[i] = rnd.NextDouble();

    return resultArray;

}

void PrintArray(double[] array)
{

    Console.WriteLine("\r\nWe have array:");

    for (int i = 0; i < array.Length; i++)
        Console.WriteLine($"{array[i]}");

    Console.WriteLine();

}

(double, double) GetMaxMin(double[] array)
{

    double max = 0;
    double min = 1;

    for (int i = 0; i < array.Length; i++){

        // Get max
        if(max < array[i])
            max = array[i];

        // Get min
        if (min > array[i])
            min = array[i];

    }

    return (max, min);

}

int arraySize = 0;
bool ok = false;
Console.WriteLine("Pleace, set array size:");

while (!ok)
{
    ok = int.TryParse(Console.ReadLine(), out arraySize);
    Console.WriteLine(" Error it's not natural numeric ... Pleace, re-enter value ... ");
}

double[] array = SetArray(arraySize);
(double max, double min) = GetMaxMin(array);

PrintArray(array);

Console.WriteLine($"\r\nDifferents between maximum value ({max}) and minimum value ({min}) = {max-min} ... ");