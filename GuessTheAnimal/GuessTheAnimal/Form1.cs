using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheAnimal
{
    public partial class Form1 : Form
    {
        //variables visible in class
        Button[] options;
        Random random = new Random();
        string animal;// here so we can use across class
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            //store the buttons in an arry

            options = new Button[] { button1, button2, button3, button4};
            //Start the game!
            ShowNextAnimal();
        }
        /// <summary>
        /// get random animal name from dictinory keys
        /// </summary>
        /// <returns></returns>
        string  GetRandomAnimal()
        {
            //get all key
           string[] allAnimals = Zoo.animal.Keys.ToArray();
            //get random animal
            int randomIndex= random.Next(allAnimals.Length);
            return allAnimals[randomIndex];
        }
        /// <summary>
        /// shows a random animal emoji
        /// 3 random incorrect 
        /// </summary>
        void ShowNextAnimal()

        {
            //make sure the timer is running
            timer1.Start();
            //reset the progress
            progressBar1.Value = 0;
            
            // the right option
            animal = GetRandomAnimal();
            AnimalLabel.Text= Zoo.animal[animal];//get the emoji
            //generate 4 option until no duplicate are found
            do {
                //populate the remaning buttons with random animals
                foreach (Button button in options)
                {
                    button.Text = GetRandomAnimal();
                }

                //put the right option in a random button
                options[random.Next(4)].Text = animal;
                //if a dupe is found,then repeat
            } while(CheckForDuplicate());
        }
        /// <summary>
        /// check if we have 2 buttons with the same text
        /// </summary>
        /// <returns> true if duplicate is found, otherwise false</returns>
        bool CheckForDuplicate()
        {
            //check if the button text matches another button text
            foreach(Button button in options)
            {
                foreach(Button optionButton in options)
                {
                    //Duplicate found
                   if( button != optionButton // not the same button
                        && button.Text == optionButton.Text)
                        return true;


                }
            }
            //no duplicates
            return false;

        }


        /// <summary>
        /// Exctute every half a second
        /// increment progress until game is over
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();

            //time's up
            if(progressBar1.Value == 100)
            GameOver();
        }
        /// <summary>
        /// game over screen
        /// score
        /// play again
        /// </summary>
        void GameOver()
        {
            timer1.Stop();
            //ask if user want to play again
            DialogResult yesNo= MessageBox.Show($"You guessed {score} correct animals! \n"+
                $"Play again?", "Game over",
                MessageBoxButtons.YesNo);

            //reset the score
            score = 0;

            //choose to quite
            if(yesNo == DialogResult.No) Close();

            //chosse to play again
            else ShowNextAnimal();
        }
        /// <summary>
        /// when an option is clicked
        /// check if it's the right option animal
        /// otherwise game over
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnyButtonCiliked(object sender, EventArgs e)
        {
            //this is the clicked button
            Button option =  (Button) sender;
            //choose the right option
            if(option.Text == animal)
            {
                ShowNextAnimal();
                score++;

            }
            //wrong option
            else GameOver();
        }
    }
}
