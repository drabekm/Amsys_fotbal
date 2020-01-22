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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Amsys_fotbal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonQuit_Click(object sender, RoutedEventArgs e)
        {
            //Close the program
            System.Windows.Application.Current.Shutdown();
        }

        private void ButtonNewGame_Click(object sender, RoutedEventArgs e)
        {
            //Open settings for the new game
            //Settings settings = new Settings(this.Left, this.Top);

            PlayerSelection playerSelection = new PlayerSelection(this.Left, this.Top);

            playerSelection.Width = this.Width;
            playerSelection.Height = this.Height;
            playerSelection.Show();
            this.Close();
            
        }
    }
}
