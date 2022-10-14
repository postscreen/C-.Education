/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] SetArray(int size){

    Random rnd = new Random();
    int[] resultArray = new int[size];

    for(int i = 0; i < size; i++)
        resultArray[i] = rnd.Next(100, 1000);

    return resultArray;

}

void PrintArray(int[] array){

    Console.WriteLine("\r\nWe have array:");

    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();

}

int CheckEvenNumerics(int[] array){

    int counter = 0;

    for (int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            counter++;

    return counter;    

}

int arraySize = 0;
bool ok = false;
Console.WriteLine("Pleace, set array size:");

while(!ok){
    ok = int.TryParse(Console.ReadLine(), out arraySize);
    Console.WriteLine(" Error it's not natural numeric ... Pleace, re-enter value ... ");    
}

int[] array = SetArray(arraySize);
int resultCount = CheckEvenNumerics(array);

PrintArray(array);

Console.WriteLine($"\r\nTotal count of even elements - {resultCount} ... ");