using System.Collections.Generic;

namespace CardDeck
{
    public enum CardColor
    {
        Red,
        Black
    }

    public class Card
    {
        public CardColor Color { get; }

        public Card(CardColor color)
        {
            Color = color;
        }
    }

    public class Deck
    {
        public List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            for (int i = 0; i < 36; i++)
            {
                CardColor color = (i < 18) ? CardColor.Red : CardColor.Black;
                cards.Add(new Card(color));
            }
        }
    }
}