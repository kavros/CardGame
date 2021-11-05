
using CodingChallenge.CardGame;
using System;
using System.Collections.Generic;

namespace CardGame
{
    public class PackOfCardsCreator : IPackOfCardsCreator
    {    
        
        public IPackOfCards Create()
        {
            var  pack = new List<ICard>();
            var packReadOnly = new PackOfCards(pack);

            var SuitMemberCount = Enum.GetNames(typeof(Suit)).Length;
            var ValueMemberCount = Enum.GetNames(typeof(Value)).Length;
            for (int i = 0; i < SuitMemberCount; i++)
            {
                for (int j = 0; j < ValueMemberCount; j++)
                {
                    var card = new Card
                    {
                        Suit = (Suit)i,
                        Value = (Value)j
                    };
                    pack.Add(card);
                }
            }

            return packReadOnly;
        }
    }
}
