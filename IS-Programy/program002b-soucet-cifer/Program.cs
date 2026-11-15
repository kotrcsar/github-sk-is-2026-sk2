
string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("********* Ciferný součet **********");
    Console.WriteLine("***********************************");
    Console.WriteLine("*********** Sára Kotrčová ***********");
    Console.WriteLine("***********************************");
    Console.WriteLine();

    Console.Write("Zadejte celé číslo: ");
    
    string number;
   
    while (true)
    {
        number = Console.ReadLine() ?? "";
        if (int.TryParse(number, out int kontrola))
        {
            break;
        }
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu: ");
    }

    int numberBackup = int.Parse(number); 
    int sum = 0;
    int product = 1;               
    int digit;                 

   number = number.TrimStart('-');

    Console.WriteLine();
    Console.WriteLine("Průběh rozkladu čísla na cifry (zprava doleva):");

       foreach (char znak in number)
        {
            digit = int.Parse(znak.ToString());            
            sum = sum + digit;
            product = product * digit;               

            Console.WriteLine($"Získána cifra: {digit}");
          
        }
    

    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Původní číslo:  {numberBackup}");
    Console.WriteLine($"Ciferný součet: {sum}");
    Console.WriteLine($"Ciferný součin: {product}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}
