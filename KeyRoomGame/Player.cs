using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace KeyRoomGame
{
    class Player
    {
        public bool IsMovementAllowed { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string PlayerMarker { get; set; }
        public List<Key> KeyInventory { get; set; }
        private ConsoleColor PlayerColor;

        public Player(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
            PlayerMarker = "O";
            PlayerColor = ConsoleColor.Red;
            KeyInventory = new List<Key>();
        }
        public void Draw()
        {
            ForegroundColor = PlayerColor;
            SetCursorPosition(X, Y);
            Write(PlayerMarker);
            ResetColor();
        }
    }
}
