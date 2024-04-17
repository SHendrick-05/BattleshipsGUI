using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

// Enums representing the visual and non-visual states of each square of the board
public enum Square
{
    WATER = 0,
    SHIP = 1,
    SUNK = 2,
    MISS = 3
}
public enum Discover
{
    NONE = 0,
    SHIP = 1,
    SUNK = 2,
    MISS = 3 
}

namespace BattleshipsGUI
{
    public partial class Form1 : Form
    {
        //Drag function
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Drag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // Takes in a X,Y click coord from cursor
        // Returns the row/column of the TableLayoutPanel it was clicked in
        // Used to find the coord of the guess
        Point? getPointFromClick(TableLayoutPanel board, Point clickPoint)
        {
            if (clickPoint.X > board.Width || clickPoint.Y > board.Height)
                return null;
            int width = board.Width;
            int height = board.Height;
            int[] widths = board.GetColumnWidths();
            int[] heights = board.GetRowHeights();
            int i;
            
            for (i = widths.Length-1; i >= 0 && clickPoint.X < width; i--)
            {
                width -= widths[i];
            }
            int col = i + 1;
            for (i = heights.Length-1; i >= 0 && clickPoint.Y < height; i--)
            {
                height -= heights[i];
            }
            int row = i + 1;

            return new Point(col, row);
        }

        void updateBox(string text)
        {
            gameState.AppendText(text);
            gameState.AppendText(Environment.NewLine);
        }

        public Form1()
        {
            GameHandler.gameStarted = false;
            GameHandler.genGame();
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void endGame(bool win)
        {
            replayButton.Visible = true;
            GameHandler.gameStarted = false;
            GameHandler.gameEnded = true;
            if (win)
            {
                winText.Visible = true;
                updateBox("Player wins.");
            }
            else
            {
                loseText.Visible = true;
                updateBox("CPU wins.");
            }
            Player cpu = GameHandler.players[1];
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (cpu.boardArr[i, j] == Square.WATER)
                    {
                        cpu.visualBoardArr[i, j] = Discover.MISS;
                    }
                    else if (cpu.boardArr[i,j] == Square.SHIP)
                    {
                        cpu.visualBoardArr[i, j] = Discover.SUNK;
                    }
                }
            }
            Refresh();
        }

        private void CPUBoard_Click(object sender, EventArgs e)
        {
            if (!GameHandler.gameStarted
                || !GameHandler.isPlayerTurn)
                return;

            Point? _point = getPointFromClick(CPUBoard, CPUBoard.PointToClient(Cursor.Position));
            if (_point == null)
                return;
            Player cpu = GameHandler.players[1];
            Point point = _point.Value;
            if (GameHandler.playerGuesses.Contains(point)) return;
            GameHandler.playerGuesses.Add(point);
            bool guess = GameHandler.Guess(true, point);
            char letter = "ABCDE"[point.X];
            updateBox($"Player guessed {letter}{point.Y + 1}");
            if (guess)
            {
                updateBox("Hit!");
                cpu.shipCount--;
                if (cpu.shipCount == 0)
                {
                    endGame(true);
                    return;
                }
            }
            else
            {
                updateBox("Miss.");
            }
            Refresh();
            GameHandler.isPlayerTurn = false;
            CPUGuess();
            GameHandler.isPlayerTurn = true;
            updateBox("-------------");
            updateBox("Player turn:");
        }

        private void CPUGuess()
        {
            updateBox("-------------");
            updateBox("CPU turn:");
            Thread.Sleep(1500);
            Random rnd = new Random();
            Point guess = new Point();
            do
            {
                guess.X = rnd.Next(0, 5);
                guess.Y = rnd.Next(0, 5);
            } while (GameHandler.CPUGuesses.Contains(guess));
            GameHandler.CPUGuesses.Add(guess);
            bool _guess = GameHandler.Guess(false, guess);
            char letter = "ABCDE"[guess.X];
            Player plr = GameHandler.players[0];
            updateBox($"CPU guessed {letter}{guess.Y + 1}");
            if(_guess)
            {
                updateBox("Hit!");
                plr.shipCount--;
                if (plr.shipCount == 0)
                    endGame(false);
            }
            else
            {
                updateBox("Miss.");
            }
            Refresh();
        }

        // Offer a replay, refresh board and start again
        private void replayButton_Click(object sender, EventArgs e)
        {
            winText.Visible = false;
            loseText.Visible = false;
            replayButton.Visible = false;
            GameHandler.gameEnded = false;
            GameHandler.genGame();
            gameState.Clear();
            Refresh();
        }

        private void playerBoard_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Player player = GameHandler.players[0];
            Rectangle rct = e.CellBounds;
            rct.X += 5;
            rct.Y += 5;
            rct.Width -= 10;
            rct.Height -= 10;
            Brush colour;
            switch(player.visualBoardArr[e.Column, e.Row])
            {
                case Discover.NONE:
                    colour = Brushes.White;
                    break;
                case Discover.SHIP:
                    colour = Brushes.Navy;
                    break;
                case Discover.SUNK:
                    colour = Brushes.Red;
                    break;
                default:
                    colour = Brushes.Black;
                    break;
            }
            e.Graphics.FillRectangle(colour, rct);
        }

        private void playerBoard_Click(object sender, EventArgs e)
        {
            Point? _clickPoint = getPointFromClick(playerBoard, playerBoard.PointToClient(Cursor.Position));
            if (_clickPoint == null
                || GameHandler.gameStarted
                || GameHandler.gameEnded)
                return;
            Point clickPoint = _clickPoint.Value;
            Player player = GameHandler.players[0];
            if (player.boardArr[clickPoint.X, clickPoint.Y] == Square.SHIP)
                return;

            player.boardArr[clickPoint.X, clickPoint.Y] = Square.SHIP;
            player.visualBoardArr[clickPoint.X, clickPoint.Y] = Discover.SHIP;
            
            player.shipCount++;
            updateBox("Ship placed");
            Refresh();
            if (player.shipCount == 2)
            {
                GameHandler.gameStarted = true;
                GameHandler.isPlayerTurn = true;
                updateBox("Game started!");
                updateBox("-------------");
                updateBox("Player turn:");
                return;
            }
        }

        private void CPUBoard_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Player player = GameHandler.players[1];
            Rectangle rct = e.CellBounds;
            rct.X += 5;
            rct.Y += 5;
            rct.Width -= 10;
            rct.Height -= 10;
            Brush colour;
            switch (player.visualBoardArr[e.Column, e.Row])
            {
                case Discover.SUNK:
                    colour = Brushes.Red;
                    break;
                case Discover.MISS:
                    colour = Brushes.Black;
                    break;
                default:
                    colour = Brushes.White;
                    break;
            }
            e.Graphics.FillRectangle(colour, rct);
        }

    }
}
