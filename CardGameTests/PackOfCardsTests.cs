using CardGame;
using CodingChallenge.CardGame;
using NUnit.Framework;
using Shouldly;
using System.Linq;

namespace CardGameTests
{
    class PackOfCardsTests
    {
        IPackOfCardsCreator packOfCardsCreator;

        [SetUp]
        public void Setup()
        {
            packOfCardsCreator = new PackOfCardsCreator();

        }

        [Test]
        public void GetEnumerator_ShouldNotContainDeletedCard()
        {
            var packOfCards = packOfCardsCreator.Create();
            var deletedCard = packOfCards.TakeCardFromTopOfPack();

            foreach (var card in packOfCards)
            {
                card.ShouldNotBe(deletedCard);
            }
        }

        [Test]
        public void Shuffle_WhenTakeAndThenShuffle_ShouldAddBackTakenCard()
        {
            var packOfCards = packOfCardsCreator.Create();
            var card = packOfCards.TakeCardFromTopOfPack();

            packOfCards.Shuffle();

            packOfCards.Contains(card);
            packOfCards.Count.ShouldBe(52);
        }

        [Test]
        public void Shuffle_ShouldReturnAllCards()
        {
            var packOfCards = packOfCardsCreator.Create();

            packOfCards.TakeCardFromTopOfPack();
            packOfCards.Shuffle();
            packOfCards.TakeCardFromTopOfPack();
            packOfCards.TakeCardFromTopOfPack();
            packOfCards.Shuffle();

            packOfCards.Count.ShouldBe(52);
        }

        [Test]
        public void Shuffle_ShouldReturn50Cards()
        {
            var packOfCards = packOfCardsCreator.Create();

            packOfCards.TakeCardFromTopOfPack();
            packOfCards.Shuffle();
            packOfCards.TakeCardFromTopOfPack();
            packOfCards.TakeCardFromTopOfPack();

            packOfCards.Count.ShouldBe(50);
        }

        [Test]
        public void TakeCardFromTopOfPack_ShouldRemoveCard()
        {
            var packOfCards = packOfCardsCreator.Create();

            var card = packOfCards.TakeCardFromTopOfPack();

            packOfCards.ShouldNotContain(card);
            packOfCards.Count.ShouldBe(51);
        }
    }
}
