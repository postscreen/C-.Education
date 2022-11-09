// Set variables ...
int x = -1;
int y = -1;

// Clear on start ...
Console.Clear();

// Generate array ... 
Random rnd = new Random();
int m = rnd.Next(5, 15);
int n = rnd.Next(5, 15);

int[,] targetArray = new int[m, n];

for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
        targetArray[i, j] = rnd.Next(1, 25);

// Check that m or n is correct and return it if it's true ...
int CheckArraySize(string incomingString)
{

    int attr = -1;

    bool mOk = int.TryParse(incomingString, out attr);
    if (!mOk)
    {

        Console.WriteLine("Value is not numeric ... ");
        return -1;

    }
    else if (attr <= 0)
    {

        Console.WriteLine("Value is equal or less than zero ... ");
        return -1;

    }

    return attr;

}

// Get array size from user ...
var userData = String.Empty;
while (x <= 0 || y <= 0)
{

    if (y <= 0)
    {
        Console.WriteLine("Set row position (y):");
        userData = Console.ReadLine();
        if (userData != null)
            y = CheckArraySize(userData);
    }

    if (x <= 0)
    {
        Console.WriteLine("Set column position (x):");
        userData = Console.ReadLine();
        if (userData != null)        
            x = CheckArraySize(userData);
    }

}

// Clear for final show ...
Console.Clear();

// Show info about chosen element ...
if(targetArray.GetLength(0) >= y && targetArray.GetLength(1) >= x)
    Console.WriteLine($"Element [{y},{x}] = {targetArray[y, x]}");
else
    Console.WriteLine($"Element [{y},{x}] in not in the target array ... =(");

// Show hidden array ...
Console.WriteLine($"Hidden array size is [{m},{n}] ...\r\n");
for (int i = 0; i < m; i++)
{

    for (int j = 0; j < n; j++){

        if(i == y && j == x)
            Console.ForegroundColor = ConsoleColor.Red;
        else
            Console.ForegroundColor = ConsoleColor.Black;

        Console.Write(string.Format("{0:00}  ", targetArray[i, j]));

    }

    Console.WriteLine();

}

Console.WriteLine();