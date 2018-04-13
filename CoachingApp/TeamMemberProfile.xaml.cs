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
    /// Interaction logic for TeamMemberProfile.xaml
    /// </summary>
    public partial class TeamMemberProfile : UserControl
    {

        double MemberType;

        public TeamMemberProfile(TeamMemberControl member, string name, string bday, string phone, string email, string bio, int teamwork, int effort, int technique, int power, string notes, double membertype, string path)
        {
            InitializeComponent();
            MemberHandler = member;
            ProfileButton.IsEnabled = false;
            ProfileGrid.Visibility = Visibility.Visible;
            NamePlace.Text = name;
            NameTextBlock.Text = name;
            SendMessageTo.Content = "Send a message to " + name + "!";
            BirthdayTextBlock.Text = bday;
            PhoneTextBlock.Text = phone;
            EmailTextBlock.Text = email;
            BioTextBlock.Text = bio;
            CoachNotes.Text = notes;
            TeamworkSlider.Value = teamwork;
            EffortSlider.Value = effort;
            TechniqueSlider.Value = technique;
            PowerSlider.Value = power;
            MemberType = membertype;
            if (path != "")
            {
                MemberProfile.Source = new BitmapImage(new Uri(path));
                MemberProfile.Stretch = Stretch.UniformToFill;
            }
            if (MemberType == 1) StatisticsButton.Visibility = Visibility.Hidden;
            if (MemberType == 3)
            {
                DeleteButton.Visibility = Visibility.Hidden;
                DeleteButtonPic.Visibility = Visibility.Hidden;
                MessagesButton.Visibility = Visibility.Hidden;
                ProfileButton.Visibility = Visibility.Hidden;
                StatisticsButton.Visibility = Visibility.Hidden;
                StatusBlock.Text = "ONLINE";
                StatusBlock.Foreground = Brushes.Green;

            }
            if (name == "Peter Buchelli")
            {
                DeleteButton.Visibility = Visibility.Hidden;
                DeleteButtonPic.Visibility = Visibility.Hidden;
                StatusBlock.Text = "OFFLINE";
                StatusBlock.Foreground = Brushes.Red;
            }
            if (name == "Jess Weissman")
            {
                DeleteButton.Visibility = Visibility.Hidden;
                DeleteButtonPic.Visibility = Visibility.Hidden;
                StatusBlock.Text = "ONLINE";
                StatusBlock.Foreground = Brushes.Green;
            }
            if (name == "Sarah Graham")
            {
                StatusBlock.Text = "ONLINE";
                StatusBlock.Foreground = Brushes.Green;
            }
            if (name != "Sarah Graham" && MemberType == 0)
            {
                MessagesButton.IsEnabled = false;
                StatisticsButton.IsEnabled = false;
            }
            if (name != "Jess Weissman" && name != "Peter Buchelli" && MemberType == 1)
            {
                MessagesButton.IsEnabled = false;
            }
        }

        private TeamMemberControl MemberHandler;

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            MemberHandler.TeamHandler.BackgroundGrid.Visibility = Visibility.Hidden;
            MemberHandler.TeamHandler.ProfileContainerGrid.Visibility = Visibility.Hidden;
            MemberHandler.TeamHandler.ProfileContainerGrid.Children.Remove(this);
        }

        private void MessagesButton_Click(object sender, RoutedEventArgs e)
        {
            ProfileButton.IsEnabled = true;
            MessagesButton.IsEnabled = false;
            StatisticsButton.IsEnabled = true;
            ProfileGrid.Visibility = Visibility.Hidden;
            StatisticsGrid.Visibility = Visibility.Hidden;
            MessagesGrid.Visibility = Visibility.Visible;
        }

        private void StatisticsButton_Click(object sender, RoutedEventArgs e)
        {
            ProfileButton.IsEnabled = true;
            MessagesButton.IsEnabled = true;
            StatisticsButton.IsEnabled = false;
            ProfileGrid.Visibility = Visibility.Hidden;
            StatisticsGrid.Visibility = Visibility.Visible;
            MessagesGrid.Visibility = Visibility.Hidden;
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            ProfileButton.IsEnabled = false;
            MessagesButton.IsEnabled = true;
            StatisticsButton.IsEnabled = true;
            ProfileGrid.Visibility = Visibility.Visible;
            StatisticsGrid.Visibility = Visibility.Hidden;
            MessagesGrid.Visibility = Visibility.Hidden;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteDim.Visibility = Visibility.Visible;
            DeletePrompt.Visibility = Visibility.Visible;
        }

        private void NoDelete_Click(object sender, RoutedEventArgs e)
        {
            DeleteDim.Visibility = Visibility.Hidden;
            DeletePrompt.Visibility = Visibility.Hidden;
        }

        private void YesDelete_Click(object sender, RoutedEventArgs e)
        {
            DeleteDim.Visibility = Visibility.Hidden;
            DeletePrompt.Visibility = Visibility.Hidden;
            MemberHandler.TeamHandler.BackgroundGrid.Visibility = Visibility.Hidden;
            MemberHandler.TeamHandler.ProfileContainerGrid.Visibility = Visibility.Hidden;
            MemberHandler.TeamHandler.ProfileContainerGrid.Children.Remove(this);
            MemberHandler.delete();
        }
    }
}
