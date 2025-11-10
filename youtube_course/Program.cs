// первое отличие от питона это то что функцию можно вызвать до объявления
ShowResult("hello world");

int suma = Add(432, 48);
Console.WriteLine(suma);

Console.WriteLine(Factirial(3));

// пример рекурсии
static int Factirial(int n)
{
    if (n == 1) return 1;

    return n * Factirial(n - 1);
}

// быстрый возврат из функции
static int Add(int x, int y) => x + y;

// пример обычной функции, возвращающей string
static string ShowResult(string result)
{
    return result;
}