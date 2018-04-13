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
    /// Interaction logic for TeamMemberControl.xaml
    /// </summary>
    public partial class TeamMemberControl : UserControl
    {

        string Bday, Phone, Email, Bio, Notes, path1;
        int Teamwork, Effort, Technique, Power;
        double MemberType;

        public TeamMemberControl(MainWindow MyTeam, string Name, string bday, string phone, string email, string bio, int teamwork, int effort, int technique, int power, string notes, double membertype, string path)
        {
            InitializeComponent();
            TeamHandler = MyTeam;
            personName.Text = Name;
            Bday = bday;
            Phone = phone;
            Email = email; ;
            Bio = bio;
            Notes = notes;
            Teamwork = teamwork;
            Effort = effort;
            Technique = technique;
            Power = power;
            MemberType = membertype;
            path1 = path;
            if(path1 != "") personImage.Source = new BitmapImage(new Uri(path));
        }

        public MainWindow TeamHandler;

        private void memberButton_Click(object sender, RoutedEventArgs e)
        {

            if(MemberType == 3)
            {

                path1 = TeamHandler.getpath();

                if (path1 != "")
                {
                    TeamMemberProfile MainUser = new TeamMemberProfile(this, TeamHandler.NameInput.Content.ToString(), TeamHandler.BirthdayInput.Content.ToString(),
                    TeamHandler.PhoneInput.Content.ToString(), TeamHandler.EmailInput.Content.ToString(), TeamHandler.BiographyInput.Content.ToString(), 0, 0, 0, 0, "", 3, personImage.Source.ToString());
                    TeamHandler.ProfileContainerGrid.Children.Add(MainUser);
                    TeamHandler.BackgroundGrid.Visibility = Visibility.Visible;
                    TeamHandler.ProfileContainerGrid.Visibility = Visibility.Visible;
                } else if (path1 == "") 
                {
                    TeamMemberProfile MainUser = new TeamMemberProfile(this, TeamHandler.NameInput.Content.ToString(), TeamHandler.BirthdayInput.Content.ToString(),
                    TeamHandler.PhoneInput.Content.ToString(), TeamHandler.EmailInput.Content.ToString(), TeamHandler.BiographyInput.Content.ToString(), 0, 0, 0, 0, "", 3, "");
                    TeamHandler.ProfileContainerGrid.Children.Add(MainUser);
                    TeamHandler.BackgroundGrid.Visibility = Visibility.Visible;
                    TeamHandler.ProfileContainerGrid.Visibility = Visibility.Visible;
                }                    

            } else
            {
                TeamMemberProfile profile = new TeamMemberProfile(this, personName.Text, Bday, Phone, Email, Bio, Teamwork, Effort, Technique, Power, Notes, MemberType, path1);
                TeamHandler.ProfileContainerGrid.Children.Add(profile);
                TeamHandler.BackgroundGrid.Visibility = Visibility.Visible;
                TeamHandler.ProfileContainerGrid.Visibility = Visibility.Visible;
            }

        }

        public void delete()
        {
            if (MemberType == 0)
            {
                TeamHandler.PlayersUniGrid.Children.Remove(this);
            }
            else if (MemberType == 1)
            {
                TeamHandler.CoachesUniGrid.Children.Remove(this);
            }

        }


    }
} 
