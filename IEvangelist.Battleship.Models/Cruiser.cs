using IEvangelist.Battleship.Models.Enums;

namespace IEvangelist.Battleship.Models
{
    public class Crusier : Ship
    {
        public override ShipClass Classification { get; } = ShipClass.Cruiser;
        
        public override byte Size { get; } = 3;
    }
}