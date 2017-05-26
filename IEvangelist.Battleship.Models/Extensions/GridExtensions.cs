namespace IEvangelist.Battleship.Models.Extensions
{
    public static class GridExtensions
    {
        public static bool IsValidShot(this Grid grid, Shot shot)
            => shot.Row <= grid.RowCount &&
               shot.Column <= grid.ColumnCount;
    }
}