// методы класса Console

Console.Write("не возьмем)))"); // как второе но без переноса(Экранирования \n)

Console.WriteLine("возьмите на работу пж"); // ну типа print()

string? text = Console.ReadLine(); // ну типа input()
Console.WriteLine("введенный текст - " + text);

Console.ReadKey(); // считывает нажатую кнопку на клаве

Console.Clear(); // очищает консоль

Console.SetCursorPosition(10, 10); // перемещает текст по x и y

Console.BackgroundColor = ConsoleColor.Gray; // поменять фон
Console.ForegroundColor = ConsoleColor.Green; // поменять цвет текста
Console.ResetColor(); // очевидно
