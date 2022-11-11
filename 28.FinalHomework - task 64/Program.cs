/*

Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    N = 5 -> "5, 4, 3, 2, 1"
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

// Clear place ...
Console.Clear();

// Set N ...
int N = 10;

// Recursion ...
void showNaturalNumerics(int Max, int i = 0){

    if(Max == 0) return;
    else {

        Console.WriteLine($"Iteration {i}: {Max}");
        showNaturalNumerics(Max-1, i+1);

    }

}

// Task solution ... 
showNaturalNumerics(N);