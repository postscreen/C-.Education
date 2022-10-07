bool repeat = true;
bool taskRepeat = true;

// Task number 19  ... 
void Task19(){

    Console.WriteLine("Pleace insert numeric with FIVE digits to check PALINDROME state! Insert ZERO to ESC.");
    int fiveDigitsNumeric = 0;

    while(taskRepeat){

        bool itsNumeric = int.TryParse(Console.ReadLine(), out fiveDigitsNumeric);

        if(itsNumeric){

            // Check that I got really zero from console ... 
            if(fiveDigitsNumeric == 0)
                break;

            if(fiveDigitsNumeric >= 10000 && fiveDigitsNumeric < 100000){
                int eachDigit, Reverse = 0;
                int savedNumeric = fiveDigitsNumeric;
                while(fiveDigitsNumeric != 0 ){
                    eachDigit  = fiveDigitsNumeric % 10;
                    Reverse = Reverse * 10 + eachDigit;
                    fiveDigitsNumeric = fiveDigitsNumeric / 10;
                }

                if(savedNumeric == Reverse){
                    Console.WriteLine($"It's PALINDROME! {savedNumeric} = {Reverse}");
                    break;                    
                } else
                    Console.WriteLine($"It's not polindrome ...  {savedNumeric} != {Reverse}");

            } else
                Console.WriteLine("Pleace insert numeric with FIVE digits! Insert ZERO to ESC.");

        } else
            Console.WriteLine("It's not numeric! Insert ZERO to ESC.");

    }

}

// Task number 21  ... 
void Task21(){

    int i = 0;
    Int64[] income = new Int64[6];
    Console.WriteLine("Pleace insert point A(x,y,z) and B(x,y,z)! Set numeric + press 'Enter' and repeat it [exclude 0]");

    while(i <= 5){
        if(Int64.TryParse(Console.ReadLine(), out income[i]) && income[i] != 0){
            Console.WriteLine($"We are have: A({income[0]},{income[1]},{income[2]}) and B({income[3]},{income[4]},{income[5]})");
            i++;
        } else
            Console.WriteLine("It's not valid numeric!");
    }     

    double Dist = Math.Sqrt( Math.Pow(income[3] - income[0], 2) + Math.Pow(income[4] - income[1], 2) + Math.Pow(income[5] - income[2], 2) );
    Console.WriteLine($"Distantion between points = {Dist} units ... ");

}

// Task number 23  ... 
void Task23(){

    int positiveNumeric = 0;
    Console.WriteLine("Pleace insert positive numeric to get list of cubes! Insert ZERO to ESC.");

    while(taskRepeat){

        bool itsNumeric = int.TryParse(Console.ReadLine(), out positiveNumeric);

        if(itsNumeric){

            // Check that I got really zero from console ... 
            if(positiveNumeric == 0)
                break;

            if(positiveNumeric >= 0){
                for(int i =0; i <= positiveNumeric; i++)
                    Console.WriteLine($"{i}^3 => {i*i*i}");
                Console.WriteLine($"Full list of cubes between 0 and {positiveNumeric}. Insert ZERO to ESC.");
            } else
                Console.WriteLine($"Your numeric is less then zero. Insert ZERO to ESC.");

        }

        else
            Console.WriteLine("It's not numeric! Insert ZERO to ESC.");

    }     

}

while(repeat){

    // Get task number
    Console.WriteLine("Pleace insert task numeric (from tasks page 19, 21, 23): ");
    int taskNumber = 0;
    bool itsNumeric = int.TryParse(Console.ReadLine(), out taskNumber);
    if(itsNumeric){

        if (taskNumber == 19)
            Task19();

        else if (taskNumber == 21)
            Task21();

        else if (taskNumber == 23)
            Task23();

        else
            Console.WriteLine("Need to insert 19, 21, 23 ... ");

    } else
        Console.WriteLine("It's not numeric ... Need to insert 19, 21, 23 ... ");

    Console.WriteLine("\r\n\tPress ESC to exit APPLICATION or any key to continious ... ");
    var e = Console.ReadKey().Key;
    if(ConsoleKey.Escape == e)
        repeat = false;
    else
        Console.WriteLine("\r\n=======================================================================\r\n");

    Console.Clear();

}