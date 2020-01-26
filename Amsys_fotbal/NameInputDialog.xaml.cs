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
    /// Interaction logic for NameInputDialog.xaml
    /// It's used retreive game nickname from a user
    /// </summary>
    public partial class NameInputDialog : Window
    {
        //Used to get players name 
        public NameInputDialog()
        {
            InitializeComponent();
            
        }

        public string SelectedName
        {
            get { return TextNameInput.Text; }
            set { TextNameInput.Text = value; }
        }

        private void ButtonDone_Click(object sender, RoutedEventArgs e)
        {
            //The "CPU" name is reserved for ai players
            if (TextNameInput.Text.StartsWith("CPU"))
            {
                MessageBox.Show("Vaše přezdívka nemůže začínat slovy \"CPU\" ", "Chyba přezdívky");
            }
            else
            {
                DialogResult = true;
            }
        }
    }
}
