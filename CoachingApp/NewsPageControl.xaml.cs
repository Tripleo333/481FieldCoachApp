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
using WpfApp1;

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
            NewsTextBox.Text = NewsTextBlock.Text;
            TitleTextBox.Text = TitleLabel.Content.ToString();
            NewsTextBlock.Visibility = Visibility.Hidden;
            NewsTextBox.Visibility = Visibility.Visible;
            TitleTextBox.Visibility = Visibility.Visible;
            NewsScrollViewLabel.Visibility = Visibility.Hidden;
            NewsScrollViewTextBox.Visibility = Visibility.Visible;
            EditButton.Visibility = Visibility.Hidden;
            SaveButton.Visibility = Visibility.Visible;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
                NewsTextBlock.Text = NewsTextBox.Text;
                TitleLabel.Content = TitleTextBox.Text;
                NewsTextBlock.Visibility = Visibility.Visible;
                NewsTextBox.Visibility = Visibility.Hidden;
                TitleTextBox.Visibility = Visibility.Hidden;
                NewsScrollViewLabel.Visibility = Visibility.Visible;
                NewsScrollViewTextBox.Visibility = Visibility.Hidden;
                EditButton.Visibility = Visibility.Visible;
                SaveButton.Visibility = Visibility.Hidden;
        }

        private void PostComment_Click(object sender, RoutedEventArgs e)
        {
            CommentUserControl comment = new CommentUserControl();
            comment.Comment.Text = CommentTextBox.Text;
            CommentSection.Children.Add(comment);
            CommentTextBox.Text = "Say something...";
        }
    }
}
