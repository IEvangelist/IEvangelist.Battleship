using System;

namespace IEvangelist.Battleship.Models
{
    public class GameBoard
    {
        public Guid Identifer { get; } = Guid.NewGuid();

        public Player Player { get; }

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

        internal GameBoard(Player player, byte gridSize)
        {
            Player = player;
            PrimaryGrid = new Grid(gridSize, gridSize);
            TrackingGrid = new Grid(gridSize, gridSize);
        }
    }
}