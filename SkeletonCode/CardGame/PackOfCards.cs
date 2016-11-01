using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SkeletonCode.CardGame
{
    class PackOfCards : IPackOfCards
    {
        private readonly List<Card> _cards = new List<Card>();
        private readonly Random _random = new Random();
        private readonly string[] _numbers = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        public PackOfCards()
        {
            // Default constructor which creates the pack of cards.
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                int i = 0;
                foreach (var s in _numbers)
                {
                    _cards.Add(new Card(suit, s));
                    i++;
                }
            }               
        }

        public List<Card> Cards
        {
            get { return _cards; }
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            return _cards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cards.GetEnumerator();
        }

        public int Count
        {
            get { return _cards.Count; }
        }

        public void Shuffle()
        {
            // Fisher-Yates shuffle logic.
            for(int n = _cards.Count - 1; n > 0; --n)
            {
                int k = _random.Next(n + 1);
                Card temp = _cards[n];
                _cards[n] = _cards[k];
                _cards[k] = temp;
            }
        }

        public ICard TakeCardFromTopOfPack()
        {
            // Remove the first card from the pack and return it.
            var firstCard = _cards.First();
            _cards.Remove(firstCard);
            return firstCard;
        }
    }
}
