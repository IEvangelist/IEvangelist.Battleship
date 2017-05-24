using IEvangelist.Battleship.Models.Interfaces;

namespace IEvangelist.Battleship.Models.Defaults
{
    public class GameBoardFactory : IGameBoardFactory
    {
        public GameBoard CreateBoard(Player player, GameSettings settings)
            => new GameBoard(player, settings.GridSize);
    }
}