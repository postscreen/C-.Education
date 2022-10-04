bool repeat = true;
bool taskRepeat = true;

// Task number 10  ... 
void Task10(){

    Console.WriteLine("Pleace insert numeric with three digits to get second digit! Insert ZERO to ESC.");
    int threeDigitsNumeric = 0;

    while(taskRepeat){

        bool itsNumeric = int.TryParse(Console.ReadLine(), out threeDigitsNumeric);

        if(itsNumeric){

            // Check that I got really zero from console ... 
            if(threeDigitsNumeric == 0)
                break;

            if(threeDigitsNumeric >= 100 && threeDigitsNumeric < 1000){
                Console.WriteLine($"Result for numeric {threeDigitsNumeric} = {threeDigitsNumeric.ToString().Substring(1,1)}");
                break;

            } else
                Console.WriteLine("Pleace insert numeric with three digits! Insert ZERO to ESC.");

        } else
            Console.WriteLine("It's not numeric! Insert ZERO to ESC.");

    }    

}

// Task number 13  ... 
void Task13(){

    Int64 incomingNumeric = 0;
    Console.WriteLine("Pleace insert numeric with three or more digits to get third digit! Insert ZERO to ESC.");

    while(taskRepeat){

        bool itsNumeric = Int64.TryParse(Console.ReadLine(), out incomingNumeric);

        if(itsNumeric){

            // Check that I got really zero from console ... 
            if(incomingNumeric == 0)
                break;

            if(incomingNumeric.ToString().Length >= 3)
                Console.WriteLine($"Result for numeric {incomingNumeric} = {incomingNumeric.ToString().Substring(2,1)}");
            else
                Console.WriteLine($"Your numeric haven't third digit. Insert ZERO to ESC.");

        } else
            Console.WriteLine("It's not numeric! Insert ZERO to ESC.");

    }     

}

void Task15(){

    int incomingWeekDay = 0;
    Console.WriteLine("Pleace insert numeric between 1 and 7! Insert ZERO to ESC.");

    while(taskRepeat){

        bool itsNumeric = int.TryParse(Console.ReadLine(), out incomingWeekDay);

        if(itsNumeric){

            // Check that I got really zero from console ... 
            if(incomingWeekDay == 0)
                break;

            if(incomingWeekDay >= 1 && incomingWeekDay <= 5)
                Console.WriteLine($"It's {incomingWeekDay} = we are going to the job! Insert ZERO to ESC.");

            else if (incomingWeekDay >= 6 && incomingWeekDay <= 7)
                Console.WriteLine($"It's {incomingWeekDay} = WEEKEND! Insert ZERO to ESC.");

            else
                Console.WriteLine($"Your numeric out of range [1,7]. Insert ZERO to ESC.");

        }

        else
            Console.WriteLine("It's not numeric! Insert ZERO to ESC.");

    }     

}

while(repeat){

    // Get task number
    Console.WriteLine("Pleace insert task numeric (from tasks page 10, 13, 15): ");
    int taskNumber = int.Parse(Console.ReadLine());

    if (taskNumber == 10)
        Task10();

    if (taskNumber == 13)
        Task13();

    if (taskNumber == 15)
        Task15();

    Console.WriteLine("\tPress ESC to exit APPLICATION or any key to continious ... ");
    var e = Console.ReadKey().Key;
    if(ConsoleKey.Escape == e)
        repeat = false;
    else
        Console.WriteLine("\r\n=======================================================================\r\n");

    Console.Clear();

}