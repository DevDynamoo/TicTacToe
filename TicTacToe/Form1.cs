using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void buttonClick(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                b.Text = "X";
                b.Enabled = false;

                ButtontoBoard(b);
                counter++;

                winner();

                AI();
            }
            catch { }
        }

        private void AI()
        {
            int move = maxTurn(game, 0).Item2;
            game[move] = "O";
            BoardtoButton(move);      
            counter++;
            winner();
        }
        private void winner()
        {
            if (checkgame(game, "X")) {
                disableGame();
                MessageBox.Show("X wins!");
            } else if (checkgame(game,"O")) {
                disableGame();
                MessageBox.Show("O wins!");
            } else if (counter == 9) {
                MessageBox.Show("Draw");
            }
        }
        private bool checkgame(string[] gameboard, string player) {

            if (
            //Horizontal
            ((gameboard[0] == gameboard[1]) && (gameboard[1] == gameboard[2]) && gameboard[2] == player) ||
            ((gameboard[3] == gameboard[4]) && (gameboard[4] == gameboard[5]) && gameboard[5] == player) ||
            ((gameboard[6] == gameboard[7]) && (gameboard[7] == gameboard[8]) && gameboard[8] == player) ||

            //Vertical
            ((gameboard[0] == gameboard[3]) && (gameboard[3] == gameboard[6]) && gameboard[6] == player) ||
            ((gameboard[1] == gameboard[4]) && (gameboard[4] == gameboard[7]) && gameboard[7] == player) ||
            ((gameboard[2] == gameboard[5]) && (gameboard[5] == gameboard[8]) && gameboard[8] == player) ||

            //Diagonal
            ((gameboard[0] == gameboard[4]) && (gameboard[4] == gameboard[8]) && gameboard[8] == player) ||
            ((gameboard[2] == gameboard[4]) && (gameboard[4] == gameboard[6]) && gameboard[6] == player))
            {
                return true;
            }
            else {
                return false;
            }
        }
        private void disableGame()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }

            }
        }


        //Reset button
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            counter = 0;
            game = new string[9];

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }

            }
        }


        private void mouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "X";
            }
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }


        private void ButtontoBoard(Button button)
        {
            string val = "X";
            switch (button.Name)
            {
                case "A1":
                    game[0] = val;
                    break;
                case "A2":
                    game[1] = val;
                    break;
                case "A3":
                    game[2] = val;
                    break;
                case "B1":
                    game[3] = val;
                    break;
                case "B2":
                    game[4] = val;
                    break;
                case "B3":
                    game[5] = val;
                    break;
                case "C1":
                    game[6] = val;
                    break;
                case "C2":
                    game[7] = val;
                    break;
                case "C3":
                    game[8] = val;
                    break;
                default:
                    break;
            }
        }

        private void BoardtoButton(int num)
        {
            switch (num)
            {
                case 0:
                    A1.Text = "O";
                    A1.Enabled = false;
                    break;
                case 1:
                    A2.Text = "O";
                    A2.Enabled = false;
                    break;
                case 2:
                    A3.Text = "O";
                    A3.Enabled = false;
                    break;
                case 3:
                    B1.Text = "O";
                    B1.Enabled = false;
                    break;
                case 4:
                    B2.Text = "O";
                    B2.Enabled = false;
                    break;
                case 5:
                    B3.Text = "O";
                    B3.Enabled = false;
                    break;
                case 6:
                    C1.Text = "O";
                    C1.Enabled = false;
                    break;
                case 7:
                    C2.Text = "O";
                    C2.Enabled = false;
                    break;
                case 8:
                    C3.Text = "O";
                    C3.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private int score(string[] gameboard, int depth)
        {
            if (checkgame(gameboard,"O")) {
                return  10-depth;                       // O wins
            }
            else if (checkgame(gameboard,"X")) {        // X wins
                return  depth-10; 
            }
            return 0;                                   // Draw

        }

        private (int,int) maxTurn(string[] gameboard, int depth)
        {
            if (counter==9 || checkgame(gameboard, "X") || checkgame(gameboard,"O"))
            {
                return (score(gameboard, depth), -1);
            }

            (int, int) max = (int.MinValue,int.MinValue);
            for (int i = 0; i < gameboard.Length; i++) { 
                if (gameboard[i]==null)
                {
                    gameboard[i] = "O";
                    (int, int) currentMove = minTurn(gameboard, depth+1);

                    if (currentMove.Item1 > max.Item1)
                    {
                        max = (currentMove.Item1, i);
                    } 

                    gameboard[i] = null;
                }

            }
            return max;
        }
        private (int, int) minTurn(string[] gameboard, int depth)
        {
            if (counter == 9 || checkgame(gameboard, "X") || checkgame(gameboard, "O"))
            {
                return (score(gameboard, depth), -1);
            }

            (int, int) min = (int.MaxValue,int.MaxValue);
            for (int i = 0; i < gameboard.Length; i++)
            {
                if (gameboard[i] == null)
                {
                    gameboard[i] = "X";
                    (int, int) currentMove = maxTurn(gameboard, depth+1);

                    if (currentMove.Item1 < min.Item1)
                    {
                        min = (currentMove.Item1, i);
                    }
                    
                    gameboard[i] = null;
                }

            }
            return min;
        }


    }
}
