Console.Clear();
Console.WriteLine("Zadejte prvni cislo:");
string cislo1 = Console.ReadLine();

Console.WriteLine("Zadejte znamenko (+,-,*,/):");
string znamenko = Console.ReadLine();

Console.WriteLine("Zadejte druhe cislo:");
string cislo2 = Console.ReadLine();

float cislo1Float = float.Parse(cislo1);
float cislo2Float = float.Parse(cislo2);

if (znamenko == "+")
{ 
    Console.WriteLine(cislo1Float + cislo2Float);
}
else if (znamenko == "-")
{
    Console.WriteLine(cislo1Float - cislo2Float);
}
else if (znamenko == "*")
{
    Console.WriteLine(cislo1Float * cislo2Float);
}
else if (znamenko == "/")
{
    Console.WriteLine(cislo1Float / cislo2Float);
    if (cislo2Float == 0)
        Console.WriteLine("Nemuzes delit nulou");
}

