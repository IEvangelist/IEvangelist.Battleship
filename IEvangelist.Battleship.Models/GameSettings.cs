namespace IEvangelist.Battleship.Models
{
    public class GameSettings
    {
        public byte AircraftCarrierCount { get; set; } = 1;

        public byte CrusierCount { get; set; } = 1;

        public byte DestroyerCount { get; set; } = 2;

        public byte SubmarineCount { get; set; } = 2;

        public byte BattelshipCount { get; set; } = 1;

        public byte GridSize { get; set; } = 10;

        public byte NumberOfPlayers { get; set; } = 2;
    }
}