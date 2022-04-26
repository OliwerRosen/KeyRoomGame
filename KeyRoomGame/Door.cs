using System;
using System.Collections.Generic;
using System.Text;

namespace KeyRoomGame
{
    class Door
    {
        public int DoorNumber { get; set; }
        public bool IsDoorOpen { get; set; }
        public string DoorColor { get; set; }
        public string DoorSymbol { get; set; }
        public int DoorPosX { get; set; }
        public int DoorPosY { get; set; }

        Door()
        {
        }
        public Door(bool isDoorOpen, string doorSymbol, string doorColor, int doorNumber, int doorPosX, int doorPosY)
        {
            IsDoorOpen = isDoorOpen;
            DoorSymbol = doorSymbol;
            DoorColor = doorColor;
            DoorNumber = doorNumber;
            DoorPosX = doorPosX;
            DoorPosY = doorPosY;
            CreateProperDoor();

        }
        public void CreateProperDoor()
        {
            string[,] currentArray = Level.GetCurrentLevel();
            if (currentArray[DoorPosY, DoorPosX - 1].Contains("─") || currentArray[DoorPosY - 1, DoorPosX].Contains("├"))
            {
                DoorSymbol = "-";
            }
            else if (currentArray[DoorPosY, DoorPosX + 1].Contains("─") || currentArray[DoorPosY, DoorPosX + 1].Contains("┤"))
            {
                DoorSymbol = "-";
            }
            else if (currentArray[DoorPosY - 1, DoorPosX].Contains("│") || currentArray[DoorPosY - 1, DoorPosX].Contains("┬"))
            {
                DoorSymbol = "I";
            }
            else if (currentArray[DoorPosY + 1, DoorPosX].Contains("│") || currentArray[DoorPosY - 1, DoorPosX].Contains("┴"))
            {
                DoorSymbol = "I";
            }

        }
        //public List<Door> keys = new List<Door>
        //{
        //    new Door {IsDoorOpen = false, DoorSymbol = "I", DoorColor = "Green", DoorNumber = 1},
        //    new Door {IsDoorOpen = false, DoorSymbol = "I", DoorColor = "Blue", DoorNumber = 2},
        //    new Door {IsDoorOpen = false, DoorSymbol = "I", DoorColor = "DarkBlue", DoorNumber = 3},
        //    new Door {IsDoorOpen = false, DoorSymbol = "I", DoorColor = "Cyan", DoorNumber = 4},
        //    new Door {IsDoorOpen = false, DoorSymbol = "I", DoorColor = "DarkCyan", DoorNumber = 5},
        //    new Door {IsDoorOpen = false, DoorSymbol = "I", DoorColor = "Yellow", DoorNumber = 6},
        //    new Door {IsDoorOpen = false, DoorSymbol = "I", DoorColor = "DarkGreen", DoorNumber = 7},
        //    new Door {IsDoorOpen = false, DoorSymbol = "I", DoorColor = "Magenta", DoorNumber = 8},
        //    new Door {IsDoorOpen = false, DoorSymbol = "I", DoorColor = "DarkRed", DoorNumber = 9},
        //    new Door {IsDoorOpen = false, DoorSymbol = "I", DoorColor = "Grey", DoorNumber = 10},
        //};

    }
}
