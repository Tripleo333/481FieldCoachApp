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
    /// Interaction logic for ResourcesPhotoControl.xaml
    /// </summary>
    public partial class ResourcesPhotoControl : UserControl
    {
        public ResourcesPhotoControl()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            TitleTextBox.Text = TitleLabel.Content.ToString();
            TitleLabel.Visibility = Visibility.Hidden;
            TitleTextBox.Visibility = Visibility.Visible;
            EditButton.Visibility = Visibility.Hidden;
            SaveButton.Visibility = Visibility.Visible;

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            TitleLabel.Content = TitleTextBox.Text;
            TitleLabel.Visibility = Visibility.Visible;
            TitleTextBox.Visibility = Visibility.Hidden;
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
