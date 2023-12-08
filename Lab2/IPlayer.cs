using CardDeck;

namespace Lab2
{
    public interface IPlayer
    { 
        string Name { get; }
        int MakeMove(Card[] cards);
    }
}