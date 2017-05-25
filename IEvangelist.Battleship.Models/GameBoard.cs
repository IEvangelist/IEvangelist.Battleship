using System;
using System.Collections.Generic;
using IEvangelist.Battleship.Models.Interfaces;

namespace IEvangelist.Battleship.Models
{
    public class GameBoard
    {
        public Guid Identifer { get; } = Guid.NewGuid();

        public Player Player { get; }

        public List<Ship> Ships { get; } = new List<Ship>();

        /// <summary>
        /// The primary grid is the grid in which a player places their ships.
        /// This grid tracks enemy shots fired.
        /// </summary>
        public Grid PrimaryGrid { get; }

        /// <summary>
        /// The tracking grid is used to track this player's shots. The player
        /// leverages this grid to reason about where the enemy ships are placed
        /// based on cumulative shots fired.
        /// </summary>
        public Grid TrackingGrid { get; }

        internal GameBoard(Player player, 
                           GameSettings settings, 
                           IShipFactory shipFactory)
        {
            Player = player;

            var gridSize = settings.GridSize;
            PrimaryGrid = new Grid(gridSize, gridSize);
            TrackingGrid = new Grid(gridSize, gridSize);

            Ships.AddRange(shipFactory.CreateShips<AircraftCarrier>(settings.AircraftCarrierCount));
            Ships.AddRange(shipFactory.CreateShips<Battleship>(settings.BattelshipCount));
            Ships.AddRange(shipFactory.CreateShips<Crusier>(settings.CrusierCount));
            Ships.AddRange(shipFactory.CreateShips<Destroyer>(settings.DestroyerCount));
            Ships.AddRange(shipFactory.CreateShips<Submarine>(settings.SubmarineCount));
        }
    }
}