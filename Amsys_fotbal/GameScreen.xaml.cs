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

        public void UpdateNames()
        {
            LabelCurrent.Content = game.GetCurrentPlayerInfo();
            LabelNext.Content = game.GetNextPlayerInfo();
        }

        private void ButtonInput_Click(object sender, RoutedEventArgs e)
        {
            //TODO: DELETE, just a test
            game.MoveToNextPlayer();
            this.UpdateNames();
        }
    }
}
