using IEvangelist.Battleship.Models.Enums;

namespace IEvangelist.Battleship.Models
{
    public struct Position
    {
        public byte? Row { get; }

        public byte? Column { get; }

        public ShipAlignment? Alignment { get; }

        public Position(byte? row = null, 
                        byte? column = null,
                        ShipAlignment? alignment = null)
        {
            Row = row;
            Column = column;
            Alignment = alignment;
        }
    }
}