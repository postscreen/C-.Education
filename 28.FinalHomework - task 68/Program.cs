/*

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29

*/

// Clear place ...
Console.Clear();

// Set N ...
int M = 2;
int N = 3;

// Ackerman's function ...
Int64 A(Int64 M, Int64 N) =>
    M == 0 ? N += 1 :
    M > 0 && N == 0 ? A(M-1, 1) :
    M > 0 && N > 0 ? A(M - 1, A(M, N-1)) :
    0;

// Task solution ... 
Console.WriteLine(A(M, N));