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
using System.IO;

namespace Amsys_fotbal
{
    /// <summary>
    /// Interaction logic for GameOverScreen.xaml
    /// </summary>
    public partial class GameOverScreen : Window
    {
        public GameOverScreen(string[] playerNames, string bestPlayer)
        {
            InitializeComponent();

            LabelBestPlayer.Content = bestPlayer;
            //Check if this games top player was better than the current top player
            try
            {
                int storedScore = 0;
                string playerName = bestPlayer.Split(':')[0];
                int playerScore = int.Parse(bestPlayer.Split(':')[1]);

                using (StreamReader sr = new StreamReader("bestPlayer.kopana"))
                {
                    string line = sr.ReadLine(); //First line is last top players name
                    line = sr.ReadLine(); //The other one is previous top players score
                    storedScore = int.Parse(line);
                }
                if (storedScore < playerScore)
                {
                    //If current score is bigger -> overrite the file with new information
                    using (StreamWriter sw = new StreamWriter("bestPlayer.kopana"))
                    {
                        sw.WriteLine(playerName);
                        sw.WriteLine(playerScore);
                    }
                }
            }
            catch
            {
                //Fail silently, like a ninja
            }

            foreach (string name in playerNames)
            {
                ListPlayers.Items.Add(name);
            }

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonBackToMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Left = this.Left;
            mainWindow.Top = this.Top;
            mainWindow.Width = this.Width;
            mainWindow.Height = this.Height;
            mainWindow.WindowState = this.WindowState;

            mainWindow.Show();
            this.Close();
        }
    }
}
