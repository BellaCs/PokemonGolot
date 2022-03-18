using System.Windows;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using AppDesktop.Request.Post;
using System.Net;

namespace AppDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public System.Security.SecureString SecurePassword { get; }

        public login_post login_post { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            login_post = new login_post();
            Application_Start();
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



            string userName = userBox.Text;
            string userPassword = passwordBox.Password;
            // check if the fields are full
            if (userName == "" || userPassword =="") {
                MessageBox.Show("Cal omplir els camps");
            }
            else
            {
                try
                {
                    // Function validate user
                    string statusCode = login_post.loginPost(userName, userPassword);

                    Pokemons pokemonmenu = new Pokemons();
                    this.Visibility = Visibility.Hidden;
                    pokemonmenu.Show();
                }
                catch (System.Exception)
                {
                    // if user isn't correct, show textbox
                    MessageBoxResult result = System.Windows.MessageBox.Show("Dades Incorrectes", "Usuari o contrasenya incorrecte", MessageBoxButton.OK);
                    
                    switch (result)
                    {
                        case MessageBoxResult.OK:
                            MainWindow objSecondWindow = new MainWindow();
                            this.Visibility = Visibility.Hidden;
                            objSecondWindow.Show();
                            break;
                    }
                    throw;
                }
            }
            


        }

        protected void Application_Start()
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        }


    }
}
