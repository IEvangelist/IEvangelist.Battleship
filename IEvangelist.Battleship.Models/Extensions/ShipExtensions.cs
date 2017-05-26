using IEvangelist.Battleship.Models.Enums;

namespace IEvangelist.Battleship.Models.Extensions
{
    public static class ShipExtensions
    {
        public static CellState CalculateShot(this Ship ship, Shot shot)
        {
            var position = ship.Position;
            if (position.IsValid())
            {
                var pRow = position.Row.Value;
                var pCol = position.Column.Value;

                if (pRow == shot.Row &&
                    pCol == shot.Column)
                {
                    return CellState.Hit;
                }

                if (pRow == shot.Row &&
                    position.Alignment == ShipAlignment.Horizontal &&
                    pCol - ship.Size <= 0)
                {
                    return CellState.Hit;
                }

                if (pCol == shot.Column &&
                    position.Alignment == ShipAlignment.Vertical &&
                    pRow - ship.Size <= 0)
                {
                    return CellState.Hit;
                }

                return CellState.Miss;
            }

            return CellState.Available;
        }
    }
}