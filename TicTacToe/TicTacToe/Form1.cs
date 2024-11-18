using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool isXTurn = true;
        private int xScore = 0;
        private int oScore = 0;
        private string xName;
        private string oName;
        private Button[] buttons;
        private int moveCount = 0;
        private Color xColor = Color.Orchid; // Default color for X
        private Color oColor = Color.CornflowerBlue; // Default color for O



        public Form1()
        {
            InitializeComponent();


            buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            
            // Initially disable all game buttons until player names are entered
            DisableGameBoard();


        }

        private void ResetBoard()
        {

            // Reset the move counter
            moveCount = 0;

            // Clear the text of all buttons but don't reset the scores
            foreach (Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true; // Enable the buttons again
                button.BackColor = Color.White; // Reset background color to white
            }

            // Reset the winnertextBox to null
            winnertextBox.Text = "";
            winnertextBox.BackColor = Color.White;

            // Reset the WhatPlayertextBox to the starting player's turn
            isXTurn = true;
            WhatPlayerlabel.Text = $"{xName}'s turn";
            

        }
        private void DisableGameBoard()
        {
            // Disable all buttons to prevent playing before both names are entered
            foreach (Button button in buttons)
            {
                button.Enabled = false;
            }
        }

        private void EnableGameBoard()
        {
            // Enable all buttons once both names are entered
            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (isXTurn)
            {
                button.BackColor = xColor; // Use the selected color for Player 1 
                button.Text = "X";
                WhatPlayerlabel.Text = $"{oName}'s turn";
                isXTurn = false;
            }
            else
            {

                button.BackColor = oColor; // Use the selected color for Player 2 
                button.Text = "O";
                WhatPlayerlabel.Text = $"{xName}'s turn";
                isXTurn = true;
            }
            
            button.Enabled = false; // does not allow changing the button text 
            moveCount++;

            if (moveCount >= 5)
            {
                CheckForWinner();
                // If no winner is found and moves are still available, continue play
                if (winnertextBox.Text == "")
                {
                    // No winner yet, game continues
                    WhatPlayerlabel.Text = isXTurn ? $"{xName}'s turn" : $"{oName}'s turn";
                }
            }

        }


        private void CheckForWinner()
        {
            string winner = null;

            // Check rows
            if (buttons[0].Text != "" && buttons[0].Text == buttons[1].Text && buttons[0].Text == buttons[2].Text)
                winner = buttons[0].Text;
                
            if (buttons[3].Text != "" && buttons[3].Text == buttons[4].Text && buttons[3].Text == buttons[5].Text)
                winner = buttons[3].Text;
            if (buttons[6].Text != "" && buttons[6].Text == buttons[7].Text && buttons[6].Text == buttons[8].Text)
                winner = buttons[6].Text;

            // Check columns
            if (buttons[0].Text != "" && buttons[0].Text == buttons[3].Text && buttons[0].Text == buttons[6].Text)
                winner = buttons[0].Text;
            if (buttons[1].Text != "" && buttons[1].Text == buttons[4].Text && buttons[1].Text == buttons[7].Text)
                winner = buttons[1].Text;
            if (buttons[2].Text != "" && buttons[2].Text == buttons[5].Text && buttons[2].Text == buttons[8].Text)
                winner = buttons[2].Text;

            // Check diagonals
            if (buttons[0].Text != "" && buttons[0].Text == buttons[4].Text && buttons[0].Text == buttons[8].Text)
                winner = buttons[0].Text;
            if (buttons[2].Text != "" && buttons[2].Text == buttons[4].Text && buttons[2].Text == buttons[6].Text)
                winner = buttons[2].Text;

            // If there's a winner, update the score and display the winner
            if (winner != null)
            {
                if (winner == "X")
                {
                    xScore++;
                    Score1textBox.Text = xScore.ToString();
                    winnertextBox.Text = "X";                
                    winnertextBox.BackColor = xColor;
                    WhatPlayerlabel.Text = $"{xName} wins! Click here to reset.";

                }
                else
                {
                    oScore++;
                    Score2textBox.Text = oScore.ToString();
                    winnertextBox.Text = "O";
                    winnertextBox.BackColor = oColor;
                    WhatPlayerlabel.Text = $"{oName} wins! Click here to reset.";

                }

                // Disable all buttons to make the game board read-only
                DisableGameBoard();
            }
            else if (moveCount == 9) // Check for a draw when all moves are made
            {
                winnertextBox.Text = " ";
                winnertextBox.BackColor = Color.White;
                WhatPlayerlabel.Text = "It's a draw! Click here to reset.";
                DisableGameBoard();

            }

        }


        // Check if both names are entered and enable the game board

        private void EnableGameIfNamesEntered()
        {
            // Check for single-space input in either player's name
            if (Player1textBox.Text == " ")
            {
                MessageBox.Show("Player 1 name cannot be empty or blank space.");
                DisableGameBoard();
            }
            else if (Palyer2textBox.Text == " ")
            {
                MessageBox.Show("Player 2 name cannot be empty or blank space.");
                DisableGameBoard();
            }
            // Enable game board if both names are valid (not null, empty, or single space)
            else if (!string.IsNullOrEmpty(Player1textBox.Text) && !string.IsNullOrEmpty(Palyer2textBox.Text))
            {
                xName = Player1textBox.Text;
                oName = Palyer2textBox.Text;
                EnableGameBoard();
                Player1textBox.ReadOnly = true;
                Palyer2textBox.ReadOnly = true;

                WhatPlayerlabel.Text = $"{xName}'s turn";
            }
            else
            {
                // If any other invalid name case (like empty), keep the board disabled
                DisableGameBoard();
            }

        }
        private void playbutton(object sender, EventArgs e)
        {


        }
        private void Resetbutton_Click(object sender, EventArgs e)
        {
            ResetBoard();
            WhatPlayerlabel.Text = $"{xName}'s turn"; // Reset to show X's turn

            EnableGameIfNamesEntered(); // Re-enable game buttons

        }
        private void Player1textBox_TextChanged(object sender, EventArgs e)
        {
            xName = Player1textBox.Text;
            EnableGameIfNamesEntered();
        }
        private void Palyer2textBox_TextChanged(object sender, EventArgs e)
        {
            oName = Palyer2textBox.Text;
            EnableGameIfNamesEntered();
        }

        private void winnertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Palyer1colourtextBox_TextChanged(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    xColor = colorDialog.Color; // Set the selected color for Player 1
                    Palyer1colourtextBox.BackColor = xColor; // Set the background color of the text box
                    
                }
            }
        }

        private void Palyer2colourtextBox_TextChanged(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    oColor = colorDialog.Color; // Set the selected color for Player 2
                    Palyer2colourtextBox.BackColor = oColor; // Set the background color of the text box
                    
                }
            }
        }

        private void Score2textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
