using System;
using IEvangelist.Battleship.Models.Enums;

namespace IEvangelist.Battleship.Models
{
    public class AircraftCarrier : Ship
    {
        public override ShipClass Classification { get; } = ShipClass.AircraftCarrier;

        public override bool IsSank => throw new NotImplementedException();

        public override bool IsHit => throw new NotImplementedException();

        public override int Size { get; } = 5;
    }
}
