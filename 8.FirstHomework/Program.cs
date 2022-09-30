bool repeat = true;

while(repeat){

    // Get task number
    Console.WriteLine("Pleace insert task numeric (from tasks page 2, 4, 6, 8): ");
    int taskNumber = int.Parse(Console.ReadLine());

    // Task number 2  ... 
    if (taskNumber == 2){

        Console.Write(" === Search maximum of two value === ");

        Console.Write("Insert first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Insert second number: ");
        int b = int.Parse(Console.ReadLine());

        int max = a > b ? a : b;
        Console.WriteLine(string.Format("Max numeric is: {0}", max));

    }

    if(taskNumber == 4){

        Console.Write(" === Search maximum of three value === ");

        Console.Write("Insert first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Insert second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Insert third number: ");
        int c = int.Parse(Console.ReadLine());    

        int max = a > b ? (a > c ? a : c) : (b > c ? b : c);
        Console.WriteLine(string.Format("Max numeric is: {0}", max));

    }

    if(taskNumber == 6){

        Console.Write("Insert number to check EVEN/UNEVEN state: ");
        int a = int.Parse(Console.ReadLine());
        string Answer = a % 2 == 0 ? "It's EVEN numeric" : "It's UNEVEN numeric";
        Console.WriteLine(Answer);

    }

    if(taskNumber == 8){

        Console.Write("Insert number to show all even numerics before it: ");
        int a = int.Parse(Console.ReadLine());
        int i = 0;
        while(i < a){

            if(i % 2 == 0 && i != 0)
                Console.WriteLine(string.Format("Numeric {0} is EVEN ... ", i));

            i++;

        }

    }

    Console.WriteLine("Press ESC to end or any key to continious ... ");
    var e = Console.ReadKey().Key;
    if(ConsoleKey.Escape == e)
        repeat = false;
    else
        Console.WriteLine("=======================================================================");

}

