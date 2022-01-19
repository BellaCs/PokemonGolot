using System.Windows;

namespace AppDesktop
{
    /// <summary>
    /// Lógica de interacción para Players.xaml
    /// </summary>
    public partial class Players : Window
    {
        public Players()
        {
            InitializeComponent();
        }

        private void ButtonPokemons_Click(object sender, RoutedEventArgs e)
        {
            Pokemons objSecondWindow = new Pokemons();
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
