
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
        private IList<ICard> _cards;
        
        public PackOfCards(IList<ICard> cards)
        {
            _cards = cards;
        }
        public IEnumerator<ICard> GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Shuffle()
        {
            Random rnd = new();
            _cards = _cards.OrderBy(item => rnd.Next()).ToList();
        }

        public ICard TakeCardFromTopOfPack()
        {
            return _cards.ElementAt(0);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cards.GetEnumerator();
        }
    }
}
