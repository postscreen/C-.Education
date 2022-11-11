/*

Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    N = 5 -> "5, 4, 3, 2, 1"
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

// Clear place ...
Console.Clear();

// Set N ...
int N = 3;

// Recursion ...
void showNaturalNumerics(int Max){

    if(Max == 0) return;
    else {

        Console.WriteLine($"{Max}");
        showNaturalNumerics(Max-1);

    }

}

// Task solution ... 
showNaturalNumerics(N);