using System;
using System.Collections.Generic;
using System.Text;

namespace KeyRoomGame
{
    class Key
    {
        public string KeySymbol { get; set; }
        public string KeyColor { get; set; }
        public int KeyNumber { get; set; }
        public int KeyPosX { get; set; }
        public int KeyPosY { get; set; }


        //public string[,] AvailableKeyColors { get; set; }
        //private string[] availableKeyColors =["Red", "Green"];
        public Key(string keySymbol, string keyColor, int keyNumber, int keyPosX, int keyPosY)
        {
            KeySymbol = keySymbol;
            KeyColor = keyColor;
            KeyNumber = keyNumber;
            KeyPosX = keyPosX;
            KeyPosY = keyPosY;
        }
        public Key()
        {

        }

  
    }
}
