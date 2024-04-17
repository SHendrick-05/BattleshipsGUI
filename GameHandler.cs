using System;
using System.Drawing;
using System.Collections.Generic;

namespace BattleshipsGUI
{
    public class Player
    {
        public Square[,] boardArr;
        public Discover[,] visualBoardArr;
        public Point[] ships;
        public int shipCount;
        public Player()
        {
            boardArr = new Square[5, 5];
            visualBoardArr = new Discover[5, 5];
            ships = new Point[2];
            shipCount = 0;
        }
    }

    internal static class GameHandler
    {
        // Important variables
        public static Player[] players;
        public static bool isPlayerTurn;
        public static bool gameStarted;
        public static bool gameEnded;
        public static List<Point> CPUGuesses;
        public static List<Point> playerGuesses;

        internal static void genGame()
        {
            players = new Player[2];
            players[0] = new Player();
            players[1] = genCPUPlayer();
            CPUGuesses = new List<Point>();
            playerGuesses = new List<Point>();
        }

        internal static Player genCPUPlayer()
        {
            Player result = new Player();
            Random rnd = new Random();
            Point rn1 = new Point(rnd.Next(0, 5), rnd.Next(0, 5));
            Point rn2;
            do
            {
                rn2 = new Point(rnd.Next(0, 5), rnd.Next(0, 5));
            } while (rn1 == rn2);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    result.boardArr[i, j] = Square.WATER;
                    result.visualBoardArr[i, j] = Discover.NONE;
                }
            }
            result.boardArr[rn1.X, rn1.Y] = Square.SHIP;
            result.boardArr[rn2.X, rn2.Y] = Square.SHIP;
            result.shipCount = 2;
            return result;
        }
        internal static bool Guess(bool playerGuess, Point? _guess = null)
        {
            Point guess = new Point();
            if (_guess == null)
            {
                Random rnd = new Random();
                guess = new Point(rnd.Next(0, 5), rnd.Next(0, 5));
            }
            else guess = _guess.Value;
            int index = playerGuess ? 1 : 0;
            Player plr = players[index];
            switch(plr.boardArr[guess.X, guess.Y])
            {
                case Square.SHIP:
                    plr.boardArr[guess.X, guess.Y] = Square.SUNK;
                    plr.visualBoardArr[guess.X, guess.Y] = Discover.SUNK;
                    return true;
                case Square.WATER:
                    plr.boardArr[guess.X, guess.Y] = Square.MISS;
                    plr.visualBoardArr[guess.X, guess.Y] = Discover.MISS;
                    return false;
                default:
                    throw new Exception();
            }

        }
    }
}
