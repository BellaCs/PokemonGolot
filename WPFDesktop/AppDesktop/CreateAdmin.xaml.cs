using System.Windows;

namespace AppDesktop
{
    /// <summary>
    /// Lógica de interacción para CreateAdmin.xaml
    /// </summary>
    public partial class CreateAdmin : Window
    {
        public CreateAdmin()
        {
            InitializeComponent();
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
        private void ButtonCancelRegister_Click(object sender, RoutedEventArgs e)
        {
            Admin objSecondWindow = new Admin();
            this.Visibility = Visibility.Hidden;
            objSecondWindow.Show();

        }
    }
}