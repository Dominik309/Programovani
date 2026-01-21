Console.Clear();
// Úkol 1 - Oprav funkci
void Greet(string pozdrav)
{
    Console.WriteLine("Ahoj!");
}

Greet("pozdrav");
Greet("pozdrav");
Greet("pozdrav");

// Úkol 2 - Doplň podmínky

Console.Write("Zadej číslo: ");
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine("Kladné číslo");
}
else if (number < 0)
{
    Console.WriteLine("Záporné číslo");
}
else
{
    Console.WriteLine("Nula");
}

// Úkol 3 - Oprav cyklus while

int i = 1;
while (i<=5)
{
    Console.WriteLine(i++);
}

// Úkol 4 - Funkce s parametrem

void PrintText(string text)
{
    Console.WriteLine("Programování je zábava");
}
PrintText("text");

// Úkol 5 - Oprava cyklu for
for (i = 0; i < 5; i++)
{
    Console.Write("*");
}
