using IEvangelist.Battleship.Models.Enums;

namespace IEvangelist.Battleship.Models
{
    public abstract class Ship
    {
        public abstract ShipClass Classification { get; }

        public abstract bool IsSank { get; }

        public abstract bool IsHit { get; }

        public abstract int Size { get; }

        public Position Position { get; }
    }
}