Console.Clear();

//Zadana vaha v kg
Console.WriteLine("Zadejte vahu v kg");
string vaha = Console.ReadLine();

//Zadana vyska v cm
Console.WriteLine("Zadejte vysku v cm ");
string vyska = Console.ReadLine();

float vahaFloat = float.Parse(vaha);
float vyskaFloat = float.Parse(vyska);

//Prevede vysku na metry
float vyskavmetrech = vyskaFloat / 100f;

//VYpocet BMI
float bmi= (vahaFloat / (vyskavmetrech * vyskavmetrech));
Console.WriteLine(vahaFloat / (vyskavmetrech * vyskavmetrech));
Console.WriteLine("Tvoje BMI je: " + bmi);

 if (bmi < 18.49)
 { 
     Console.WriteLine("Mas podvahu");
 }
else if (bmi >= 18.5 && bmi <= 24.99)
{
    Console.WriteLine("Mas normalni vahu");
}
else if (bmi >= 25 && bmi <= 29.99)
{
    Console.WriteLine("Mas nadvahu");
}
else
{
    Console.WriteLine("Jsi obezni");
}