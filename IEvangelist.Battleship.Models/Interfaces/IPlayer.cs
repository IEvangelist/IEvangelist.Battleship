using System;
using IEvangelist.Battleship.Models.Enums;

namespace IEvangelist.Battleship.Models.Interfaces
{
    public interface IPlayer
    {
        Guid Id { get; set; }

        string Name { get; set; }

        CellState CallShot(Ship ship, Grid grid, Shot shot);

        void PlaceShip(Ship ship, Position position);
    }
}