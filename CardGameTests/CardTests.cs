
using CardGame;
using CodingChallenge.CardGame;
using NUnit.Framework;
using Shouldly;

namespace CardGameTests
{
    public class CardTests
    {      
        [Test]
        public void Equals_ShouldReturFalse_WhenCardsAreNotSame()
        {
            var card1 = new Card()
            {
                Suit = Suit.Clubs,
                Value = Value.Ace
            };

            var card2 = new Card()
            {
                Suit = Suit.Clubs,
                Value = Value.Eight
            };

            card1.Equals(card2).ShouldBeFalse();
        }

        [Test]
        public void Equals_ShouldReturTrue_WhenCardsAreSame()
        {
            var card1 = new Card()
            {
                Suit = Suit.Clubs,
                Value = Value.Ace
            };

            var card2 = new Card()
            {
                Suit = Suit.Clubs,
                Value = Value.Ace
            };

            card1.Equals(card2).ShouldBeTrue();
        }
    }
}
