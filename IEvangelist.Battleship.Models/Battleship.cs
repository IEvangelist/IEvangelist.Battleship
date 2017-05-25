using System;
using IEvangelist.Battleship.Models.Enums;

namespace IEvangelist.Battleship.Models
{
    public class Battleship : Ship
    {
        public override ShipClass Classification { get; } = ShipClass.Battleship;

        public override bool IsSank => throw new NotImplementedException();

        public override bool IsHit => throw new NotImplementedException();

        public override int Size { get; } = 4;
    }
}