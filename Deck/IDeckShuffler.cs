using System.Collections.Generic;

namespace CardDeck
{
    public interface IDeckShuffler
    {
        List<Card> ShuffleDeck(List<Card> deck);
    }
}