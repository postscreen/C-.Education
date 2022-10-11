// Function to get correct data from the user each time ...
int GetNumeric(string msg){

    Console.WriteLine($"{msg}");
    int positiveNumeric;
    bool itsNumeric = int.TryParse(Console.ReadLine(), out positiveNumeric);

    if(itsNumeric)

        if (positiveNumeric >= 0)
            return positiveNumeric;
        else
            Console.WriteLine($"Your numeric is less then zero ... ");

    else
        Console.WriteLine("It's not numeric!");

    return -1;

}

// Set variables ... 
int A = -1, B = -1, result = 1;

// Get two numerics for calculate ... 
while(A < 0 && B < 0){

    A = GetNumeric("Insert A:");
    B = GetNumeric("Insert B:");

}

// Cycle - important parth of the task
for(int i = 1; i <= B; i++)
    result = result * A;


// Print result
Console.WriteLine($"A^B = {result}");