Console.Clear();
/*
void Greet(string name)
{
    Console.WriteLine($"Howdy {name} :)");
}

int AddTwoNumbers(int a, int b)
{
    return a + b;
}

int MakeDouble(int x)
{
    return x * 2;
}


Greet("Partner");
int z = AddTwoNumbers(3,4);
Console.WriteLine(z);
z = MakeDouble(z);
Console.WriteLine(z);
*/


Console.Write("Zadejte Kč pro převod na Euro:");
double ConvertToEuro(double czk)
{
    return czk / 25;

}

string input = Console.ReadLine();
double czk = double.Parse(input);

double eur =  ConvertToEuro(czk);
Console.WriteLine($"Hodnota v EUR: {eur}");












