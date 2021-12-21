﻿using System.Windows;



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

            frame.Content = new Page1();

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
