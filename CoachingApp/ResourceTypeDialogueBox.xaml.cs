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
    /// Interaction logic for ResourceTypeDialogBox.xaml
    /// </summary>
    public partial class ResourceTypeDialogBox : Window
    {
        public ResourceTypeDialogBox(MainWindow Resources)
        {
            InitializeComponent();
            ResourcesHandler = Resources;
        }

        private MainWindow ResourcesHandler;
        string resourceType;

        private void TextResourceButton_Click(object sender, RoutedEventArgs e)
        {
            ResourceTitleTextBox.Visibility = Visibility.Visible;
            VideoPreview.Visibility = Visibility.Hidden;
            ResourceVideoURLBox.Visibility = Visibility.Hidden;
            ResourceTextBox.Visibility = Visibility.Visible;
            PreviewURLButton.Visibility = Visibility.Hidden;
            ShareResourceButton.IsEnabled = true;
            resourceType = "Text";
        }

        private void VideoResourceButton_Click(object sender, RoutedEventArgs e)
        {
            ResourceTitleTextBox.Visibility = Visibility.Visible;
            VideoPreview.Visibility = Visibility.Hidden;
            ResourceVideoURLBox.Visibility = Visibility.Visible;
            ResourceTextBox.Visibility = Visibility.Hidden;
            PreviewURLButton.Visibility = Visibility.Visible;
            ShareResourceButton.IsEnabled = true;
            resourceType = "Video";
        }

        private void ShareResourceButton_Click(object sender, RoutedEventArgs e)
        {
            if (resourceType == "Text")
            {
                ResourcesHandler.Resource2Title.Visibility = Visibility.Visible;
                ResourcesHandler.Resource2Desc.Visibility = Visibility.Visible;
                ResourcesHandler.Resource2Video.Visibility = Visibility.Hidden;
                ResourcesHandler.EditButtonResource2.Visibility = Visibility.Visible;
                ResourcesHandler.CommentBoxResource2.Visibility = Visibility.Visible;
                ResourcesHandler.CommentBoxShapeResource2.Visibility = Visibility.Visible;
                ResourcesHandler.CommentButtonResource2.Visibility = Visibility.Visible;

                ResourcesHandler.SetResource(resourceType);
                ResourcesHandler.Resource2Title.Content = ResourceTitleTextBox.Text;
                ResourcesHandler.Resource2Desc.Content = ResourceTextBox.Text;

                this.Close();
            }
            else if (resourceType == "Video")
            {
                ResourcesHandler.Resource2Title.Visibility = Visibility.Visible;
                ResourcesHandler.Resource2Desc.Visibility = Visibility.Hidden;
                ResourcesHandler.Resource2Video.Visibility = Visibility.Visible;
                ResourcesHandler.EditButtonResource2.Visibility = Visibility.Visible;
                ResourcesHandler.CommentBoxResource2.Visibility = Visibility.Visible;
                ResourcesHandler.CommentBoxShapeResource2.Visibility = Visibility.Visible;
                ResourcesHandler.CommentButtonResource2.Visibility = Visibility.Visible;

                ResourcesHandler.SetResource(resourceType);
                ResourcesHandler.Resource2Title.Content = ResourceTitleTextBox.Text;
                //ResourcesHandler.Resource2Video.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(path, UriKind.Relative)) };
                this.Close();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //VideoPreview.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(path, UriKind.Relative)) };
            VideoPreview.Visibility = Visibility.Visible;
        }
    }
}
