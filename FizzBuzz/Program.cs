using System;

class Program
{
    static void Main(string[] args)
    {
        int x, y, n;

        // Försöker läsa in och validera input tills det är korrekt
        while (true)
        {
            Console.WriteLine("Ange tre heltal mellan 1 - 100 i formatet x y n separerade med mellanslag:");
            string input = Console.ReadLine();
            //Dela upp input i delar
            string[] parts = input.Split();

            // Kolla så vi har exakt 3 delar, annars är formatet fel
            if (parts.Length != 3)
            {
                Console.WriteLine("Fel format -- Ange exakt tre heltal, t.ex. '2 3 7'.");
                continue;
            }

            // Försök konvertera varje del till ett heltal och kolla så det går
            try
            {
                x = int.Parse(parts[0]); // Första talet, används för "Fizz"
                y = int.Parse(parts[1]); //Andra talet, anvnds för "Buzz"
                n = int.Parse(parts[2]); // Tredje talet, hur långt vi ska räkna

                // Kolla så talen är positiva och inte större än 100
                if (x <= 0 || y <= 0 || n <= 0)
                {
                    Console.WriteLine("Talen måste vara positiva heltal.");
                    continue;
                }
                if (x > 100 || y > 100 || n > 100)
                {
                    Console.WriteLine("Talen får inte vara större än 100.");
                    continue;
                }

                // Om vi kommer hit är input korrekt, så vi kan gå vidare
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Fel! Ange bara heltal, t.ex. '2 3 7'.");
            }
            catch (Exception)
            {
                Console.WriteLine("Det blev fel med inmatningen.");
            }
        }

        // Nu kör vi FizBuzz från 1 till n
        for (int i = 1; i <= n; i++)
        {
            //kolla först om talet är delbart med både x och y
            if (i % x == 0 && i % y == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            // Annars, kolla om det är delbart med x
            else if (i % x == 0)
            {
                Console.WriteLine("Fizz");
            }
            //Annars, kolla om det är delbart med y
            else if (i % y == 0)
            {
                Console.WriteLine("Buzz");
            }
            // Om inget av ovanstående stämmer, skriv ut talet som det är
            else
            {
                Console.WriteLine(i);
            }
        }

        // Vänta på att användaren trycker på en tangent innan programmet avslutas
        Console.WriteLine("Tryck på valfri tangent för att avsluta...");
        Console.ReadKey();
    }
}