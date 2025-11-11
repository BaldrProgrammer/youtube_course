int[] array = { 1, 2, 3 };

foreach (int i in array)
{
    Console.WriteLine(i);
}


string[] names = { "Саня", "Володя", "Петя" };

// здесь можно вместо string юзануть var и там будет принимать любой тип
foreach (string name in names)
{
    Console.WriteLine(name);
}