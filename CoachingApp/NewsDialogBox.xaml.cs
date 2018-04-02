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
using CoachingApp;

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

        private void AddButton_Click_1(object sender, RoutedEventArgs e)
        {
            NewsPageControl newspage = new NewsPageControl();
            newspage.TitleLabel.Content = TitleTextBox.Text;
            newspage.NewsLabel.Content = Description_TextBox.Text;
            NewsHandler.NewsStackPanel.Children.Add(newspage);
            this.Close();
        }

    }
}
