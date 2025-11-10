Console.Write("введите массу дела: ");
int weight = Convert.ToInt32(Console.ReadLine());

Console.Write("введите рост: ");
double height = Convert.ToInt32(Console.ReadLine());


if (weight > 0 && height > 0)
{
    double index = weight / Math.Pow(height / 100, 2);
    if (index <= 16)
    {
        Console.WriteLine(index + " - Выраженный дефицит массы тела.");
    }
    else if (index > 16 && index < 18.5)
    {
        Console.WriteLine(index + " - Недостаточная (дефицит) масса тела.");
    }
    else if (index >= 18.5 && index < 25)
    {
        Console.WriteLine(index + " - Норма.");
    }
    else if (index >= 25 && index < 30)
    {
        Console.WriteLine(index + " - Избыточная масса тела (предожирение)");
    }
    else if (index >= 30 && index < 35)
    {
        Console.WriteLine(index + " - Ожирение первой степени");
    }
    else if (index >= 35 && index < 40)
    {
        Console.WriteLine(index + " - Ожирение второй степени");
    }
    else if (index >= 40)
    {
        Console.WriteLine(index + " - Ожирение третьей степени (морбидное)");
    }
    else
    {
        Console.WriteLine("Некорректный индекс вышел... " + index);
    }
}
else
{
    Console.WriteLine("число должно быть больше 0");
}