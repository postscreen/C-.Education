/*

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29

*/

// Check that m or n is correct ...
int checkUserData(string incomingString)
{

    int attr = -1;

    bool mOk = int.TryParse(incomingString, out attr);
    if (!mOk)
    {

        Console.WriteLine("Value is not numeric ... ");
        return -1;

    }
    else if (attr < 0)
    {

        Console.WriteLine("Value is less than zero ... ");
        return -1;

    }

    return attr;

}

// Clear place ...
Console.Clear();

// Set data ...
(double M, double N) Data = (-1,-1);
string userData = String.Empty;

// Ackerman's function ...
double A(double M, double N) =>
    M == 0 ? N += 1 :
    M > 0 && N == 0 ? A(M-1, 1) :
    M > 0 && N > 0 ? A(M - 1, A(M, N-1)) :
    0;

// User interface ...
while (Data.M < 0 || Data.N < 0)
{

    Console.Clear();
    if (Data.M < 0)
    {
        Console.WriteLine("Set M:");
        userData = Console.ReadLine();
        if (userData != null)
            Data.M = checkUserData(userData);
    }

    if (Data.N < 0)
    {
        Console.WriteLine("Set N:");
        userData = Console.ReadLine();
        if (userData != null)
            Data.N = checkUserData(userData);
    }    

}

// Task solution ... 
Console.Clear();
Console.WriteLine($"Ackerman's function A(M={Data.M}, N={Data.N}) = {A(Data.M, Data.N)}");
Console.ReadKey();