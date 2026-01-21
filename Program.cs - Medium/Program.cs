Console.Clear();

// Úkol 1 - Funkce s návratovou hodnotou
int Bigger(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}


// Úkol 2 - Sudé nebo liché
bool IsEven(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    return false;
}
Console.Write("Zadej číslo: ");
int n = int.Parse(Console.ReadLine());
if (IsEven(n))
{
    Console.WriteLine("Sudé");
}
else
{
    Console.WriteLine("Liché");
}

// Úkol 3 - Odpočítávání
void Countdown(int n)
{
    for (int i = n; i >= 1; i--)
    {
        Console.WriteLine(i);
    }
}
Countdown(3);

// Úkol 4 - Součet čísel
int SumFromOne(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}
Console.WriteLine(SumFromOne(5));
// Úkol 5 - Mini menu
        while (true)
        {
            Console.WriteLine("1 - Pozdrav");
            Console.WriteLine("2 - Součet dvou čísel");
            Console.WriteLine("3 - Konec");

            int volba = int.Parse(Console.ReadLine());

            if (volba == 1)
            {
                Console.WriteLine("Ahoj");
            }
            else if (volba == 2)
            {
                Console.WriteLine("Zadejte první číslo:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Zadejte druhé číslo:");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"Výsledek je = {a + b}");
            }
            else if (volba == 3)
            {
                break; 
            }
}

    
