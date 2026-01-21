Console.Clear();
Console.Write("Zadej svoji známku:");
string znamka = Console.ReadLine();

switch (znamka)
{
    case "1":
        Console.WriteLine("Výborně");
        break;
    case "2":
        Console.WriteLine("Chvalitebně");
        break;
    case "3":
        Console.WriteLine("Dobrý");
        break;
    case "4":
        Console.WriteLine("Dostatečně");
        break;
    case "5":
        Console.WriteLine("Nedostatečně");
        break;
    default:
        Console.WriteLine("Neplatná známka");
        break;
}