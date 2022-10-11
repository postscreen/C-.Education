// Function to get correct data from the user each time ...
Int64 GetNumeric(string msg){

    Console.WriteLine($"{msg}");
    Int64 positiveNumeric;
    bool itsNumeric = Int64.TryParse(Console.ReadLine(), out positiveNumeric);

    if(itsNumeric)

        if (positiveNumeric >= 0)
            return positiveNumeric;
        else
            Console.WriteLine($"Your numeric is less then zero ... ");

    else
        Console.WriteLine("It's not numeric!");

    return -1;

}

Console.WriteLine("Insert A and B to get A^B ... ");

// Set variables ... 
Int64 A = -1, B = -1, result = 1;

// Get two numerics for calculate ... 
while(A < 0 || B < 0){

    if(A < 0)
        A = GetNumeric("Insert natural A:");
    
    if(B < 0)
        B = GetNumeric("Insert natural B:");

}

// Cycle - important parth of the task
for(int i = 1; i <= B; i++)
    result = result * A;

// Print result
Console.WriteLine($"{A}^{B} = {result}");