/*

    Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
    заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/

// To show conditions ...
void showConditions() =>
    Console.WriteLine("We are have [y = k1 * x + b1] and [y = k2 * x + b2] ... ");

// To calculate inspections point ...
(double,double) getInspectionPoint(double k1, double k2, double b1, double b2){

    double x =  (b2 - b1) / (k1 - k2);
    double y = (k1 * x) + b1;

    return (x, y);

}

// Clear terminal ...
Console.Clear();

// Set data storage ...
string[] dotNames = new string[4] { "k1", "k2", "b1", "b2" };
double[] dotValues = new double[4] { 1, 0, 1, 0 };

// Show conditions after start ...
showConditions();

// Collect points ...
int i = 0;
while( i < dotNames.Length ){

    Console.WriteLine($"Insert {dotNames[i]} = ");
    bool itsDouble = double.TryParse(Console.ReadLine(), out dotValues[i]);

    if(itsDouble)
        i++;
    else
        Console.WriteLine("Itsn't numeric ... Re enter pls ... ");

    if(dotValues[0] == dotValues[1] && dotValues[2] == dotValues[3]){

        i = 0;
        Console.WriteLine($"Your functions if equal (k1 = k2 and b1 = b2) ... Re-enter pls ... ");

    }

    if (dotValues[0] == dotValues[1])
    {

        i = 0;
        Console.WriteLine($"Your k1 = k2 with various b1/b2, it's parallel charts ... Re-enter pls ... ");

    }
}

// Get inspections points ... 
(double x, double y) = getInspectionPoint(dotValues[0], dotValues[1], dotValues[2], dotValues[3]);

// Show and format total result of executions ...
Console.Clear();
showConditions();
Console.WriteLine($"\r\n\tk1 = {dotValues[0]}, k2 = {dotValues[1]}, b1 = {dotValues[2]}, b2 = {dotValues[3]}");
Console.WriteLine($"\tInspection point is Z( {x} ; {y} ) ... \r\n\r\n");