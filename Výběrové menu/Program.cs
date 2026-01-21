Console.Clear();
Console.WriteLine("**************************");
Console.WriteLine("*  1. Vklad na účet      *");
Console.WriteLine("*  2. Výběr z účtu       *");
Console.WriteLine("*  3. Zobrazení zůstatku *");
Console.WriteLine("**************************");
Console.Write("Zadejte číslo:");
string bankomat = Console.ReadLine();


if (bankomat == "1")
    Console.WriteLine("Budete si vkládat na účet");
else if (bankomat == "2")
    Console.WriteLine("Budete si vybírat z účtu");
else if (bankomat == "3")
    Console.WriteLine("Zobrazí se vám zůstatek na účtu");
else
    Console.WriteLine("Zadal jste špatné číslo nebo žadné nebylo zadáno");