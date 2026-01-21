Console.Clear();
string path = "zaci.txt";

int celkovyVek = 0;
int pocetZaku = 0;

//Podminka pro kontrolu existence souboru
try
{
    //precist ten soubor po radcich
    StreamReader sr = new StreamReader(path);
    string line = sr.ReadLine();


    while (line != null)
    {
        string[] casti = line.Split(';');
        Console.WriteLine($"{casti[0]} {casti[1]} - Věk je {casti[2]}");
        int vek = 0;
        try
        {
            vek = int.Parse(casti[2]);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        celkovyVek += vek;
        pocetZaku++;
        line = sr.ReadLine();
    }

    sr.Close();
    try
    {
    double prumer = celkovyVek / (double)pocetZaku;
    Console.WriteLine($"Průměr je {prumer}");
    StreamWriter sw = new StreamWriter(path, true);

    sw.WriteLine($"\n Celkový počet žáků:  {pocetZaku}");
    sw.WriteLine($"\n Celkový věk:  {celkovyVek}");
    sw.WriteLine($"\n Průměrný věk:  {prumer}");

    sw.Close();
    }
catch (Exception chyba)
{
            Console.WriteLine(chyba.Message);
}
    
 
    
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
