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

namespace CoachingApp
{
    /// <summary>
    /// Interaction logic for NewsPageControl.xaml
    /// </summary>
    public partial class NewsPageControl : UserControl
    {
        public NewsPageControl()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            NewsTextBox.Text = NewsLabel.Content.ToString();
            TitleTextBox.Text = TitleLabel.Content.ToString();
            TitleTextBox.Visibility = Visibility.Visible;
            NewsScrollViewLabel.Visibility = Visibility.Hidden;
            NewsScrollViewTextBox.Visibility = Visibility.Visible;
            EditButton.Visibility = Visibility.Hidden;
            SaveButton.Visibility = Visibility.Visible;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            NewsLabel.Content = NewsTextBox.Text;
            TitleLabel.Content = TitleTextBox.Text;
            TitleTextBox.Visibility = Visibility.Hidden;
            NewsScrollViewLabel.Visibility = Visibility.Visible;
            NewsScrollViewTextBox.Visibility = Visibility.Hidden;
            EditButton.Visibility = Visibility.Visible;
            SaveButton.Visibility = Visibility.Hidden;
        }
    }
}
