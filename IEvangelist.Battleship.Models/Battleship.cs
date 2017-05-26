using IEvangelist.Battleship.Models.Enums;

namespace IEvangelist.Battleship.Models
{
    public class Battleship : Ship
    {
        public override ShipClass Classification { get; } = ShipClass.Battleship;
        
        public override byte Size { get; } = 4;
    }
}