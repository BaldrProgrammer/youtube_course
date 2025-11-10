double first = Convert.ToDouble(Console.ReadLine());
string? mathoperator = Console.ReadLine();
double second = Convert.ToDouble(Console.ReadLine());

if (mathoperator == "+")
{
    Console.WriteLine("\n" + (first + second));
}
else if (mathoperator == "-")
{
    Console.WriteLine("\n" + (first - second));
}
else if (mathoperator == "*")
{
    Console.WriteLine("\n" + (first * second));
}
else if (mathoperator == "/")
{
    Console.WriteLine("\n" + (first / second));
}