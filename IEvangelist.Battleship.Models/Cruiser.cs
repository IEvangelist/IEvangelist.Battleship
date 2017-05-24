using System;
using IEvangelist.Battleship.Models.Enums;

namespace IEvangelist.Battleship.Models
{
    public class Crusier : Ship
    {
        public override ShipClass Classification { get; } = ShipClass.Cruiser;

        public override bool IsSank => throw new NotImplementedException();

        public override bool IsHit => throw new NotImplementedException();

        public override int Size => throw new NotImplementedException();
    }
}
