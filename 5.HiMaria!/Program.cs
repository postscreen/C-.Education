﻿Console.WriteLine("Pleace insert name ... ");
string UserName = Console.ReadLine();

if(UserName == "Maria"){

    Console.WriteLine("Great! It's Maria!");

} else {

    Console.WriteLine(string.Format("Hi, {0}!", UserName));

}