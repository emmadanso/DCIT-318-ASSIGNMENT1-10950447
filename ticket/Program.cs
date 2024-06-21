using System;

class TicketPriceCalculator
{
    static void Main()
    {
        // Prompt the user to enter their age
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        // Try to parse the input as an integer
        if (int.TryParse(input, out int age))
        {
            // Determine the ticket price based on the age
            int ticketPrice = 10;
            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7;
            }

            // Display the ticket price
            Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
        }
        else
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid age.");
        }
    }
}

