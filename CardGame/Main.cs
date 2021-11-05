using CardGame;
using System.Diagnostics;

namespace CodingChallenge.CardGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            var packOfCardsCreator = new PackOfCardsCreator();
            var pack = packOfCardsCreator.Create();

            pack.TakeCardFromTopOfPack();
            pack.Shuffle();
            Debug.Assert(pack.Count == 52);
        }
    }
}
