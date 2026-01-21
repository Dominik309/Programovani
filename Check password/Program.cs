Console.Clear();
/*
Console.Write("Zadej heslo pro check in:");
string heslo = Console.ReadLine();

bool Bezpecnost(string heslo)
{
    return heslo.Length > 8 && !heslo.Contains("heslo");
}

bool safe = Bezpecnost(heslo);
if (safe)
{
    Console.WriteLine("Heslo je bezpecne");
}
else
{
    Console.WriteLine("Heslo neni bezpecne!");
}


void FrameWord(string word)
{
    int pocet = word.Length + 4;
    for (int i = 0; i < pocet; i++)
    {
        Console.Write("+");
    }
    Console.WriteLine();

    Console.WriteLine("+ " + word + " +");
    
    for (int i = 0; i < pocet; i++)
    {
        Console.Write("+");
    }
    Console.WriteLine();
}
FrameWord("Programovani");
*/
void matika(string vysledek){
    Console.WriteLine("Zadej první číslo:");
    string cislo1 = Console.ReadLine();
    Console.WriteLine("Zadej znaménko:");
    string znamenko = Console.ReadLine();
    Console.WriteLine("Zadej druhé číslo:");
    string cislo2 = Console.ReadLine();
    float cislo1Float = float.Parse(cislo1);
    float cislo2Float = float.Parse(cislo2);

    switch (znamenko)
    {
        case "+":
            Console.WriteLine(cislo1Float + cislo2Float);
            break;
        case "-":
            Console.WriteLine(cislo1Float - cislo2Float);
            break;
        case "*":
            Console.WriteLine(cislo1Float * cislo2Float);
            break;
        case "/":
            Console.WriteLine(cislo1Float / cislo2Float);
            break;
    }
}
matika("vysledek");









