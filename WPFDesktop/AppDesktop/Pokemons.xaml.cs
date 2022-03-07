using System.IO;
using System.Windows;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Windows.Controls;

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
            Admin adminmenu = new Admin();
            this.Visibility = Visibility.Hidden;
            adminmenu.Show();
        }

        private void ButtonAddPokemon_Click(object sender, RoutedEventArgs e)
        {
            AddPokemons addpokemons = new AddPokemons();
            this.Visibility = Visibility.Hidden;
            addpokemons.Show();

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

        private void ButtonEditPokemon_Click(object sender, RoutedEventArgs e)
        {
            // Put
            Button Clicked = (Button)sender;

            AddPokemons addpokemons = new AddPokemons();
            this.Visibility = Visibility.Hidden;
            addpokemons.Show();
        }

        class TablePokemons
        {
            public int Num_pokedex { get; set; }
            public string Name { get; set; }
            public int Attack { get; set; }
            public int Stamina { get; set; }
            public int Defense { get; set; }
            public bool IsActive { get; set; }
            public string Active { get; set; }


            public Button ButtonEdit { get; set; }

        }
        void DataGridForPokemons()
        {

            // Read json Document **** Canviar RUTA ***
            StreamReader r = new StreamReader("C:/Users/34662/Desktop/PokemonGolot/WPFDesktop/AppDesktop/assets/examplePokemons.json");
            string jsonString = r.ReadToEnd();
            JToken pokemonsData = JToken.Parse(jsonString);

            List<TablePokemons> pokemonList = new List<TablePokemons>();

            foreach (JObject pokemon in pokemonsData)
            {
                TablePokemons actual = new TablePokemons();
                // Generate button
                Button b = new Button();
                b.Content = "Accedir";
                b.Click += ButtonEditPokemon_Click;
                b.Tag = (string)pokemon["num_pokedex"];

                actual.Num_pokedex = (int)pokemon["num_pokedex"];

                actual.Name = (string)pokemon["name"];
                if ((bool)pokemon["isActive"])
                {
                    actual.Active = (string)"Si";
                } else {
                    actual.Active = (string)"No";
                }

                string test = actual.Active;
                actual.Attack = (int)pokemon["attack"];
                actual.Stamina = (int)pokemon["stamina"];
                actual.Defense = (int)pokemon["defense"];

                actual.ButtonEdit = b;
                pokemonList.Add(actual);
            }
            DataGridPokemons.ItemsSource = pokemonList;
        }

        private void DataGridPokemons_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataGridForPokemons();

        }
    }
}
