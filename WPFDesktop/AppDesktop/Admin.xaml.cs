using System.Windows;

namespace AppDesktop
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void ButtonPlayers_Click(object sender, RoutedEventArgs e)
        {
            Players objSecondWindow = new Players();
            this.Visibility = Visibility.Hidden;
            objSecondWindow.Show();
        }

        private void ButtonPokemons_Click(object sender, RoutedEventArgs e)
        {
            Pokemons objSecondWindow = new Pokemons();
            this.Visibility = Visibility.Hidden;
            objSecondWindow.Show();
        }
        private void ButtonCreateAdmin_Click(object sender, RoutedEventArgs e)
        {
            CreateAdmin objSecondWindow = new CreateAdmin();
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
