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
        string dictionaryPath = "defaultDictionary";
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
            dictionaryPath = "defaultDictionary";
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
                //Everything is set. Time to create a game instance and pass it to the game window
                Game game = new Game(playerNames,
                                     (bool)CheckBoxLetter.IsChecked,
                                     (bool)CheckBoxTwoLetter.IsChecked,
                                     (bool)CheckBoxSyllable.IsChecked,
                                     (bool)RadioYes.IsChecked);

                GameScreen gameScreen = new GameScreen(this.Width, this.Height, game);
                gameScreen.Width = this.Width;
                gameScreen.Height = this.Height;
                gameScreen.Show();
                this.Close();
            }
            //TODO open player screen
        }
    }
}
