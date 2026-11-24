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
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
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
    while (!int.TryParse(Console.ReadLine(), out UpperBound) || UpperBound < LowerBound)
    {
        Console.Write("Nezadali jste celé kladné číslo nebo je horní mez menší než dolní mez. Zadejte poslední číslo znovu: ");
    }

   // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Počet pseudonáhodných čísel: {n}: Dolní mez: {LowerBound}; Horní mez: {UpperBound}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    //deklerace pole a alokace v paměti
    int [] myRanNumbs = new int [n];

    //inicializace generátoru náhodných čísel
    Random MyRandNumb = new Random ();
    //Random MyRandNumb = new Random (50): //Pevný seed pro testovací účely

    int negativenumbs = 0;
    int positivenumbs = 0;
    int zeroes = 0;

    int evennumbs = 0;
    int oddnumbs = 0;

   
   Console.Write("Generovaná čísla:");
    for(int i = 0; i < myRanNumbs.Length; i++ )
    {
        //Generování i-tého náhodného čísla
        myRanNumbs[i] = MyRandNumb.Next(LowerBound, UpperBound+1);
        Console.Write($"{myRanNumbs[i]};");

        if (myRanNumbs[i] < 0)
         negativenumbs++;
        else if (myRanNumbs[i] > 0)
         positivenumbs++;
        else
         zeroes++;

        if(myRanNumbs[i] % 2 == 0)
        {
        evennumbs++;
        }
        else
        {
        oddnumbs++;
        }
    }

    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Počet záporných čísel: {negativenumbs}");
    Console.WriteLine($"Počet kladných čísel: {positivenumbs}");
    Console.WriteLine($"Počet nul: {zeroes}");
    Console.WriteLine($"Počet sudých čísel: {evennumbs}");
    Console.WriteLine($"Počet lichých čísel: {oddnumbs}");
    Console.WriteLine("====================================");
    Console.WriteLine();

 Console.WriteLine("Pokračujte stisknutím klávesy 'a', nebo jinak pro ukončení.");
 again = Console.ReadLine();

 }

  