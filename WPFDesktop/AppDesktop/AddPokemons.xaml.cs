using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Lógica de interacción para AddPokemons.xaml
    /// </summary>
    public partial class AddPokemons : Window
    {
        List<DDL_Country> objCountryList;
        public AddPokemons()
        {
            InitializeComponent();
            objCountryList = new List<DDL_Country>();
            AddElementsInList();
            BindCountryDropDown();
        }
        public class DDL_Country
        {
            public int Country_ID
            {
                get;
                set;
            }
            public string Country_Name
            {
                get;
                set;
            }
            public Boolean Check_Status
            {
                get;
                set;
            }
        }
        private void AddElementsInList()
        {
            // 1 element  
            DDL_Country obj = new DDL_Country();
            obj.Country_ID = 10;
            obj.Country_Name = "Frost Breath";
            objCountryList.Add(obj);
            obj = new DDL_Country();
            obj.Country_ID = 11;
            obj.Country_Name = "Thunder Shock";
            objCountryList.Add(obj);
            obj = new DDL_Country();
            obj.Country_ID = 12;
            obj.Country_Name = "Confusion";
            objCountryList.Add(obj);
            obj = new DDL_Country();
            obj.Country_ID = 13;
            obj.Country_Name = "Shadow Claw";
            objCountryList.Add(obj);
            obj = new DDL_Country();
            obj.Country_ID = 14;
            obj.Country_Name = "Hydro Pump";
            objCountryList.Add(obj);
            obj = new DDL_Country();
            obj.Country_ID = 14;
            obj.Country_Name = "Dragon Breath";
            objCountryList.Add(obj);
            obj = new DDL_Country();
            obj.Country_ID = 14;
            obj.Country_Name = "Fire Fang";
            objCountryList.Add(obj);
            obj = new DDL_Country();
            obj.Country_ID = 14;
            obj.Country_Name = "Mud Shot";
            objCountryList.Add(obj);
            obj = new DDL_Country();
            obj.Country_ID = 14;
            obj.Country_Name = "Charge Beam";
            objCountryList.Add(obj);
            obj = new DDL_Country();
            obj.Country_ID = 14;
            obj.Country_Name = "Poison Jab";
            objCountryList.Add(obj);
        }

        private void BindCountryDropDown()
        {
            ddlCountry.ItemsSource = objCountryList;
        }
        private void ddlCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ddlCountry_TextChanged(object sender, TextChangedEventArgs e)
        {
            ddlCountry.ItemsSource = objCountryList.Where(x => x.Country_Name.StartsWith(ddlCountry.Text.Trim()));
        }

        private void AllCheckbocx_CheckedAndUnchecked(object sender, RoutedEventArgs e)
        {
            BindListBOX();
        }

        private void BindListBOX()
        {
            testListbox.Items.Clear();
            foreach (var country in objCountryList)
            {
                if (country.Check_Status == true)
                {
                    testListbox.Items.Add(country.Country_Name);
                }
            }
        }

        private void ButtonoOtherPokemonData_Click(object sender, RoutedEventArgs e)
        {
            AddPokemons2 objSecondWindow = new AddPokemons2();
            this.Visibility = Visibility.Hidden;
            objSecondWindow.Show();
        }

        private void ButtonEvolutions_Click(object sender, RoutedEventArgs e)
        {
           // Admin adminmenu = new Admin();
           // this.Visibility = Visibility.Hidden;
           // adminmenu.Show();
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
