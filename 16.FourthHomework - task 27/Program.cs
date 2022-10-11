// Function to get correct values from user ...
string GetNumeric(string msg)
{

    Console.WriteLine($"{msg}");
    int positiveNumeric;
    bool itsNumeric = int.TryParse(Console.ReadLine(), out positiveNumeric);

    if (itsNumeric)

        if (positiveNumeric >= 0)
            return positiveNumeric.ToString();
        else
            Console.WriteLine($"Your numeric is less then zero ... ");

    else
        Console.WriteLine("It's not numeric!");

    return string.Empty;

}

// Set variables ... 
int result = 0;
string A = string.Empty;

// Get numeric as string ... 
while (A.Length <= 0)
    A = GetNumeric("Insert numeric to sum of digits:");

// Get sum of digits to using a 'for' cycle ...
for (int i = 0; i < A.Length; i++)
    result = result + int.Parse(A[i].ToString());

// Print result ...
Console.WriteLine(result);