using System.Collections.Generic;

namespace IEvangelist.Battleship.Models.Interfaces
{
    public interface IShipFactory
    {
        IList<T> CreateShips<T>(int count) where T : Ship, new();
    }
}