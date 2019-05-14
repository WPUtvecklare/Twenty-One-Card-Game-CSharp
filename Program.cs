using System;

namespace ab224qr_examination_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();
            deck.GenerateDeck();
            for (int i = 0; i < deck.cards.Count; i++)
            {
                System.Console.WriteLine(deck.cards[i].GetName());
            }
        }
    }
}
