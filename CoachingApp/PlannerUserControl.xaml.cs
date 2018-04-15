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
    /// Interaction logic for PlannerUserControl.xaml
    /// </summary>
    public partial class PlannerUserControl : UserControl
    {
        public PlannerUserControl()
        {
            InitializeComponent();
        }

        string PlannerPath;

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            NewsTextBox.Text = NewsTextBlock.Text;
            TitleLabel.Visibility = Visibility.Hidden;
            TitleTextBox.Text = TitleLabel.Content.ToString();
            NewsTextBlock.Visibility = Visibility.Hidden;
            NewsTextBox.Visibility = Visibility.Visible;
            TitleTextBox.Visibility = Visibility.Visible;
            NewsScrollViewTextBox.Visibility = Visibility.Visible;
            EditButton.Visibility = Visibility.Hidden;
            SaveButton.Visibility = Visibility.Visible;
            ChangePhotoButton.Visibility = Visibility.Visible;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            NewsTextBlock.Text = NewsTextBox.Text;
            TitleLabel.Visibility = Visibility.Visible;
            TitleLabel.Content = TitleTextBox.Text;
            NewsTextBlock.Visibility = Visibility.Visible;
            NewsTextBox.Visibility = Visibility.Hidden;
            TitleTextBox.Visibility = Visibility.Hidden;
            NewsScrollViewTextBox.Visibility = Visibility.Hidden;
            EditButton.Visibility = Visibility.Visible;
            SaveButton.Visibility = Visibility.Hidden;
            ChangePhotoButton.Visibility = Visibility.Hidden;
        }

        private void PostComment_Click(object sender, RoutedEventArgs e)
        {
            CommentUserControl comment = new CommentUserControl();
            comment.Comment.Text = CommentTextBox.Text;
            CommentSection.Children.Add(comment);
            CommentTextBox.Text = "Say something...";
        }

        private void ChangePhotoButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dfg = new Microsoft.Win32.OpenFileDialog();
            dfg.Filter = "JPG | *.jpg; PNG | *.png; GIF | *.gif";
            if (dfg.ShowDialog() == true)
            {
                Console.WriteLine(dfg.FileName);
                PlanPhoto.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(dfg.FileName, UriKind.Relative)) };
                PlannerPath = dfg.FileName;
            }
        }
    }
}
