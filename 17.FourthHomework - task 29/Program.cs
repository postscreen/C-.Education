﻿// Show info about programm ...
Console.WriteLine("Insert array of integers, set comma between numerics: ");

// Set variable for save array ... 
string[] A = new string[0];

// Get data ... 
while (A.Length <= 0)
    A = Console.ReadLine().ToString().Split(',');

Console.WriteLine($"Total count of elements: {A.Length}");

// Show array in the cycle ...
for (int i = 0; i < A.Length; i++){

    int Numeric;
    bool itsNumeric = int.TryParse(A[i], out Numeric);
    if(itsNumeric)
        Console.WriteLine($"Element[{i}] = {A[i]}");
    else
        Console.WriteLine($"Element[{i}] = {A[i]}  [Not critical ERROR, your element isn't numeric!]");

}