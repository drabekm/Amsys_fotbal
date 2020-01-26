using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace Amsys_fotbal
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        string dictionaryPath = "defaultDictionary.txt";
        List<string> playerNames;

        public Settings(double left, double top, List<string> playerNames)
        {
            this.Left = left;
            this.Top = top;
            this.playerNames = playerNames;
            InitializeComponent();            
        }

        private void ButtonDefault_Click(object sender, RoutedEventArgs e)
        {
            dictionaryPath = "defaultDictionary.txt";
        }


        private void ButtonCustom_Click(object sender, RoutedEventArgs e)
        {
            LoadCustomDictionaryPath();
        }

        /// <summary>
        /// Loads a path to a specific dictionary selected by a user
        /// </summary>
        private void LoadCustomDictionaryPath()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "txt files (*.txt)|*.txt";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dictionaryPath = ofd.FileName;
            }
        }

        private void ButtonFinished_Click(object sender, RoutedEventArgs e)
        {
            //Check if settings are set correctly
            if((bool)CheckBoxLetter.IsChecked || (bool)CheckBoxTwoLetter.IsChecked || (bool)CheckBoxSyllable.IsChecked)
            {
                SortedSet<string> wordSet;
                wordSet = MakeWordSetFromFile(dictionaryPath);

                if (wordSet != null) //If wordSet creation was succesful
                {
                    //Everything is set. Time to create a game instance and pass it to the game window
                    Game game = new Game(playerNames,
                                         (bool)CheckBoxLetter.IsChecked,
                                         (bool)CheckBoxTwoLetter.IsChecked,
                                         (bool)CheckBoxSyllable.IsChecked,
                                         (bool)RadioYes.IsChecked,
                                         wordSet);

                    GameScreen gameScreen = new GameScreen(this.Width, this.Height, game);
                    gameScreen.Left = this.Left;
                    gameScreen.Top = this.Top;
                    gameScreen.WindowState = this.WindowState;
                    gameScreen.Show();
                    this.Close();
                }
            }
            //TODO open player screen
        }

        /// <summary>
        /// Transforms a .txt file with words separated by spaces or commas into a red-black tree.
        /// Default game dictionary is > 20 000 words long and something optimized is needed.
        /// </summary>
        /// <param name="dictionaryPath">Path to a .txt file with words</param>
        /// <returns>Wordset if succesful, null if error ocurs</returns>
        public SortedSet<string> MakeWordSetFromFile(string dictionaryPath)
        {
            SortedSet<string> wordSet = new SortedSet<string>();
            try
            {
                using (StreamReader sr = new StreamReader(dictionaryPath))
                {
                    string line;
                    while( (line = sr.ReadLine()) != null )
                    {
                        //Who knows what kind of word separator is used in the word file.   
                        // Let's remove the most common ones
                        line.Replace(',', ' ').Replace(';', ' ').Replace('.', ' ');

                        string[] words = line.Split(' ');
                        foreach (string word in words)
                        {
                            wordSet.Add(word.ToLower());
                        }
                    }
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Chyba načítání slovníku!", "Chyba");
                return null;
            }


            return wordSet;
        }
    }


}
