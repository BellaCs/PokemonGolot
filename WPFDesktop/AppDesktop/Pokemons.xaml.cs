using System.IO;
using System.Windows;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Windows.Controls;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;

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
        async Task DataGridForPokemonsAsync()
        {

            try
            {
                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

                string sURL;
                //sURL = "https://172.24.1.178:7292/api/pokemon"; //172.24.2.67
                sURL = "https://172.24.2.67:7292/api/pokemon"; //172.24.2.67


                using (var httpClient = new HttpClient(clientHandler))
                {


                    /*string token = App.Current.Properties["token"].ToString();
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    HttpResponseMessage response = await httpClient.GetAsync(sURL);
                    string pokemonsData = await response.Content.ReadAsStringAsync();*/

                    StreamReader r = new StreamReader("C:/Users/Marc/Desktop/Portfolio/PokemonGolot/WPFDesktop/AppDesktop/assets/examplePokemons.json");
                    string pokemonsData = r.ReadToEnd();

                    JToken pokemonsDataToken = JToken.Parse(pokemonsData);

                    List<TablePokemons> pokemonList = new List<TablePokemons>();

                    foreach (JObject pokemon in pokemonsDataToken)
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
                        }
                        else
                        {
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
            }
            catch { 
            
            }
    }


        private async Task DataGridPokemons_LoadedAsync()
        {
            await DataGridForPokemonsAsync();

        }

        private  void DataGridPokemons_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridPokemons_LoadedAsync().Wait();

        }
    }
}
