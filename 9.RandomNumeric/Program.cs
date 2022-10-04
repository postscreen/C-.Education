void AnswerToTask(){

    int newNumeric = (new Random()).Next(100,1000);
    Console.WriteLine($"Base numeric: {newNumeric}");    
    string numericAsString = newNumeric.ToString();
    int result = int.Parse(numericAsString[0].ToString() + numericAsString[2].ToString());
    Console.WriteLine($"Result numeric: {result}");

}

AnswerToTask();