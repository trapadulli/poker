using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var suits = new string[] { "spades", "hearts", "diamonds", "clubs" };
        var values = new string[] { "1","2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
       
        var rand = new Random();

        // Deal two random hands
        var hand1 = new Hand(Enumerable.Range(0, 5)
            .Select(i => new Card { Suit = suits[rand.Next(suits.Length)], Value = values[rand.Next(values.Length)] })
            .ToArray());
        var hand2 = new Hand(Enumerable.Range(0, 5)
            .Select(i => new Card { Suit = suits[rand.Next(suits.Length)], Value = values[rand.Next(values.Length)] })
            .ToArray());

        // Print categories of each hand
        Console.WriteLine("Hand 1: " + hand1.Category);
        Console.WriteLine("Hand 2: " + hand2.Category);

       
    }

    
}