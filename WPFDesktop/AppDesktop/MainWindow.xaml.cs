﻿using System.Windows;

namespace AppDesktop
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

        private void Login_OnClick(object sender, RoutedEventArgs e)
        {
            Pokemons pokemonmenu = new Pokemons();
            this.Visibility = Visibility.Hidden;
            pokemonmenu.Show();

        }
    }
}