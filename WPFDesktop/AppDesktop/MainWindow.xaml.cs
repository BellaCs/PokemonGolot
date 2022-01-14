using System.Windows;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

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

        class TableAdmins
        {
            public string nom { get; set; }
            public string email { get; set; }
            public string contrasenya { get; set; }

        }
        void DataGridForAdmins()
        {

            // Read json Document **** Canviar RUTA ***
            StreamReader r = new StreamReader("C:");
            string jsonString = r.ReadToEnd();

            JToken usersList = JToken.Parse(jsonString);

            List<TableAdmins> adminsList = new List<TableAdmins>();

            foreach (JObject admin in usersList)
            {
                TableAdmins actual = new TableAdmins();

           
                actual.nom = (string)admin["user_name"];
                actual.email = (string)admin["email"];
                actual.contrasenya = (string)admin["password"];
          
       

                adminsList.Add(actual);
            }

        }

        private void Login_OnClick(object sender, RoutedEventArgs e)
        {
            Pokemons pokemonmenu = new Pokemons();
            this.Visibility = Visibility.Hidden;
            pokemonmenu.Show();

        }




    }
}
