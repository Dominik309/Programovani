using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Výpočet plochy v metrech čtverečních");

        // Získání délky
        Console.Write("Zadej délku (v metrech): ");
        double delka = Convert.ToDouble(Console.ReadLine());

        // Získání šířky
        Console.Write("Zadej šířku (v metrech): ");
        double sirka = Convert.ToDouble(Console.ReadLine());

        // Výpočet plochy
        double plocha = delka * sirka;

        // Výstup
        Console.WriteLine($"Plocha: {plocha} m²");
    }
}
