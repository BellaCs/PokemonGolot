using System;
using System.IO;
using System.Windows;
using System.Data;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Windows.Controls;
using System.ComponentModel;
using System.Drawing;


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
            // Post
            CreateAdmin objSecondWindow = new CreateAdmin();
            this.Visibility = Visibility.Hidden;
            objSecondWindow.Show();

        }

        private void ButtonEditAdmin_Click(object sender, RoutedEventArgs e)
        {
            // Put
            Button Clicked = (Button)sender;

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

        class TableAdmins
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public string Role { get; set; }
            public Button ButtonEdit { get; set; }

        }

        void DataGridForAdmins()
        {

            // Read json Document **** Canviar RUTA ***
            StreamReader r = new StreamReader("C:/Users/eloiv/Documents/Estudis/2DAM/Pokemon/WPFDesktop/AppDesktop/assets/exampleAdmins.json");
            string jsonString = r.ReadToEnd();
            JToken usersList = JToken.Parse(jsonString);

            List<TableAdmins> adminsList = new List<TableAdmins>();

            foreach (JObject admin in usersList)
            {
                TableAdmins actual = new TableAdmins();
                // Generate button
                Button b = new Button();
                b.Content = "Accedir";
                b.Click += ButtonEditAdmin_Click;
                b.Tag = (string)admin["user_name"];

                //b.Name = (string)admin["user_name"];
                actual.Name = (string)admin["name"];
                actual.Surname = (string)admin["surname"];
                actual.Email = (string)admin["email"];
                actual.ButtonEdit = b;

                adminsList.Add(actual);
            }
            DataGridAdmins.ItemsSource = adminsList;
        }

        private void DataGridAdmins_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataGridForAdmins();
        }
    }

}
