
using CodingChallenge.CardGame;

namespace CardGame
{
    public class Card : ICard
    {
        public Suit Suit { get; set; }

        public Value Value { get; set; }

        public bool Equals(ICard other)
        {
            return other.Suit == Suit && other.Value == Value;
        }
    }
}
