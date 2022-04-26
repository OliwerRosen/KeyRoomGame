using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace KeyRoomGame
{
    class Game
    {
        private Player CurrentPlayer;
        private Key key0;
        private Key key1;
        private Key key2;
        private Key key3;
        private Key key4;
        private Key key5;
        private Key key6;
        private Key key7;
        private Key key8;
        private Key key9;
        private Key key10;
        private Door door0;
        private Door door1;
        private Door door2;
        private Door door3;
        private Door door4;
        private Door door5;
        private Door door6;
        private Door door7;
        private Door door8;
        private Door door9;
        private Door door10;
        //private Level level1;
        //private Level level2;
        //private Level level3;
        //private Level level4;
        //private Level level5;
        //private Level level6;
        //private Level level7;
        //private Level level8;
        //private Level level9;
        //private Level level10;
        private Room room0;
        private Room room1;
        private Room room2;
        private Room room3;
        private Room room4;
        private Room room5;
        private Room room6;
        private Room room7;
        private Room room8;
        private Room room9;
        private Room room10;


        public List<Door> doors = new List<Door>(10);
        List<Key> keys = new List<Key>(10);
        List<Level> levels = new List<Level>(10);
        List<Room> rooms = new List<Room>(10);

        private ConsoleColor CurrentColor;
        
        public int CurrentLevelNr;
        public void Start()
        {
            Console.CursorVisible = false;
            Console.Title = "KeyRoomGame";
            Level.SelectLevel(1);
            CurrentLevelNr = 1;
            CurrentPlayer = new Player(1, 1);
            CreateDoors();
            CreateKeys();
            CreateRooms();
            //CreateLevels();
            RandomizeRooms();

            GameLoop();
        }
        public void GameLoop()
        {
            while(true)
            {
                //Checkcurrentlevel
                DisplayBoard();
                HandlePlayerInput();
                //Check for win condition for the level
            }
        }
        private void CreateDoors()
        {
            if (CurrentLevelNr == 1)
            {
                door0 = new Door(true, "/", "White", 0, 18, 7);
                door1 = new Door(false, "D", "Green", 1, 18, 7);
                door2 = new Door(false, "D", "Blue", 2, 1, 1);
                door3 = new Door(false, "D", "DarkBlue", 3, 1, 1);
                door4 = new Door(false, "D", "Cyan", 4, 1, 1);
                door5 = new Door(false, "D", "DarkCyan", 5, 1, 1);
                door6 = new Door(false, "D", "Yellow", 6, 1, 1);
                door7 = new Door(false, "D", "DarkGreen", 7, 1, 1);
                door8 = new Door(false, "D", "Magenta", 8, 1, 1);
                door9 = new Door(false, "D", "DarkRed", 9, 1, 1);
                door10 = new Door(false, "D", "Grey", 10, 1, 1);
                Door[] newDoors = new Door[] { door0, door1, door2, door3, door4, door5, door6, door7, door8, door9, door10 };
                doors.AddRange(newDoors);
            }
            else
            {
                foreach (Door door in doors)
                {
                    if (door == doors[0])
                    {
                        door.DoorSymbol = "/";
                    }
                    else
                    {
                        door.CreateProperDoor();
                    }
                }
            }

        }
        public void CreateKeys()
        {
            if (CurrentLevelNr ==1)
            {
                key0 = new Key("K", "Green", 1, 3, 9);
                key1 = new Key("K", "Blue", 2, 1, 1);
                key2 = new Key("K", "DarkBlue", 3, 1, 1);
                key3 = new Key("K", "Cyan", 3, 1, 1);
                key4 = new Key("K", "DarkCyan", 4, 1, 1);
                key5 = new Key("K", "Yellow", 5, 1, 1);
                key6 = new Key("K", "Yellow", 6, 1, 1);
                key7 = new Key("K", "DarkGreen", 7, 1, 1);
                key8 = new Key("K", "Magenta", 8, 1, 1);
                key9 = new Key("K", "DarkRed", 9, 1, 1);
                key10 = new Key("K", "Gray", 10, 1, 1);
                Key[] newKeys = new Key[] { key0, key1, key2, key3, key4, key5, key6, key7, key8, key9, key10 };
                keys.AddRange(newKeys);
            }
            else
            {

            }
            
        }
        public void CreateRooms()
        {
            room0 = new Room(0, 9, 2, 9, 3, false, false);
            room1 = new Room(1, 16, 2, 18, 2, false, false);
            room2 = new Room(2, 4, 6, 4, 8, false, false);
            room3 = new Room(3, 8, 7, 8, 9, false, false);
            room4 = new Room(4, 18, 7, 18, 9, false, false);
            room5 = new Room(5, 13, 8, 13, 9, false, false);
            room6 = new Room(6, 8, 2, 8, 3, false, false);
            room7 = new Room(7, 8, 2, 8, 3, false, false);
            room8 = new Room(8, 8, 2, 8, 3, false, false);
            room9 = new Room(9, 8, 2, 8, 3, false, false);
            room10 = new Room(10, 8, 2, 8, 3, false, false);
            Room[] newRooms = new Room[] { room0, room1, room2, room3, room4, room5, room6, room7, room8, room9, room10 };
            rooms.AddRange(newRooms);
        }
        public void RandomizeRooms()
        {
            Random randomNr = new Random();
            List<int> roomOrder = new List<int>();
            string[,] currentLevel = Level.GetCurrentLevel();
            int randomNumber;
            while (roomOrder.Count <= CurrentLevelNr + 1)
            {
                if (CurrentLevelNr <= 5)
                {
                    randomNumber = randomNr.Next(0, 6 + 1);
                }
                else
                {
                    randomNumber = randomNr.Next(0, 10 + 1);
                }
                bool numberIsInList = false;
                foreach (int c in roomOrder)
                {
                    if (randomNumber == c)
                    {
                        numberIsInList = true;
                    }
                }
                if (numberIsInList == false)
                {
                    roomOrder.Add(randomNumber);
                }  
            }

            for (int i = 0; i <= CurrentLevelNr; i++)
            {
                
                if (i==0)
                {
                    rooms[roomOrder[i]].IsFirstRoom = true;
                    doors[i].DoorSymbol = "/";
                } 
                else if (i == CurrentLevelNr)
                {
                    //rooms[roomOrder[i]].IsLastRoom = true;
                    int x = rooms[roomOrder[i]].XPosKey;
                    int y = rooms[roomOrder[i]].YPosKey;

                    currentLevel[y, x] = "X";
                    Level.SetCurrentLevel(currentLevel);
                }
                else
                {
                    
                }
                doors[i].DoorPosX = rooms[roomOrder[i]].XPosDoor;
                doors[i].DoorPosY = rooms[roomOrder[i]].YPosDoor;
                keys[i].KeyPosX = rooms[roomOrder[i]].XPosKey;
                keys[i].KeyPosY = rooms[roomOrder[i]].YPosKey;

            }
        }
        public void DisplayBoard()
        {
            Clear();
            DrawLevel();
            DrawDoors();
            DrawKeys();
            CurrentPlayer.Draw();
        }
        public void DrawLevel()
        {
            string[,] currentLevelArray = Level.GetCurrentLevel();
            int rowsGrid = currentLevelArray.GetLength(0);
            int colsGrid = currentLevelArray.GetLength(1);

            for (int y = 0; y < rowsGrid; y++)
            {
                for (int x = 0; x < colsGrid; x++)
                {
                    string element = currentLevelArray[y, x];
                    SetCursorPosition(x, y);
                    
                    Write(element);
                }
            }
            //Draw info box
            string[,] infoBoxArray = Level.GetInfoBox();
            int rowsInfoBox = infoBoxArray.GetLength(0);
            int colsInfoBox = infoBoxArray.GetLength(1);
            for (int y = 0; y < rowsInfoBox; y++)
            {
                for (int x = 0; x < colsInfoBox; x++)
                {
                    ForegroundColor = ConsoleColor.Blue;
                    string element = infoBoxArray[y, x];
                    SetCursorPosition(x, y + rowsGrid + 1);
                    Write(element);
                }
            }
            ResetColor();
            //Draw level info
            string element2 = "Level: " + CurrentLevelNr;
            SetCursorPosition( 1 , 7 + rowsGrid);
            Write(element2);

            //DrawInfo
            SetCursorPosition(1, rowsGrid + 2);
            Write("Info:");
            

            //Draw "keys" 
            SetCursorPosition(1, 16);
            Write("Inventory:");


        }
        private void DrawDoors()
        {
            for (var i = 0; i <= CurrentLevelNr; i++)
            {
                //int doorNumber = doors[i].DoorNumber;
                //bool isDoorOpen = doors[i].IsDoorOpen;
                string doorColor = doors[i].DoorColor;
                string doorSymbol = doors[i].DoorSymbol;
                int doorPosX = doors[i].DoorPosX;
                int doorPosY = doors[i].DoorPosY;
                DrawObjectToMap(doorPosX, doorPosY, doorSymbol, doorColor);
            }
        }
        private void DrawKeys()
        {
            for (var i = 0; i < CurrentLevelNr; i++)
            {
                string keyColor = keys[i].KeyColor;
                string keySymbol = keys[i].KeySymbol;
                int keyPosX = keys[i].KeyPosX;
                int keyPosY = keys[i].KeyPosY;
                DrawObjectToMap(keyPosX, keyPosY, keySymbol, keyColor);
            }
        }
        public void DrawObjectToMap(int x, int y, string symbol, string color)
        {
            ConsoleColor.TryParse(color, out CurrentColor);
            Console.ForegroundColor = CurrentColor;
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
            Console.ResetColor();
        }
        private void HandlePlayerInput()
        {
            ConsoleKey key;
            do
            {
                ConsoleKeyInfo keyInfo = ReadKey(true);
                key = keyInfo.Key;

            } while (KeyAvailable);

            switch (key)
            {
                case ConsoleKey.W:
                    NextSquareHandler(CurrentPlayer.X, CurrentPlayer.Y - 1);
                    break;
                case ConsoleKey.S:
                    NextSquareHandler(CurrentPlayer.X, CurrentPlayer.Y + 1);
                    break;
                case ConsoleKey.A:
                    NextSquareHandler(CurrentPlayer.X - 1, CurrentPlayer.Y);
                    break;
                case ConsoleKey.D:
                    NextSquareHandler(CurrentPlayer.X + 1, CurrentPlayer.Y);
                    break;
                case ConsoleKey.R:
                    GoToNextLevel();
                    break;
                default:
                    break;
            }
        }
        private void NextSquareHandler(int x, int y)
        {
            //Check for closed door
            string[,] currentLevel = Level.GetCurrentLevel();
            bool playerHasRightKey = false;
            bool squareIsClosedDoor = false;
            for (int i = 0; i < doors.Count; i++)
            {
                if (doors[i].DoorPosX == x && doors[i].DoorPosY == y && (doors[i].DoorSymbol== "I" || doors[i].DoorSymbol == "-"))
                {
                    squareIsClosedDoor = true;
                    foreach (Key key in CurrentPlayer.KeyInventory)
                    {
                        if (doors[i].DoorColor == key.KeyColor)
                        {
                            doors[i].DoorSymbol = "/";
                            Level.CurrentLevel[y, x] = "/";
                            WriteInInfoBox("Door opened...");
                            Console.ReadKey();
                            playerHasRightKey = true;
                            break;
                        }
                    }
                    if (playerHasRightKey == true)
                    {
                        break;
                    }
                    else 
                    {
                        WriteInInfoBox("You don't have the right key for this door.");
                        Console.ReadKey();
                    }
                }
            }

            //Check if position is walkable
            if ((Level.IsPositionWalkable(x, y) && squareIsClosedDoor==false) || (Level.IsPositionWalkable(x, y) && squareIsClosedDoor == true && playerHasRightKey == true))
            {
                CurrentPlayer.X = x;
                CurrentPlayer.Y = y;
            }

            //Check for key in square
            for (int i = 0; i < keys.Count; i++)
            {
                if (keys[i].KeyPosX == x && keys[i].KeyPosY == y && currentLevel[y,x]!= "X" )
                {
                    Key NewKey = new Key(keys[i].KeySymbol, keys[i].KeyColor, keys[i].KeyNumber, keys[i].KeyPosX, keys[i].KeyPosY);
                    CurrentPlayer.KeyInventory.Add(NewKey);
                    WriteInInfoBox("Key added.");
                    keys[i].KeyPosX = i+1;
                    keys[i].KeyPosY = Level.Rows + 6;
                    Console.ReadKey();
                }
            }

            //Check for teleport square

            if (currentLevel[y, x].Contains("T"))
            {
                if (CurrentPlayer.X==1)
                {
                    CurrentPlayer.X = 23;
                    CurrentPlayer.Y = 1;
                }
                else if(CurrentPlayer.X == 36)
                {
                    CurrentPlayer.X = 1;
                    CurrentPlayer.Y = 1;
                }
                WriteInInfoBox("You used the teleporter.");
            }

                //Check for exit square
            if (currentLevel[y,x].Contains("X"))
            {
                GoToNextLevel();
            }
        }
        private void GoToNextLevel()
        {
            CurrentLevelNr++;
            if (CurrentLevelNr <= 10)
            {
                Level.SelectLevel(CurrentLevelNr);
                RandomizeRooms();
                CreateKeys();
                CreateDoors();
                CurrentPlayer.KeyInventory.Clear();
                WriteInInfoBox("You are going to the next level. :)");
                Console.ReadLine();
                CurrentPlayer.X = 1;
                CurrentPlayer.Y = 1;
            }
            else
            {
                WonGameDisplay();
            }
        }

        public void WriteInInfoBox(string text)
        {
            ForegroundColor = ConsoleColor.White;
            SetCursorPosition(1, 14);
            Write(text);
            ResetColor();
        }
        public void WriteKeyInventory()
        {
            for (int i = 0; i < CurrentPlayer.KeyInventory.Count; i++)
            {
                switch(CurrentPlayer.KeyInventory[i].KeyNumber)
                {
                    case 1:
                        ForegroundColor = ConsoleColor.Green;
                        break;
                    case 2:
                        ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 3:
                        ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case 4:
                        ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case 5:
                        ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case 6:
                        ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 7:
                        ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case 8:
                        ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 9:
                        ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case 10:
                        ForegroundColor = ConsoleColor.Gray;
                        break;

                }
 
                SetCursorPosition(Level.Cols + 2 , 2+i);
                Console.Write(CurrentPlayer.KeyInventory[i]);
                ResetColor();
            }
            foreach (var Key in CurrentPlayer.KeyInventory)
            {
                SetCursorPosition(Level.Cols+2, 2);
            }
        }
        public void WonGameDisplay()
        {
            WriteInInfoBox("You won the game...");
        }

    }


    
}
