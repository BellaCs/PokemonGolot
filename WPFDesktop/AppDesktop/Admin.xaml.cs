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
using System.Net.Http;
using System.Net;

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
            public Button ButtonEdit { get; set; }

        }

        public void DataGridForAdmins()
        {
            //****
            string sURL;
            sURL = "https://172.24.1.178:7292/api/user/admins";

            var request = WebRequest.Create(sURL);
            request.Method = "GET";

            using var webResponse = request.GetResponse();
            using var webStream = webResponse.GetResponseStream();

            using var reader = new StreamReader(webStream);
            var adminsData = reader.ReadToEnd();
            //var adminsData = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJQb2tlbW9uR29sb3RTZXJ2aWNlQWNjZXNzVG9rZW4iLCJqdGkiOiI1YzBjZDMxMi04NGE1LTRhNjgtOWRmNC1lZTQ2YjJlYzJkODMiLCJpYXQiOiIyMi8wMy8yMDIyIDE2OjQ0OjAwIiwiRmlyc3ROYW1lIjoibWFyYyBiZWxsYXZpc3RhIGZhYnJlZ2EiLCJEYXRlIjoiMjIvMDMvMjAyMiAxNjo0Mzo1MSIsIkVtYWlsIjoibWJlbGxhdmlzdGE4QGdtYWlsLmNvbSIsIlVzZXJOYW1lIjoiYmVsbGFjcyIsIlJvbCI6IkFkbWluIiwiZXhwIjoxNjQ4MDUzODQ1LCJpc3MiOiJQb2tlbW9uR29sb3RBdXRoZW50aWNhdGlvblNlcnZlciIsImF1ZCI6IlBva2Vtb25Hb2xvdFNlcnZpY2VQb3N0bWFuQ2xpZW50In0.DQw6xjBjOpJRexJCo4dO6bFDtqF43xI5QpiIMIXfDwo\",\"user\":{\"user_name\":\"bellacs\",\"email\":\"mbellavista8@gmail.com\",\"name\":\"marc bellavista fabrega\",\"gender\":\"m\",\"birth_date\":\"2001-02-11T16:44:12.208Z\";

            JToken usersList = JToken.Parse(adminsData);

           //  App.Current.Properties["token"];

            //****
            // Read json Document **** Canviar RUTA ***
            //StreamReader r = new StreamReader("C:/Users/34662/Desktop/PokemonGolot/WPFDesktop/AppDesktop/assets/exampleAdmins.json");
            //string jsonString = r.ReadToEnd();
            //JToken usersList = JToken.Parse(jsonString);

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
            DataGridForAdmins();
        }

    }
}
