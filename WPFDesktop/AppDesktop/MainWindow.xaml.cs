using System.Windows;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using AppDesktop.Request.Post;
using System.Net;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

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

        private async void Login_OnClick(object sender, RoutedEventArgs e)
        {



            string userName = userBox.Text;
            string userPassword = passwordBox.Password;
            // check if the fields are full
            if (userName == "" || userPassword == "")
            {
                MessageBox.Show("Cal omplir els camps");
            }
            else
            {
                try
                {
                    // Function validate user
                    string response = await login_post.loginPostAsync(userName, userPassword);
                    JObject tokenJson = JObject.Parse(response);

                    string token = tokenJson.GetValue("token").ToString();

                    App.Current.Properties["token"] = token;
                    string myProperty = App.Current.Properties["token"].ToString();

                    Trace.WriteLine(response);

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

        static void NEVER_EAT_POISON_Disable_CertificateValidation()
        {
            // Disabling certificate validation can expose you to a man-in-the-middle attack
            // which may allow your encrypted message to be read by an attacker
            // https://stackoverflow.com/a/14907718/740639
            ServicePointManager.ServerCertificateValidationCallback =
                delegate (
                    object s,
                    X509Certificate certificate,
                    X509Chain chain,
                    SslPolicyErrors sslPolicyErrors
                ) {
                    return true;
                };
        }


    }
}
