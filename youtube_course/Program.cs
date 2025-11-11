// Массивы это не списки, а скорее кортежи. У них фиксированный тип данных и размер
// Коллекции это как раз списки. В них можно добавлять и удалять элементы, а так же есть свои встроенные методы

// создание
List<string> names = new List<string> { "Володя", "Санёк", "Поляк" };

// добавление элемента
names.Add("Ванёк");

// удаление элемента
names.Remove("Володя");
Console.WriteLine(names);

// встроенный foreach
names.ForEach(x => Console.WriteLine(x));

// даже джоин есть))
Console.WriteLine(string.Join(", ", names));

// Очищение списка. Ну методов там намного больше
names.Clear();

// просто так вывести как массив нельзя, ибо это объект класса list.
Console.WriteLine(names); // System.Collections.Generic.List`1[System.String]