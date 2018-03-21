using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String LoginName;
        public MainWindow()
        {
            InitializeComponent();
            this.CreateAccountGrid.Visibility = Visibility.Hidden;
            this.AccountCreatedSucGrid.Visibility = Visibility.Hidden;
            this.CoachMainPageGrid.Visibility = Visibility.Hidden;
            this.CalendarParentGrid.Visibility = Visibility.Hidden;


        }

        private void Login(object sender, RoutedEventArgs e)
        {
            if(this.EmailTextBox.Text == "omar")
            {
                //                this.EmailTextBox.Visibility = Visibility.Hidden;
                this.LoginGrid.Visibility = Visibility.Hidden;
                this.CoachMainPageGrid.Visibility = Visibility.Visible;
                LoginName = EmailTextBox.Text;
                HelloTextblock.Text += LoginName + "!";

            }
        }

        private void Create_Account_Click(object sender, RoutedEventArgs e)
        {
            this.CreateAccountGrid.Visibility = Visibility.Visible;

        }

        private void Create_Account_Click2(object sender, RoutedEventArgs e)
        {
            this.CreateAccountGrid.Visibility = Visibility.Hidden;
            this.AccountCreatedSucGrid.Visibility = Visibility.Visible;
        }

        private void loginPageButton(object sender, RoutedEventArgs e)
        {
            this.AccountCreatedSucGrid.Visibility = Visibility.Hidden;
            this.LoginGrid.Visibility = Visibility.Visible;
        }

        private void mainMenuExitButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void gotoCalendar(object sender, RoutedEventArgs e)
        {
            this.CalendarParentGrid.Visibility = Visibility.Visible;
        }

        private void backToMainMenu(object sender, RoutedEventArgs e)
        {
            this.CalendarParentGrid.Visibility = Visibility.Hidden;
        }
    }
}
