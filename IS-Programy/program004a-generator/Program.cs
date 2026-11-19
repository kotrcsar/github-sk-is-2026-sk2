string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Sára Kotrčová ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // Vstup pro počet generovaných čísel
    Console.Write("Zadejte počet generovaných (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n)) || n <= 0;
    {
        Console.Write("Nezadali jste kladné celé číslo. Zadejte první číslo znovu: ");
    }

    // Vstup pro dolní mez
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int LowerBound;
    while (!int.TryParse(Console.ReadLine(), out LowerBound))
    {
        Console.Write("Nezadali jste celé kladné číslo. Zadejte poslední číslo znovu: ");
    }

    // Vstup pro horní mez
    Console.Write("Zadejte horní mez (kladné celé číslo): ");
    int UpperBound;
    while (!int.TryParse(Console.ReadLine(), out UpperBound)) || UpperBound < LowerBound;
    {
        Console.Write("Nezadali jste celé kladné číslo nebo je horní mez menší než dolní mez. Zadejte poslední číslo znovu");
    }

   // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Dolní mez: {LowerBound}; Horní mez: {UpperBound}; Generovaná čísla: {n}");
    Console.WriteLine("====================================");
    Console.WriteLine();
 }
  