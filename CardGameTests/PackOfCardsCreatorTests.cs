using CardGame;
using CodingChallenge.CardGame;
using NUnit.Framework;
using Shouldly;

namespace CardGameTests
{
    public class PackOfCardsCreatorTests
    {
        IPackOfCardsCreator packOfCardsCreator;

        [SetUp]
        public void Setup()
        {
            packOfCardsCreator = new PackOfCardsCreator();
        }

        [Test]
        public void Create_ShouldReturn52Cards()
        {
            var pack = packOfCardsCreator.Create();

            pack.Count.ShouldBe(52);           
        }
    }
}