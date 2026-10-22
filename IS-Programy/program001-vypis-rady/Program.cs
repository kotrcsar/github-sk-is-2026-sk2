string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Výpis řady čísel *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Sára Kotrčová ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // Vstup počáteční hodnoty
    // 
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo znovu: ");
    }

    // Vstup koncové hodnoty
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo znovu: ");
    }

    // Vstup diference s kontrolou kladné hodnoty
    Console.Write("Zadejte diferenci (kladné celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step <= 0)
    {
        Console.Write("Diference musí být kladné celé číslo větší než 0. Zadejte znovu: ");
    }

   // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"První číslo: {first}; Poslední číslo: {last}; Diference: {step}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    // jádro algoritmu pro výpis řady
    Console.WriteLine("Výpis číselné řady:");
    if (first <= last)
    
    {
        int current = first;
        while (current <= last)
        {
            //Čísla řady pod sebou
            Console.WriteLine(current);
            current += step;
        }
    }
    else
    {
        Console.WriteLine("Výpis řady nelze vypsat!");
        Console.WriteLine("První číslo je větší než poslední.");
        Console.WriteLine("Tento program umí vypsat pouze vzestupnou řadu (od menšího k většímu");
    }

