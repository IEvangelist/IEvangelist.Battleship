using System.IO;
using IEvangelist.Battleship.Models;
using IEvangelist.Battleship.Models.Defaults;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace IEvangelist.Battleship.Emulator
{
    public static class Program
    {
        private static IConfigurationRoot Config { get; }

        static Program()
        {
            Config =
                new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .Build();
        }

        public static void Main(string[] args)
        {
            var emulator = new GameEmulator(new GameBoardFactory(), Options.Create(new GameSettings()));
            var game = emulator.Start(new Player(), new Player());
        }
    }
}