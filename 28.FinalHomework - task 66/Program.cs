/*

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30

*/

// Clear place ...
Console.Clear();

// Set N ...
int m = 1;
int n = 15;

// Recursion ...
int sumOfNaturalNumerics(int Min, int Max) => Max == 0 ?  0 : sumOfNaturalNumerics(Min, Max - 1) + Max;

// Task solution ... 
Console.WriteLine(sumOfNaturalNumerics(m, n));
Console.ReadKey();