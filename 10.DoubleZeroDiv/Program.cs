void ItsGoodNumeric(int BaseNumeric){

    if(BaseNumeric % 7 == 0 && BaseNumeric % 23 == 0)
        Console.WriteLine($"Numeric {BaseNumeric} is divide on 7 and 23 ...");
    else
        Console.WriteLine($"Numeric {BaseNumeric} is bad numeric!");


}

ItsGoodNumeric(161);