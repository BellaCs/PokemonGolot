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


namespace AppDesktop
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainMenu : Window
    {

        //AdminPage adminpage = new AdminPage();
        //PlayerPage playerpage = new PlayerPage();
        //PokemomPage pokemonpage = new PokemonPage();



        public MainMenu()
        {
            InitializeComponent();


        }

        private void ButtonPlayers_Click(object sender, RoutedEventArgs e)
        {
            //FrameContent.NavigationService.Navigate(pagePlayers);
           
        }

        private void ButtonPokemons_Click(object sender, RoutedEventArgs e)
        {
            //FrameContent.NavigationService.Navigate(pagePokemons);
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
