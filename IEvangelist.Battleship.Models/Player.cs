using System;
using IEvangelist.Battleship.Models.Enums;
using IEvangelist.Battleship.Models.Interfaces;

namespace IEvangelist.Battleship.Models
{
    public class Player : IPlayer
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public void PlaceShip(Ship ship, Position position) 
            => ship.Place(position);

        public CellState CallShot(Ship ship, Grid grid, Shot shot) 
            => grid.HandleShot(ship, shot);
    }
}