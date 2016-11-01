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
        protected Suits suit;
        protected string cardValue;

        public Card()
        {
            // default constructor    
        }

        public Card(Suits suit, string cardValue)
        {
            this.suit = suit;
            this.cardValue = cardValue;
        }

        public override string ToString()
        {
            return string.Format("{0} of {1}", this.cardValue, this.suit);
        }
    }
}
    
