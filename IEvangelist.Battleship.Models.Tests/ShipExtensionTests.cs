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
            InlineData(1, 1, ShipAlignment.Vertical, 1, 1, CellState.Hit)
        ]
        public void CalculateShotTest(byte row, 
                                      byte column, 
                                      ShipAlignment alignment,
                                      byte shotRow,
                                      byte shotCol,
                                      CellState expected)
        {
            var ship = _shipFactory.CreateShips<AircraftCarrier>(1)[0];
            ship.Place(new Position(row, column, alignment));

            Assert.Equal(expected, ship.CalculateShot(new Shot { Row = shotRow, Column = shotCol }));
        }
    }
}