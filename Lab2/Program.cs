using Microsoft.Extensions.Hosting;
using CardDeck;
using ElonVSmarkTask2;
using Strategy;
using Lab2;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<CollisiumExperimentWorker>();
                services.AddScoped<IExperimentService, ExperimentService>();
                services.AddScoped<IDeckShuffler, DeckShuffler>();
                services.AddScoped<IPlayer, ElonMask>();
                services.AddScoped<IPlayer, MarkZuckerberg>();
                services.AddScoped<ICardStrategy, GameStrategy>();
            });
    }
}
