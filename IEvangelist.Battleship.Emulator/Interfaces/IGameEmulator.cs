namespace IEvangelist.Battleship.Emulator.Interfaces
{
    public interface IGameEmulator
    {
        void Start();

        IRoundExecutor NextRound();

        void End();
    }
}