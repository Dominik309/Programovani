Console.Clear();

int bodyA = 0;
int bodyB = 0;
int gamyA = 0;
int gamyB = 0;
int setyA = 0;
int setyB = 0;

string[] tenisBody = { "0", "15", "30", "40" };

while (true)
{
    Console.Clear();

    string vypisBodyA = "";
    string vypisBodyB = "";

    
    if (bodyA >= 3 && bodyB >= 3)
    { 
        if (bodyA == bodyB)
        {
            vypisBodyA = "40";
            vypisBodyB = "40";
        }
        else if (bodyA == bodyB + 1)
        {
            vypisBodyA = "A";
            vypisBodyB = "40";
        }
        else if (bodyB == bodyA + 1)
        {
            vypisBodyA = "40";
            vypisBodyB = "A";
        }
        else
        {
            vypisBodyA = "40";
            vypisBodyB = "40";
        }
    }
    else
    {
        vypisBodyA = bodyA < 4 ? tenisBody[bodyA] : "40";
        vypisBodyB = bodyB < 4 ? tenisBody[bodyB] : "40";
    }

    Console.WriteLine($"Body: {vypisBodyA}-{vypisBodyB}");
    Console.WriteLine($"Gamy: {gamyA}-{gamyB}");
    Console.WriteLine($"Sety: {setyA}-{setyB}");

    string vstup = "";

    while (true)
    {
        Console.Write("Jaký hráč má dostat bod? (a/b): ");
        vstup = Console.ReadLine();

        if (vstup == "a" || vstup == "b")
            break;
        else
            Console.WriteLine("Zadána nesprávná hodnota! Zadej (a/b)!");
    }

    if (vstup == "a") bodyA++;
    else bodyB++;

   
    if (bodyA >= 4 && bodyA - bodyB >= 2)
    {
        gamyA++;
        bodyA = 0;
        bodyB = 0;
    }
    else if (bodyB >= 4 && bodyB - bodyA >= 2)
    {
        gamyB++;
        bodyA = 0;
        bodyB = 0;
    }
    else if (bodyA >= 4 && bodyB >= 4 && bodyA == bodyB)
    {
     
        bodyA = 3;
        bodyB = 3;
    }

   
    if (gamyA >= 6 && gamyA - gamyB >= 2)
    {
        setyA++;
        gamyA = 0;
        gamyB = 0;
        bodyA = 0;
        bodyB = 0;
    }
    else if (gamyB >= 6 && gamyB - gamyA >= 2)
    {
        setyB++;
        gamyA = 0;
        gamyB = 0;
        bodyA = 0;
        bodyB = 0;
    }
    
    if (setyA == 2)
    {
        Console.WriteLine("Vyhrál hráč A!");
        break;
    }
    else if (setyB == 2)
    {
        Console.WriteLine("Vyhrál hráč B!");
        break;
    }
}

