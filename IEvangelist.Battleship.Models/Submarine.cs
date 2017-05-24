using System;
using IEvangelist.Battleship.Models.Enums;

namespace IEvangelist.Battleship.Models
{
    public class Submarine : Ship
    {
        public override ShipClass Classification { get; } = ShipClass.Submarine;

        public override bool IsSank => throw new NotImplementedException();

        public override bool IsHit => throw new NotImplementedException();

        public override int Size => throw new NotImplementedException();
    }
}
