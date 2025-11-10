while (true)
{
    Console.Write("first - ");
    double first = Convert.ToDouble(Console.ReadLine());
    string? mathoperator = Console.ReadLine();
    Console.Write("second - ");
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
    
    Console.WriteLine("Нажмите любую кнопку...");
    Console.ReadKey();
}