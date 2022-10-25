/*

    Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223-> 3

*/

(int, int) GetNumeric(int PositiveCounter = 0, int TotatCounter = 0)
{

    // Clear screen before start each times ...
    Console.Clear();

    // Show info and current state ...
    Console.WriteLine($"Pleace, insert numeric or \"q\" to exit (Positive = {PositiveCounter}, Total = {TotatCounter}): ");
    int usersNumeric = 0;

    // Get string by the user and check, maybe user need to stop it ...
    string? usersInput  = Console.ReadLine();
    if(usersInput == "q")
        return (0,0);

    // Increase counter if user enter correct numeric ...
    bool itsNumeric = int.TryParse(usersInput, out usersNumeric);
    if (itsNumeric)
    {

        TotatCounter++;
        if (usersNumeric > 0)
            PositiveCounter++;

    }

    // Continious go to the M count of numerics ...
    return GetNumeric(PositiveCounter, TotatCounter);

}

GetNumeric();