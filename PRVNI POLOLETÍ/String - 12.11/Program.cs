Console.Clear();
/*
string veta = "Dnes je velmi hezky.";
// Velikost písmena
Console.WriteLine(veta.ToUpper());
Console.WriteLine(veta.ToLower());

Console.WriteLine(veta.Trim());
//Hledání
Console.WriteLine(veta.Contains("je")); // true or false
Console.WriteLine(veta.IndexOf(".")); // pozici prvniho vyskytu

// zacina/konci
Console.WriteLine(veta.Trim().StartsWith("Zitra")); // true or false
Console.WriteLine(veta.Trim().EndsWith("hezky."));

Console.Write("Zadejte jméno a příjmení:");
string vstup =  Console.ReadLine();
Console.WriteLine(vstup.Length);
Console.WriteLine(vstup.ToUpper());
Console.WriteLine($"Je tam Jan?: {vstup.ToLower().Contains("jan")}");
Console.WriteLine(vstup[0]);
Console.WriteLine(vstup[vstup.Length -1]);


string datum = "2025-11-11T16:00";
string rok = datum.Substring(0, 4);
string cas = datum.Substring(11);
string den =  datum.Substring(5, 5);

//Console.WriteLine($"Rok:{rok} Cas:{cas} Den:{den}");

string text = "Cena: 100 Kc, Doprava: 50 Kc";
string opraveno = text.Replace("Kc", "CZK");
Console.WriteLine(opraveno);

string csvRadek = "Pavel;Novak;30;Praha";
string[] casti = csvRadek.Split(";");
Console.WriteLine($"Jméno: {casti[0]}, Přijmení: {casti[1]}, Věk: {casti[2]}, Město: {casti[3]}");

string veta = "Dnes je streda";
string[] slova = veta.Split(" ");
Console.WriteLine(slova.Length);


Console.Write("Zadejte jméno a příjmení:");
string jmeno =  Console.ReadLine();

jmeno = jmeno.Trim();
jmeno = jmeno.ToLower();
Console.WriteLine(jmeno.IndexOf(" "));
string[] slova = jmeno.Split(' ');
slova[0] = slova[0].Substring(0, 1).ToUpper();
slova[1] = slova[1];
string prijmeni = slova[1].Substring(1, (slova[1].Length) - 1);
slova[1] = (slova[1]).Substring(0, 1).ToUpper();

Console.WriteLine(slova[0] +  "." + slova[1] + prijmeni);



string data = "JMENO=KAREL; VEK=45; MESTO=PRAHA";
string[] casti = data.Split(';');
foreach (string par in casti)
{
    string[] c = par.Split('=');
    Console.WriteLine(c[1]);
}



string[] radky = File.ReadAllLines(path:"data.txt");
foreach (var radek in radky)
{
    Console.WriteLine(radek);
}
*/


string cesta = "data.txt";
if (File.Exists(cesta))
{
    StreamReader sr = new StreamReader(cesta);
    string line = sr.ReadLine(); // prectu prvni radek

    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
    sr.Close(); // zavreni souboru
}
if (File.Exists(cesta))
{
    StreamWriter sw = new StreamWriter(cesta, append: true);
    sw.WriteLine("\nHello World!");
    sw.WriteLine("Dobrý den");
    for (int i = 0; i < 10; i++)
    {
        sw.WriteLine($"Index {i}");
    }
    sw.Close();
    
}

