// See https://aka.ms/new-console-template for more information
using System;
class PickRandomCards
{
    static void Main(string[] args)
    { 
        Console.Write("Enter the number of cards to pick: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string line = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        if (int.TryParse(line, out int numberOfCards))
        {
            foreach (string card in CardPicker.PickSomeCards(numberOfCards))
            {
                Console.WriteLine(card);
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
     }
}
 
