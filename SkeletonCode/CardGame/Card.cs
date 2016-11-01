namespace SkeletonCode.CardGame
{
    public enum Suits
    {
        Spades,
        Clubs,
        Hearts,
        Diamonds
    }

    class Card : ICard
    {
        private readonly Suits _suit;
        private readonly string _cardValue;

        public Card()
        {
            // default constructor    
        }

        public Card(Suits suit, string cardValue)
        {
            _suit = suit;
            _cardValue = cardValue;
        }

        public override string ToString()
        {
            return string.Format("{0} of {1}", _cardValue, _suit);
        }
    }
}
    
