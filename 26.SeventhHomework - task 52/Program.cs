// Set variables ...
int m = -1;
int n = -1;

// Clear on start ...
Console.Clear();

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
while (m <= 0 || n <= 0)
{

    if (m <= 0)
    {
        Console.WriteLine("Set rows count (m):");
        userData = Console.ReadLine();
        if (userData != null)        
            m = CheckArraySize(userData);
    }

    if (n <= 0)
    {
        Console.WriteLine("Set columns count (n):");
        userData = Console.ReadLine();
        if (userData != null)
            n = CheckArraySize(userData);
    }

}

// Generatem print data ...
Console.Clear();
Console.WriteLine($"It's array with sizes [{m},{n}]:\r\n");
Random rnd = new Random();
int[,] targetArray = new int[m, n];
double[] averageValue = new double[n];

for (int i = 0; i < m; i++)
{

    for (int j = 0; j < n; j++)
    {

        targetArray[i, j] = rnd.Next(1,10);
        Console.Write(string.Format("{0:00}  ", targetArray[i, j], 4));
        averageValue[j] += targetArray[i, j];

    }

    Console.WriteLine();

}

// Show average value of each column's values
Console.WriteLine();
for (int i = 0; i < n; i++)
    Console.WriteLine(string.Format("Column {1} average value of elements {0:0.0000}", Math.Round(averageValue[i] / m, 4), i));
