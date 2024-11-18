using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugSquishingGame
{
    public partial class Form1 : Form
    {
        // constant
        const int startTime = 15;
        //random number generator
        Random random = new Random();
        //how bugs were squised
        int score = 0;
        int timeleft = startTime;
        //arry of bug image
        Bitmap[] bugImages =
        {
                Properties.Resources.bug1,
                Properties.Resources.bug2,
                Properties.Resources.bug3,
                Properties.Resources.bug4,

        };

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// excuted when the mouse is pressed down
        /// ///kills the bug and increase the score
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void SquishBug(object sender, MouseEventArgs e)
        {
            //unsubscribe to the mouse down event
            bug.MouseDown -= SquishBug;
            //show blood
            bug.Image=Properties.Resources.blood;
            //increase score
            score++;
            scoreLable.Text = $"Squished {score} bugs";

          
        }

        /// <summary>
        /// called automaticaaly by the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spawnbug(object sender, EventArgs e)
        {
            //unsubscribe just in case it is not done
            bug.MouseDown -=SquishBug;
            //subscribe to the mouse event
            bug.MouseDown +=SquishBug;
            //reset image to a random bug
            bug.Image = bugImages[random.Next(bugImages.Length)];
            //move bug to random location
            int randomX = random.Next(0, ClientSize.Width -bug.Width);
            int randomY = random.Next(100, ClientSize.Height -bug.Height);
             bug.Location = new Point(randomX, randomY);
        }
        /// <summary>
        /// called once per second
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gametime(object sender, EventArgs e)
        {
            timeleft--;
            timelabel.Text = "Time left: " + timeleft;
            //time's up!
            if (timeleft == 0) Gameover();

        }
        /// <summary>
        /// stop the timer
        /// stop spawing bug
        /// restart button
        /// 
        /// </summary>
        void Gameover()

        {
            //stop timer
            gametimer.Stop();
            Spawntimer.Stop();
            //hide the bug
            bug.Visible = false;
            //restart button
             restartbutton.Visible = true;

        }
        /// <summary>
        /// reset time and score
        /// show the bug
        /// hide the restart button
        /// </summary>
        void restartGame(object sender, EventArgs e)
        {
            //restart the time and score and update the lables
            //restart timer
            timeleft = startTime;
            score= 0;
            timelabel.Text= "Time left:" +timeleft;
            scoreLable.Text= $"Sqished {score} bugs";
            //restart timer
            gametimer.Start();
            Spawntimer.Start();
            //hide the bug
            bug.Visible = true;
            //restart button
            restartbutton.Visible = false;
        }

        private void scoreLable_Click(object sender, EventArgs e)
        {

        }

        private void scoreLable_Click_1(object sender, EventArgs e)
        {

        }
    }
}
