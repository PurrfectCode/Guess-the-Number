using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        int range = 3;

        // Avkommentera raden nedan för att se numret under testning av koden
        // Console.WriteLine(randomNumber);

        Console.WriteLine("Du ska nu gissa ett tal mellan 1 till 100");

        Console.Write("Skriv in ett tal: ");
        // Tar inmatningen som en sträng
        string userInput = Console.ReadLine();

        /*
            Kontrollerar om vi kan konvertera strängen till ett heltal. Om vi inte kan,
            innebär det att användaren skrev en bokstav istället för ett tal, vilket inte är ett giltigt alternativ.
        */
        if (!int.TryParse(userInput, out int userGuess))
        {
            Console.WriteLine("Skriv ett tal mellan 1 och 100.");
            return;
        }

        /*
            Kontrollera inmatningens begränsningar
        */
        if (userGuess > 100)
        {
            Console.WriteLine("Ditt tal är för stort! Gissa på ett mindre tal. Du måste skriva ett tal mellan 1 och 100. \n Programmet är slut");
        }
        else if (userGuess < 1)
        {
            Console.WriteLine("Du måste skriva in ett tal mellan 1 och 100. \n Programmet är slut");
        }

        /*
            Här skapar vi randomNumber - range för att skapa en startpunkt för "nästan rätt" -utdata,
            och vi lägger till && userGuess < randomNumber för att skapa en slutpunkt (samma för höga nästan rätt nummer).
        */
        if (userGuess >= randomNumber - range && userGuess < randomNumber)
        {
            Console.WriteLine("Ditt tal är för litet! Gissa på ett större tal... men du är nära! \n Programmet är slut");
        }
        else if (userGuess > randomNumber && userGuess <= randomNumber + range)
        {
            Console.WriteLine("Ditt tal är för stort! Gissa på ett mindre tal... men du är nära! \n Programmet är slut");
        }
        /*
            Gör de vanliga kontrollerna
        */
        else if (userGuess == randomNumber)
        {
            Console.WriteLine("Du har gissat rätt! YIPPIEE \n Programmet är slut");
        }
        else if (userGuess > randomNumber)
        {
            Console.WriteLine("Ditt tal är för stort! Gissa på ett mindre tal \n Programmet är slut");
        }
        else
        {
            Console.WriteLine("Ditt tal är för litet! Gissa på ett större tal \n Programmet är slut");
        }
    }
}
