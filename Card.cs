using System;

namespace ab224qr_examination_3
{

    public enum Rank {
        Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
    }
    public enum Suit {
        Hearts = '♥', Clubs = '♠', Diamonds = '♦', Spades = '♣'
    }
    class Card
    {
        public Rank Rank { get; }
        public Suit Suit { get; }
        public int Value { get => (int)Rank; }

        public Card (Rank rank, Suit suit)
        {
            Rank = Enum.IsDefined(typeof(Rank), rank) ? rank : throw new ArgumentException(nameof(rank));
            Suit = Enum.IsDefined(typeof(Suit), suit) ? suit : throw new ArgumentException(nameof(suit));
        }

        public override string ToString () 
        {
            return $" {Value}{(char)Suit}";
        }
    }
}
