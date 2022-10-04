void GetResult(int firstNumeric, int secondNumeric){


    if(firstNumeric * firstNumeric == secondNumeric){
        Console.WriteLine($"Numeric {secondNumeric} = {firstNumeric}^2");
        return;
    }

    if(secondNumeric * secondNumeric == firstNumeric){
        Console.WriteLine($"Numeric {firstNumeric} = {secondNumeric}^2");
        return;
    }
        
    Console.WriteLine($"It's so bad result =(");

}

GetResult(16, 4);