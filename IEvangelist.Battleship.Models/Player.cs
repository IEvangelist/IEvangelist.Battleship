using System;

namespace IEvangelist.Battleship.Models
{
    public class Player
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }
    }
}