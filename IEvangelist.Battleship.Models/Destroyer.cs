using IEvangelist.Battleship.Models.Enums;

namespace IEvangelist.Battleship.Models
{
    public class Destroyer : Ship
    {
        public override ShipClass Classification { get; } = ShipClass.Destroyer;
        
        public override byte Size { get; } = 2;
    }
}