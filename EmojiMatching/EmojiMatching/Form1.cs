using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmojiMatching
{
   
    public partial class Form1 : Form

    {
        //the clicked labes
        Label firstLabel = null, secondlabel = null;

        /// <summary>
        /// Choose a random for each square
        /// </summary>
        private void AssignEmojiSquare()
        {
            //16 emoji in total 8 pair
            List<string> emojiList = new List<string>
        {
            "💩","😒","😎","🤢","🐶","👻","🦄","🐣",
            "💩","😒","😎","🤢","🐶","👻","🦄","🐣"
        };
            //choose a random emoji for each square
            Random random = new Random();

            foreach (Label square in tableLayoutPanel1.Controls)
            {
                //generate a random index
                int index = random.Next(emojiList.Count);

                //add the emoji to the label
                square.Text = emojiList[index];

                //remove emoji from the list
                emojiList.RemoveAt(index);

                //make the emoji invisible by matching the Fore and Back colours
                square.ForeColor = square.BackColor;
            }
        }

       void CheckForWinner()
        {
            //go through all emoji
            foreach(Label emoji in tableLayoutPanel1.Controls)
            {
                //If we find one that not clicked,then we didn'y win!
                //the For/Back colour  match
                if(emoji.ForeColor==emoji.BackColor)
                    return; // does nothing
            }
            //went through all emoji
            //none of them is unclicked
            //You win message!
            MessageBox.Show("YAAAAAAYYYY! YOU DID IT");

            //Paly again
            AssignEmojiSquare();
        }

            public Form1()
        {
            InitializeComponent();
            AssignEmojiSquare();
        }
        /// <summary>
        /// called when 2 emoji don't match
        /// hide the emoji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timesUp(object sender, EventArgs e)
        {
            //stop the timer
            peektimer.Stop();


            //hid ethe labels
            firstLabel.ForeColor=firstLabel.BackColor;
            secondlabel.ForeColor = secondlabel.BackColor;

            //reset the labels
            firstLabel = null;
            secondlabel = null;


        }
        /// <summary>
        /// called whenever any square is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ClickedAnylabel(object sender, EventArgs e)
        {
            //get the clicked label 
            Label clickedlabel = sender as Label;

            //avoid clicking the same emoji again
            if (clickedlabel.BackColor !=clickedlabel.ForeColor) return;


            //clicked the first emoji(no label clicked)
            if (firstLabel == null && secondlabel == null)
            {
                firstLabel = clickedlabel;
                clickedlabel.ForeColor = Color.Black;
            }
            //Second click!
            //we have the first label,but not the second
            else if (firstLabel != null && secondlabel == null)
            {
                secondlabel = clickedlabel;
                clickedlabel.ForeColor = Color.Black;
                //emoji match
                if (firstLabel.Text == secondlabel.Text)
                {

                    //Reset the clicked label
                    firstLabel = null;
                    secondlabel = null;
                    //DID WE WIN!
                    CheckForWinner();

                }
                //emoji don't match-hide the labels
                else

                    peektimer.Start();
                
                    

            }
            




        }
    }
}
