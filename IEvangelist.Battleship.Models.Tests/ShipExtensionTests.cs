using System.Linq;
using IEvangelist.Battleship.Models.Defaults;
using IEvangelist.Battleship.Models.Enums;
using IEvangelist.Battleship.Models.Extensions;
using IEvangelist.Battleship.Models.Interfaces;
using Xunit;

namespace IEvangelist.Battleship.Models.Tests
{
    public class ShipExtensionTests
    {
        private readonly IShipFactory _shipFactory = new ShipFactory();

        [
            Theory,
            InlineData(1, 1, ShipAlignment.Vertical, 1, 1, CellState.Hit),
            InlineData(1, 1, ShipAlignment.Vertical, 1, 2, CellState.Miss),
            InlineData(1, 1, ShipAlignment.Vertical, 5, 1, CellState.Hit),
            InlineData(1, 1, ShipAlignment.Vertical, 6, 1, CellState.Miss),
            InlineData(1, 1, ShipAlignment.Horizontal, 1, 1, CellState.Hit),
            InlineData(1, 1, ShipAlignment.Horizontal, 2, 1, CellState.Miss),
            InlineData(1, 1, ShipAlignment.Horizontal, 1, 5, CellState.Hit),
            InlineData(1, 1, ShipAlignment.Horizontal, 1, 6, CellState.Miss),
            InlineData(5, 1, ShipAlignment.Vertical, 7, 1, CellState.Hit),
            InlineData(1, 5, ShipAlignment.Horizontal, 1, 9, CellState.Hit)
        ]
        public void CalculateShotTest(byte row,
                                      byte column,
                                      ShipAlignment alignment,
                                      byte shotRow,
                                      byte shotCol,
                                      CellState expected) 
            => Assert.Equal(expected, 
                            CreateShip(row, column, alignment).CalculateShot(
                                new Shot
                                {
                                    Row = shotRow,
                                    Column = shotCol
                                }));

        private Ship CreateShip(byte row, byte col, ShipAlignment alignment)
        {
            var ship = _shipFactory.CreateShips<AircraftCarrier>(1).Single();
            ship.Place(new Position(row, col, alignment));

            return ship;
        }
    }
}