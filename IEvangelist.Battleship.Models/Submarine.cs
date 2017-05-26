using IEvangelist.Battleship.Models.Enums;

namespace IEvangelist.Battleship.Models
{
    public class Submarine : Ship
    {
        public override ShipClass Classification { get; } = ShipClass.Submarine;

        public override byte Size { get; } = 3;
    }
}