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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for NewsDialogBox.xaml
    /// </summary>
    public partial class NewsDialogBox : Window
    {
        public NewsDialogBox(MainWindow News)
        {
            InitializeComponent();
            NewsHandler = News;
        }

        private MainWindow NewsHandler;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewsHandler.Title2Label.Content = this.TitleTextBox.Text;
            NewsHandler.News2.Content = this.Description_TextBox.Text;
            NewsHandler.Title2Label.Visibility = Visibility.Visible;
            NewsHandler.News2.Visibility = Visibility.Visible;
            NewsHandler.CommentButton2.Visibility = Visibility.Visible;
            NewsHandler.EditButton2.Visibility = Visibility.Visible;
            NewsHandler.CommentBox2.Visibility = Visibility.Visible;
            NewsHandler.CommentBoxShape2.Visibility = Visibility.Visible;
            this.Close();
        }


    }
}
