namespace IEvangelist.Battleship.GameEngine
{
    public class GameSettings
    {
        public int AircraftCarrierCount { get; set; } = 1;

        public int CrusierCount { get; set; } = 1;

        public int DestroyerCount { get; set; } = 2;

        public int SubmarineCount { get; set; } = 2;

        public int BattelshipCount { get; set; } = 1;

        public int GridSize { get; set; } = 10;

        public int NumberOfPlayers { get; set; } = 2;
    }
}