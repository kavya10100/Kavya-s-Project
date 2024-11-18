using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrongPasswordGenerator
{
    public partial class Form1 : Form
    {
        const string LowerCase = "abcdefghijklmnopqrstuvwxyz";
        const string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string Digits = "0123456789";
        const string SpecialChars = "~@@#$%^&*()_+|\\}:;<>?/";

        // controls if each criteria match
        bool isLower, isUpper, isDigit, isSpecial, istenChar;

        public Form1()
        {
            InitializeComponent();
            progressBar1.DisableStyle();
        }

        void GeneratePassword()
        {
            string password = "";
            Random ramdom = new Random();
            string[] criteria = { LowerCase, UpperCase, Digits, SpecialChars };
            bool isStrong;

            do
            {
                // Generate 10 characters
                for (int count = 0; count <= 10; count++)
                {
                    // Pick a random length
                    string criterion = criteria[ramdom.Next(criteria.Length)];
                    // Pick a random letter from that criterion
                    char letter = criterion[ramdom.Next(criterion.Length)];
                    password += letter;
                }
                CheckPasswordStrength(password);
                isStrong = isLower && isUpper && isDigit && isSpecial && istenChar;
            } while(!isStrong);



            PasswordtextBox.Text = password;
        }

        /// <summary>
        /// Clicked the generate button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Generatebutton_Click(object sender, EventArgs e)
        {
            GeneratePassword();
        }

        /// <summary>
        /// Reveal/conceal password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReveaPassword(object sender, EventArgs e)
        {
            // Reveal password when checked
            if (RevealCheckBox.Checked)
            {
                PasswordtextBox.UseSystemPasswordChar = false;
                RevealCheckBox.BackgroundImage = Properties.Resources.Reveal;
            }
            // Conceal password when unchecked
            else
            {
                PasswordtextBox.UseSystemPasswordChar = true;
                RevealCheckBox.BackgroundImage = Properties.Resources.Conceal;
            }
        }

        /// <summary>
        /// Checks the password strength and updates the progress bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordStrength(PasswordtextBox.Text);
            UpdateProgressColour();
        }

        private void UpdateProgressColour()
        {
            // Using ternary operator to change the background color
            LowerCaselabel.BackColor = isLower ? Color.Green : Color.White;
            UpperCaselabel.BackColor = isUpper ? Color.Green : Color.White;
            Digitlabel.BackColor = isDigit ? Color.Green : Color.White;
            SpecialCharlabel.BackColor = isSpecial ? Color.Green : Color.White;
            Lengthlabel.BackColor = istenChar ? Color.Green : Color.White;

            // Update the progress bar
            progressBar1.Value = 0;
            progressBar1.Value += isLower ? 20 : 0;
            progressBar1.Value += isUpper ? 20 : 0;
            progressBar1.Value += isDigit ? 20 : 0;
            progressBar1.Value += isSpecial ? 20 : 0;
            progressBar1.Value += istenChar ? 20 : 0;

            // Progress colors
            if (progressBar1.Value == 20)
                progressBar1.ForeColor = Color.Red;
            else if (progressBar1.Value == 40)
                progressBar1.ForeColor = Color.Tomato;
            else if (progressBar1.Value == 60)
                progressBar1.ForeColor = Color.Orange;
            else if (progressBar1.Value == 80)
                progressBar1.ForeColor = Color.Yellow;
            else if (progressBar1.Value == 100)
                progressBar1.ForeColor = Color.Green;
        }

        // Check if the password meets all criteria
        private void CheckPasswordStrength(string password)
        {
            // Reset all criteria
            isLower = false;
            isUpper = false;
            isDigit = false;
            isSpecial = false;
            istenChar = false;

            foreach (char letter in password)
            {
                // Check if it's lowercase
                if (LowerCase.Contains(letter))
                    isLower = true;
                else if (UpperCase.Contains(letter))
                    isUpper = true;
                else if (Digits.Contains(letter))
                    isDigit = true;
                else if (SpecialChars.Contains(letter))
                    isSpecial = true;

                // Check for length outside loop as it's constant
                if (password.Length >= 10)
                {
                    istenChar = true;
                    Lengthlabel.BackColor = Color.White;
                }
            }
        }
    }
}
