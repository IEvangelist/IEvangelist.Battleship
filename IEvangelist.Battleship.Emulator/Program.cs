using System.IO;
using IEvangelist.Battleship.Models;
using IEvangelist.Battleship.Models.Defaults;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace IEvangelist.Battleship.Emulator
{
    public static class Program
    {
        private static IConfigurationRoot Config { get; } =
            new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

        private static IOptions<GameSettings> Settings { get; } = GetSettings();
        

        public static void Main(string[] args)
        {
            var shipFactory = new ShipFactory();
            var emulator = new GameEmulator(new GameBoardFactory(shipFactory), Settings);
            var game = emulator.Start(new Player(), new Player());
        }

        private static IOptions<GameSettings> GetSettings()
        {
            var settings = new GameSettings();
            Config.GetSection(nameof(GameSettings)).Bind(settings);

            return Options.Create(settings);
        }
    }
}