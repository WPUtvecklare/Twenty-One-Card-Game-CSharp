using System;

namespace ab224qr_examination_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();
            deck.GenerateDeck();
            deck.Shuffle();
            // for (int i = 0; i < 2; i++)
            // {
            //     System.Console.WriteLine(deck.DrawCard().GetValues());
            // }

            var player = new Player();
            player.AddCard(deck.DrawCard());
            player.AddCard(deck.DrawCard());
            System.Console.WriteLine(player.SumOfHand());
        }
    }
}
