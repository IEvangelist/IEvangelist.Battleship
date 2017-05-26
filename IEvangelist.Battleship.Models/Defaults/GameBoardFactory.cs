using System;
using IEvangelist.Battleship.Models.Interfaces;

namespace IEvangelist.Battleship.Models.Defaults
{
    public class GameBoardFactory : IGameBoardFactory
    {
        private readonly IShipFactory _shipFactory;

        public GameBoardFactory(IShipFactory shipFactory)
        {
            _shipFactory = shipFactory ?? throw new ArgumentNullException(nameof(shipFactory));
        }

        public GameBoard CreateBoard(IPlayer player, GameSettings settings)
            => new GameBoard(player, settings, _shipFactory);
    }
}