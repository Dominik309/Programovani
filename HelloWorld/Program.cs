/*
string text1 = "Hello";
string text2 = "World";
int cislo = 123;
string text = $"Vystup tohoto programu: {text1} {text2} {cislo}";

// Toto me vypise text
Console.WriteLine(text);
Console.Write("ahoj");
Console.Write("cau");
Console.Write("nazdar");


string vstup = Console.ReadLine();
Console.WriteLine(vstup);
Console.WriteLine("Zadal jsi vstup : " + vstup);


Console.WriteLine("Zadejte vysku v cm");
string vstup1 = Console.ReadLine();
Console.WriteLine("Zadejte ");
string vstup2 = Console.ReadLine();

int cislo1 = int.Parse(vstup1);
int cislo2 = int.Parse(vstup2);
Console.WriteLine(cislo1 + cislo2);


Console.WriteLine("Enter something:");
string slovo = Console.ReadLine();

if (slovo == "q")
{
    Console.WriteLine("User wants to quit");
}
else if (slovo == "qq")
{
    Console.WriteLine("User wants to play");
}
else
{
    Console.WriteLine("Program is running");
}
*/

Console.Clear();
Console.Write("Enter age:");
string ageString = Console.ReadLine();
int age = int.Parse(ageString);


if (age > 150 || age < 0)
{
    Console.WriteLine("Nepovolena hodnota");
}
else if (age < 18)
{
    Console.WriteLine("Jsi nezletilý!");
}
else if (age > 100)
{
    Console.WriteLine("Jsi asi mrtvý");
}
else if (age > 65)
{
    Console.WriteLine("Jsi senior");
}
else
{
    Console.WriteLine("Jsi dospely");
}










