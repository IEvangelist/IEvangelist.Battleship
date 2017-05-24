namespace IEvangelist.Battleship.Emulator
{
    public interface IGameEmulator
    {
        void Start();

        IRoundExecutor NextRound();

        void End();
    }
}