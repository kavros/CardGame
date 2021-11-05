using CodingChallenge.CardGame;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
    public class PackOfCards : IPackOfCards
    {
        public int Count { get { return _cards.Count; } }
        private List<ICard> _cards;
        private readonly List<ICard> _takenCards;

        public PackOfCards(List<ICard> cards)
        {
            _cards = cards;
            _takenCards = new();
        }

        public void Shuffle()
        {
            foreach(var card in _takenCards)
            {
                _cards.Add(card);
            }
            _takenCards.Clear();

            Random rnd = new();
            _cards = _cards.OrderBy(item => rnd.Next()).ToList();
        }

        public ICard TakeCardFromTopOfPack()
        {
            var firstCard = _cards.ElementAt(0);
            _takenCards.Add(firstCard);
            _cards.Remove(firstCard);
            return _takenCards.Last();
        }

        public IEnumerator<ICard> GetEnumerator()
        {
           foreach(var card  in _cards)
            {
                yield return card;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
