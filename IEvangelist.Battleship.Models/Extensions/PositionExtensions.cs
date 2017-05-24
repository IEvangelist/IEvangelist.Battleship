using System;
using IEvangelist.Battleship.Models.Enums;

namespace IEvangelist.Battleship.Models.Extensions
{
    public static class PositionExtensions
    {
        public static bool IsInvalid(this Position position)
            => !position.IsValid();

        public static bool IsValid(this Position position)
            => position.Row.HasValue && 
               position.Column.HasValue && 
               position.Alignment.HasValue && 
               Enum.IsDefined(typeof(ShipAlignment), position.Alignment);

        public static bool FitsOnGrid(this Position position, Grid grid, byte size)
        {
            if (position.IsInvalid() ||
                position.Row > grid.RowCount ||
                position.Column > grid.ColumnCount)
            {
                return false;
            }

            if (position.Alignment == ShipAlignment.Vertical)
            {
                return grid.RowCount - (position.Row + size) >= 0;
            }
            else
            {
                return grid.ColumnCount - (position.Column + size) >= 0;
            }
        }
    }
}