using IEvangelist.Battleship.Models;

namespace IEvangelist.Battleship.Emulator
{
    public class Game
    {
        public GameBoard BoardOne { get; }

        public GameBoard BoardTwo { get; }

        internal Game(GameBoard one, GameBoard two)
        {
            BoardOne = one;
            BoardTwo = two;
        }
    }
}