using IEvangelist.Battleship.Models.Enums;

namespace IEvangelist.Battleship.Models
{
    public class AircraftCarrier : Ship
    {
        public override ShipClass Classification { get; } = ShipClass.AircraftCarrier;
        
        public override byte Size { get; } = 5;
    }
}