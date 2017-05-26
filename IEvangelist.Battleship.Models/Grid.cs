using IEvangelist.Battleship.Models.Enums;
using IEvangelist.Battleship.Models.Extensions;

namespace IEvangelist.Battleship.Models
{
    public class Grid
    {
        private CellState[,] _shotGrid;

        public byte RowCount { get; }

        public byte ColumnCount { get; }

        public CellState this[byte row, byte column]
        {
            get => _shotGrid[row, column];
            set => _shotGrid[row, column] = value;
        }

        public Grid(byte rows = 10, byte columns = 10)
        {
            _shotGrid = new CellState[RowCount = rows, 
                                      ColumnCount = columns];

            for (byte r = 0; r < rows; ++ r)
            {
                for (byte c = 0; c < columns; ++ c)
                {
                    _shotGrid[r, c] = CellState.Available;
                }
            }
        }

        public CellState HandleShot(Ship ship, Shot shot) 
            => _shotGrid[shot.Row, shot.Column] = ship.CalculateShot(shot);
    }
}