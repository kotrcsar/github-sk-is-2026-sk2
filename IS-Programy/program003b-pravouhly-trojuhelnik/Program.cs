string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("***** Vykreslení trojúhelníku *****");
    Console.WriteLine("********************************");
    Console.WriteLine("********* Sára Kotrčová **********");
    Console.WriteLine("********************************");
    Console.WriteLine();


    Console.Write("Zadejte délku 1. odvěsny (přirozené číslo): ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
    {
        Console.Write("Délka musí být celé kladné číslo větší než 0. Zadejte znovu: ");
    }

    Console.Write("Zadejte délku 2. odvěsny (přirozené číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.Write("Délka musí být celé kladné číslo větší než 0. Zadejte znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine($"Vykresluji obrazec o rozměrech {width} × {height}:");
    Console.WriteLine();
 
    Console.ForegroundColor = ConsoleColor.Cyan;
for (int i = 1; i <= height; i++)
{

    for (int j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();

}
    Console.ResetColor();

    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte Enterem: ");
    again = Console.ReadLine() ?? "";
}

