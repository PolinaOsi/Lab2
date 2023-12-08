using System.Threading.Tasks;
using CardDeck;
using Lab2;

public interface IExperimentService
{
    Task<int> RunExperiment(IDeckShuffler deckShuffler, Deck deck, IPlayer elonPlayer, IPlayer markPlayer);
}