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
    /// Interaction logic for PlayerSelection.xaml
    /// </summary>
    public partial class PlayerSelection : Window
    {
        int cpuPlayerCount = 0;

        public PlayerSelection(double left, double top)
        {
            this.Left = left;
            this.Top = top;
            InitializeComponent();
            
        }

        private void ButtonFinished_Click(object sender, RoutedEventArgs e)
        {
            //Check if there's enough players
            if (ListPlayers.Items.Count < 2)
            {
                MessageBox.Show("Nedostatečný počet hráčů. Musí být alespoň dva nebo více.", "Chyba");
                return;
            }
            //Check if atleast one player is a human
            if (ListPlayers.Items.Count - cpuPlayerCount < 1)
            {
                MessageBox.Show("Alespoň jeden z hráčů musí být člověk.", "Chyba");
                return;
            }

            List<string> playerNames = new List<string>();
            foreach (var item in ListPlayers.Items)
            {
                playerNames.Add(item.ToString());
            }

            Settings settings = new Settings(this.Left, this.Top, playerNames);
            settings.Width = this.Width;
            settings.Height = this.Height;
            settings.WindowState = this.WindowState;
            settings.Show();
            this.Close();
        }

        private void ButtonAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            NameInputDialog nameDialog = new NameInputDialog();
            nameDialog.ShowDialog();

            if(nameDialog.DialogResult == true)
            {
                ListPlayers.Items.Add(nameDialog.TextNameInput.Text);
            }
            
        }

        private void ButtonAddComputer_Click(object sender, RoutedEventArgs e)
        {
            string cpuPlayerName = "CPU " + cpuPlayerCount;
            cpuPlayerCount++;
            ListPlayers.Items.Add(cpuPlayerName);
        }

        private void ButtonRemovePlayer_Click(object sender, RoutedEventArgs e)
        {
            if (ListPlayers.SelectedItem != null)
            {
                string selectedName = (string)ListPlayers.SelectedItem;
                if (selectedName.StartsWith("CPU"))
                    cpuPlayerCount--;
                ListPlayers.Items.Remove(ListPlayers.SelectedItem);
            }
        }
    }
}
