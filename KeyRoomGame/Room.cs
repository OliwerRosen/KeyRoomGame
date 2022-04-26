using System;
using System.Collections.Generic;
using System.Text;

namespace KeyRoomGame
{
    class Room
    {
        public int RoomNumber { get; set; }
        public int XPosDoor { get; set; }
        public int YPosDoor { get; set; }
        public int XPosKey { get; set; }
        public int YPosKey { get; set; }
        public bool IsFirstRoom { get; set; }
        public bool IsLastRoom { get; set; }
        public int RandomOrderNr { get; set; }
        public Room(int roomNumber, int xPosDoor, int yPosDoor, int xPosKey, int yPosKey, bool isFirstRoom, bool isLastroom)
        {
            RoomNumber = roomNumber;
            XPosDoor = xPosDoor;
            YPosDoor = yPosDoor;
            XPosKey = xPosKey;
            YPosKey = yPosKey;
            IsFirstRoom = isFirstRoom;
            IsLastRoom = isLastroom;
        }

    }
}
