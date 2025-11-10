string agestr = Console.ReadLine();
int age = Convert.ToInt32(agestr);

if (age >= 18)
{
    Console.WriteLine("можешь голосовать!");
}
else if (age == 16 || age == 17)
{
    Console.WriteLine("частично можешь голосовать");
}
else if (age >= 12 && age < 18)
{
    Console.WriteLine("скоро сможешь голосовать");
}
else
{
    Console.WriteLine("не можешь голосовать");
}