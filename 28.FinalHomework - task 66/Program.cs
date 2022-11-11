/*

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30

*/

// Clear place ...
Console.Clear();

// Set N ...
int M = 1;
int N = 9;

// Recursion ...
int sumOfNaturalNumerics(int Min, int Max, int sum = 0)
{

    if (Max == 0) return sum;
    else
    {
        
        sum += Max;
        Max--;
        sum += sumOfNaturalNumerics(Min, Max - 1, sum);
        return sum;

    }

    return sum;

}

// Task solution ... 
int sum = sumOfNaturalNumerics(M, N);
Console.WriteLine(sum);