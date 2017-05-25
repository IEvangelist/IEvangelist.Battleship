using System.Collections.Generic;
using System.Linq;
using IEvangelist.Battleship.Models.Interfaces;

namespace IEvangelist.Battleship.Models.Defaults
{
    public class ShipFactory : IShipFactory
    {
        public IList<T> CreateShips<T>(int count)
            where T : Ship, new()
            => Enumerable.Range(0, count)
                         .Select(_ => new T())
                         .ToList();
    }
}