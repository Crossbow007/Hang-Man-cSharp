using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHangMan
{

    public partial class Form1 : Form
    {
        //Create the Player class.
        //LetterLoss will triger the updating of picture.
        Player player1;
        string[] words = { "corn", "mine", "craft", "log", "hang", "man" };
        string guessWord;
        string hiddenWord = "";
        public int letterLoss = 0;
        public int noWin;
        public int noLoss;


        public Form1()
        {
            InitializeComponent();
        }

        private void playerInfo_Click(object sender, EventArgs e)
        {
            //Constructor player and pass value to player.
            player1 = new Player(firstNameTxt.Text, lastNameTxt.Text, areaCode.Text);
            player1.firstName = firstNameTxt.Text;
            player1.lastName = lastNameTxt.Text;
            player1.postalCode = areaCode.Text;

            // Show player values at textboxs.
            getFirstTxt.Text = player1.firstName;
            getLastTxt.Text = player1.lastName;


            // Generate a random number from 0 to "words.Length-1".
            Random generateRandom = new Random();
            int randomNum = generateRandom.Next(0, words.Length);

            //Select a string array from word by random number index.
            //Pass value to guessWord, and load the initial picture.
            guessWord = words[randomNum];
            GenerateHidden(guessWord.Length);
            pictureBox1.Image = FinalHangMan.Properties.Resources.Load;
        }



        private void guess_Click(object sender, EventArgs e)
        {

            // Break up random word to char.
            char[] guessWords = guessWord.ToCharArray();
            int search = 0;

            for (; search < guessWord.Length; search++)
            {
                // Search and match each letter of words to guess letter.
                // Remove and insert the correct letter to hiddenword.
                if (guessWords[search] + "" == inputGuessTxt.Text)
                {
                    hiddenWord = hiddenWord.Remove(search, 1);
                    hiddenWord = hiddenWord.Insert(search, guessWords[search].ToString());
                    guessTxt.Text = hiddenWord;
                    break;
                }
            }

            // If this time no letter match to guess letter.
            // Give one more chance to user to try another letter.
            if (search == guessWord.Length)
            {
                MessageBox.Show("Sorry,wrong letter! you need another try.");
                letterLoss++;
                UpdateHangmanImage();
            }

            // If user try "length" times, still not find any correct letter, display "user lose".
            // And the "you lose" picture. let user try another word,and display how many words left to guess. 
            if (letterLoss == guessWord.Length)
            {
                noLoss++;
                UpdatePlayerScore();
                pictureBox1.Image = FinalHangMan.Properties.Resources.YouLose;
                MessageBox.Show("The answer word is "+guessWord+". You Lose! Click reset to try again! you have " + 
                    (words.Length - noLoss - noWin) + " words left!");
                resetGame();

            }
            inputGuessTxt.Clear();
            inputGuessTxt.Focus();

            // If guess word equal to random word.
            if (guessWord == guessTxt.Text)
            {
                noWin++;
                UpdatePlayerScore();
                pictureBox1.Image = FinalHangMan.Properties.Resources.youWin;
                MessageBox.Show("Congratulations! You won the game. you have " + 
                    (words.Length - noLoss - noWin) + " words left!");
                resetGame();
            }
        }

        // This is a function to generate a "-" words as length long.
        private void GenerateHidden(int length)
        {

            for (int index = 0; index < length; index++)
            {
                hiddenWord = hiddenWord.Insert(index, "-");
            }
            guessTxt.Text = hiddenWord;
        }
        // This is a function to update image by letterLoss incresement.
        private void UpdateHangmanImage()
        {
            switch (letterLoss)
            {
                case 1:
                    pictureBox1.Image = FinalHangMan.Properties.Resources.First;
                    break;
                case 2:
                    pictureBox1.Image = FinalHangMan.Properties.Resources.Second;
                    break;
                case 3:
                    pictureBox1.Image = FinalHangMan.Properties.Resources.Third;
                    break;
                case 4:
                    pictureBox1.Image = FinalHangMan.Properties.Resources.Forth;
                    break;
                case 5:
                    pictureBox1.Image = FinalHangMan.Properties.Resources.Five;
                    break;
            }

        }

        // This is a function to update and display the score of player.
        private void UpdatePlayerScore()
        {
            winTxt.Text = noWin.ToString();
            loseTxt.Text = noLoss.ToString();
        }

        
        private void reset_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        //This is a function to reset a new game that set all parameter to initial.
        //Except "first name","last name" and"area code".
        private void resetGame()
        {
            hiddenWord = "";
            guessWord = "";
            inputGuessTxt.Text = "";
            guessTxt.Text = "";
            letterLoss = 0;
            pictureBox1.Image = FinalHangMan.Properties.Resources.Load;
            Random generateRandom = new Random();
            int randomNum = generateRandom.Next(0, words.Length);
            guessWord = words[randomNum];
            GenerateHidden(guessWord.Length);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = FinalHangMan.Properties.Resources.Load;
        }
    }
}

