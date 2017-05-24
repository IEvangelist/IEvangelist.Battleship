namespace IEvangelist.Battleship.Models.Interfaces
{
    public interface IGameBoardFactory
    {
        GameBoard CreateBoard(Player player, GameSettings settings);
    }
}