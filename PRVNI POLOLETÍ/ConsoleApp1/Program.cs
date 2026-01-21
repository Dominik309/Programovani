Console.Clear();
Console.WriteLine("Zadejte heslo:");
string heslo = Console.ReadLine();

if (heslo == "heslo")
{
    Console.WriteLine("Pristup povolen");
}
else {
    Console.WriteLine("Pristup odmitnut");
}

