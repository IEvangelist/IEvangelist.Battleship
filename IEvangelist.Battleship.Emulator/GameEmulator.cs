using System;
using IEvangelist.Battleship.Models;
using IEvangelist.Battleship.Models.Interfaces;
using Microsoft.Extensions.Options;

namespace IEvangelist.Battleship.Emulator
{
    class GameEmulator
    {
        private readonly IGameBoardFactory _gameBoardFactory;
        private readonly GameSettings _settings;

        public GameEmulator(IGameBoardFactory gameBoardFactory,
                            IOptions<GameSettings> options)
        {
            _gameBoardFactory = gameBoardFactory ?? throw new ArgumentNullException(nameof(gameBoardFactory));
            _settings = options?.Value ?? throw new ArgumentNullException(nameof(options));
        }

        public Game Start(IPlayer playerOne,
                          IPlayer playerTwo)
            => new Game(_gameBoardFactory.CreateBoard(playerOne, _settings),
                        _gameBoardFactory.CreateBoard(playerTwo, _settings));
    }
}
