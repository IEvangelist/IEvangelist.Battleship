using IEvangelist.Battleship.Models.Enums;

namespace IEvangelist.Battleship.Models
{
    public abstract class Ship
    {
        public abstract ShipClass Classification { get; }
        
        public abstract byte Size { get; }

        public Position Position { get; private set; }

        public void Place(Position position) => Position = position;
    }
}