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
using System.Windows.Controls.Primitives;



namespace AppDesktop
{
    /// <summary>
    /// Lógica de interacción para Pokemons.xaml
    /// </summary>
    public partial class Pokemons : Window
    {
        public Pokemons()
        {
            InitializeComponent();
        }

        private void ButtonPlayers_Click(object sender, RoutedEventArgs e)
        {
            Players objSecondWindow = new Players();
            this.Visibility = Visibility.Hidden;
            objSecondWindow.Show();
        }

        private void ButtonAdmin_Click(object sender, RoutedEventArgs e)
        {
            Admin objSecondWindow = new Admin();
            this.Visibility = Visibility.Hidden;
            objSecondWindow.Show();
        }

        private void ButtonCloseSession_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("Vols tancar la sessió?", "Tancar sessió", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MainWindow objSecondWindow = new MainWindow();
                    this.Visibility = Visibility.Hidden;
                    objSecondWindow.Show();
                    break;
            }
        }


    }
}
