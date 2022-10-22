// Set variables ...
int m = -1;
int n = -1;

// Clear on start ...
Console.Clear();

// Check that m or n is correct and return it if it's true ...
int CheckArraySize(string incomingString){

    int attr = -1;

    bool mOk = int.TryParse(incomingString, out attr);
    if (!mOk){
        
        Console.WriteLine("Value is not numeric ... ");
        return -1;

    }
    else if(attr <= 0) {

        Console.WriteLine("Value is equal or less than zero ... ");
        return -1;

    }

    return attr;

}

// Get array size from user ...
while(m <= 0 || n <= 0){

    if (m <= 0)
    {
        Console.WriteLine("Set rows count (m):");
        m = CheckArraySize(Console.ReadLine());
    }

    if (n <= 0)
    {
        Console.WriteLine("Set columns count (n):");
        n = CheckArraySize(Console.ReadLine());
    }

}


// Generate and print data ...
Console.Clear();
Console.WriteLine($"It's array with sizes [{m},{n}]:\r\n");
Random rnd = new Random();
double[,] finalArray = new double[m,n];

for(int i = 0; i < m; i++){

    for (int j = 0; j < n; j++)
    {

        finalArray[i, j] = rnd.NextDouble();
        Console.Write(string.Format("{0:0.0000}  ", Math.Round(finalArray[i, j], 4)));

    }

    Console.WriteLine();

}