using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Amsys_fotbal
{
    /// <summary>
    /// Interaction logic for GameScreen.xaml
    /// </summary>
    public partial class GameScreen : Window
    {
        Game game;
        public GameScreen(double width, double height, Game game)
        {
            this.Width = width;
            this.Height = height;
            this.game = game;
            

            InitializeComponent();

            UpdateNames();
        }

        /// <summary>
        /// Updates the current player and next player labels
        /// </summary>
        public void UpdateNames()
        {
            LabelCurrent.Content = game.GetCurrentPlayerInfo();
            LabelNext.Content = game.GetNextPlayerInfo();
        }

        /// <summary>
        /// Updates the help labels (last letter label and so on)
        /// by the provided word
        /// </summary>
        /// <param name="word"></param>
        private void UpdateHelpLabels(string word)
        {
            this.LabelPreviousWord.Content = word;
            this.LabelPreviousLetter.Content = word[word.Length - 1];
            this.LabelPreviousTwoLetter.Content = word[word.Length - 2].ToString() + word[word.Length - 1].ToString();
            this.LabelPreviousSyllable.Content = game.FindSyllable(word, false);
        }

        /// <summary>
        /// Checks players input, adds score, if next player is cpu it automaticaly makes it generate a word
        /// and moves to next player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInput_Click(object sender, RoutedEventArgs e)
        {

            if(game.CheckInput(TextInput.Text.ToLower()))
            {                
                //Adds score depending on the lenght of the word
                game.AddCurrentPlayersPoints(TextInput.Text);

                game.MoveToNextPlayer(); //Iterates players
                this.UpdateNames();
                this.UpdateHelpLabels(TextInput.Text);

                //If the next player is computer
                if (game.GetCurrentPlayerInfo().StartsWith("CPU"))
                {
                    ComputerPlayer cpuPlayer = (ComputerPlayer)game.GetCurrentPlayer();
                    string cpuWord = cpuPlayer.GuessWord(this.LabelPreviousLetter.Content.ToString()[0]);

                    //If the word guessed by cpu is an empty string
                    //It means it couldn't find a correct word and it gave up
                    if (cpuWord == "")
                    {
                        game.MoveToNextPlayer();
                        this.UpdateNames();
                    }
                    else //The guessed word is guaranteed to be correct
                    {
                        game.PreviousWord = cpuWord;
                        game.AddCurrentPlayersPoints(cpuWord.Length - 1);
                        game.MoveToNextPlayer();
                        this.UpdateNames();
                        this.UpdateHelpLabels(cpuWord);
                    }
                }
            }
          
            
        }

        private void SwitchToGameOverScreen()
        {
            GameOverScreen gos = new GameOverScreen(game.GetPlayerNames(), game.GetBestPlayerName());
            gos.Left = this.Left;
            gos.Top = this.Top;
            gos.Width = this.Width;
            gos.Height = this.Height;
            gos.WindowState = this.WindowState;

            gos.Show();
            this.Close();

        }

        private void ButtonGiveUp_Click(object sender, RoutedEventArgs e)
        {
            //Game can end up in gameOver state if there's no human player still playing
            game.MakeCurrentPlayerGiveUp();
            if(game.GameOver)
            {
                SwitchToGameOverScreen();
            }
            else
            {
                game.MoveToNextPlayer();
                this.UpdateNames();
            }
        }

        /// <summary>
        /// Puts first 3 letter of a word a player could use in the input textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonHelp_Click(object sender, RoutedEventArgs e)
        {
            //It won't generate any help if there wasn't any previous player input
            if (this.LabelPreviousWord.Content.ToString() != "--zatím žádné--")
            {
                foreach (string word in game.WordSet)
                {
                    if (word[0] == (LabelPreviousLetter.Content.ToString())[0])
                    {
                        if (!game.UsedWordSet.Contains(word))
                        {
                            this.TextInput.Text = word.Substring(0, 3);
                            game.SubtractCurrentPlayerPoints(5);
                            break;
                        }
                    }
                }
            }
        }
    }
}
