using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppDesktop
{
    /// <summary>
    /// Lógica de interacción para AddPokemons2.xaml
    /// </summary>
    public partial class AddPokemons2 : Window
    {
        public AddPokemons2()
        {
            InitializeComponent();
        }
        private void ButtonPokemonData_Click(object sender, RoutedEventArgs e)
        {
              AddPokemons objSecondWindow = new AddPokemons();
              this.Visibility = Visibility.Hidden;
              objSecondWindow.Show();
        }

     

        private void ButtonEvolutions_Click(object sender, RoutedEventArgs e)
        {
            // Admin adminmenu = new Admin();
            // this.Visibility = Visibility.Hidden;
            // adminmenu.Show();
        }

        private void ImagePanel_Drop(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Note that you can have more than one file.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                // Assuming you have one file that you care about, pass it off to whatever
                // handling code you have defined.
         
            }
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