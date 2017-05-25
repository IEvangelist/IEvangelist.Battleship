using System;
using IEvangelist.Battleship.Models.Enums;

namespace IEvangelist.Battleship.Models
{
    public class Destroyer : Ship
    {
        public override ShipClass Classification { get; } = ShipClass.Destroyer;

        public override bool IsSank => throw new NotImplementedException();

        public override bool IsHit => throw new NotImplementedException();

        public override int Size { get; } = 2;
    }
}