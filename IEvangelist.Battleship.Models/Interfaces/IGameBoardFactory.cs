namespace IEvangelist.Battleship.Models.Interfaces
{
    public interface IGameBoardFactory
    {
        GameBoard CreateBoard(IPlayer player, GameSettings settings);
    }
}