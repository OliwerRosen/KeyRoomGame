using System;
using System.Collections.Generic;
using System.Text;

namespace KeyRoomGame
{
    class Level
    {
        public static string[,] CurrentLevel { get; set; }
        public static int Cols { get; set; }
        public static int Rows { get; set; }

        private static readonly string[,] Level1 = LevelParser.ParseFileToArray("Level2.txt");
        private static readonly string[,] Level2 = LevelParser.ParseFileToArray("Level2.txt");
        public static string[,] Level3 = LevelParser.ParseFileToArray("Level2.txt");
        public static string[,] Level4 = LevelParser.ParseFileToArray("Level2.txt");
        public static string[,] Level5 = LevelParser.ParseFileToArray("Level2.txt");
        public static string[,] Level6 = LevelParser.ParseFileToArray("Level3.txt");
        public static string[,] Level7 = LevelParser.ParseFileToArray("Level3.txt");
        public static string[,] Level8 = LevelParser.ParseFileToArray("Level3.txt");
        public static string[,] Level9 = LevelParser.ParseFileToArray("Level3.txt");
        public static string[,] Level10 = LevelParser.ParseFileToArray("Level3.txt");
        private static readonly string[,] infoBox = LevelParser.ParseFileToArray("InfoBox.txt");


        public Level(int levelNumber)
        {
            SelectLevel(levelNumber);
        }
        public static void SelectLevel(int levelNumber)
        {
            bool validInput = false;
            while (!validInput)
            {
                switch (levelNumber)
                {
                    case 1:
                        CurrentLevel = Level1;
                        validInput = true;
                        break;
                    case 2:
                        CurrentLevel = Level2;
                        validInput = true;
                        break;
                    case 3:
                        CurrentLevel = Level3;
                        validInput = true;
                        break;
                    case 4:
                        CurrentLevel = Level4;
                        validInput = true;
                        break;
                    case 5:
                        CurrentLevel = Level5;
                        validInput = true;
                        break;
                    case 6:
                        CurrentLevel = Level6;
                        validInput = true;
                        break;
                    case 7:
                        CurrentLevel = Level7;
                        validInput = true;
                        break;
                    case 8:
                        CurrentLevel = Level8;
                        validInput = true;
                        break;
                    case 9:
                        CurrentLevel = Level9;
                        validInput = true;
                        break;
                    case 10:
                        CurrentLevel = Level10;
                        validInput = true;
                        break;

                    default:
                        Console.WriteLine("wrong entry");
                        break;
                }
            }
            Rows = CurrentLevel.GetLength(0);
            Cols = CurrentLevel.GetLength(1);
        }
        public static string[,] GetCurrentLevel()
        {
            return CurrentLevel;
        }
        public static void SetCurrentLevel(string[,] currentLevel)
        {
            CurrentLevel = currentLevel;
        }
        public static string[,] GetInfoBox()
        {
            return infoBox;
        }
        public static bool IsPositionWalkable(int x, int y)
        {
            if (x < 0 || y < 0 || x > Cols || y > Rows)
            {
                return false;
            }
            //SquareContainsDoor();
            return CurrentLevel[y,x] == " " || CurrentLevel[y, x] == "X" || CurrentLevel[y, x] == "/";
        }
        

    }
}
