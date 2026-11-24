string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("***** Vykreslení obrazce *****");
    Console.WriteLine("********************************");
    Console.WriteLine("********* Sára Kotrčová **********");
    Console.WriteLine("********************************");
    Console.WriteLine();


    Console.Write("Zadejte šířku obrazce (přirozené číslo): ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
    {
        Console.Write("Šířka musí být celé kladné číslo větší než 0. Zadejte znovu: ");
    }

    Console.Write("Zadejte výšku obrazce (přirozené číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.Write("Výška musí být celé kladné číslo větší než 0. Zadejte znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine($"Vykresluji obrazec o rozměrech {width} × {height}:");
    Console.WriteLine();
 
int size = width * height; // řádky i sloupce 0..7

for (int i = 0; i < size; i++)        // i = řádek (0..7)
{
    for (int j = 0; j < size; j++)    // j = sloupec (0..7)
    {
        if (i == j)
        {
            Console.Write("* ");
        }
        else
        {
            Console.Write("  "); // prázdné místo se stejným rozestupem
        }
    }
    Console.WriteLine();
}

    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte Enterem: ");
    again = Console.ReadLine() ?? "";
}

