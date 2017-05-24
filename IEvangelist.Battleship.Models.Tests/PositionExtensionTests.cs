using IEvangelist.Battleship.Models.Enums;
using IEvangelist.Battleship.Models.Extensions;
using Xunit;

namespace IEvangelist.Battleship.Models.Tests
{
    public class PositionExtensionTests
    {
        [
            Theory,
            InlineData(null, null, null, false),
            InlineData(null, null, (ShipAlignment)7, false),
            InlineData((byte)1, null, null, false), 
            InlineData(null, (byte)1, null, false),
            InlineData(null, null, ShipAlignment.Vertical, false),
            InlineData((byte)1, (byte)1, ShipAlignment.Vertical, true)
        ]
        public void IsValidTest(
            byte? row,
            byte? column,
            ShipAlignment? alignment,
            bool expected)
            => Assert.Equal(expected, new Position(row, column, alignment).IsValid());

        [
            Theory,
            InlineData((byte)1, (byte)1, ShipAlignment.Vertical, 2, 10, 10, true),
            InlineData((byte)1, (byte)1, ShipAlignment.Vertical, 4, 3, 3, false),
            InlineData((byte)6, (byte)1, ShipAlignment.Vertical, 5, 10, 10, false),
            InlineData((byte)1, (byte)1, ShipAlignment.Horizontal, 3, 10, 10, true),
            InlineData((byte)1, (byte)5, ShipAlignment.Horizontal, 6, 10, 10, false),
            InlineData((byte)11, (byte)5, ShipAlignment.Horizontal, 2, 10, 10, false),
            InlineData((byte)3, (byte)11, ShipAlignment.Vertical, 3, 10, 10, false),
            InlineData(null, null, null, 0, 10, 10, false)
        ]
        public void FitsOnGridTest(byte? row,
                                   byte? column,
                                   ShipAlignment? alignment,
                                   byte size,
                                   byte rows,
                                   byte columns,
                                   bool expected)
            => Assert.Equal(
                expected, 
                new Position(row, column, alignment).FitsOnGrid(
                    new Grid(rows, columns), size));
    }
}