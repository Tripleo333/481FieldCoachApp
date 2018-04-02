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

using CoachingApp;

namespace WpfApp1

{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String LoginName, resourceType;
        public MainWindow()
        {
            InitializeComponent();
            this.CreateAccountGrid.Visibility = Visibility.Hidden;
            this.AccountCreatedSucGrid.Visibility = Visibility.Hidden;
            this.CoachMainPageGrid.Visibility = Visibility.Hidden;
            this.CalendarParentGrid.Visibility = Visibility.Hidden;
            this.MessagesParentGrid.Visibility = Visibility.Hidden;
            this.NewsfeedGrid.Visibility = Visibility.Hidden;
            this.MyProfileGrid.Visibility = Visibility.Hidden;
            this.PlannerGrid.Visibility = Visibility.Hidden;
            this.ResourcesGrid.Visibility = Visibility.Hidden;
            this.DMParentGrid.Visibility = Visibility.Hidden;
            this.ChooseGroupChatGrid.Visibility = Visibility.Hidden;
            //this.sendMess1Grid.Visibility = Visibility.Hidden;
            this.MyTeamGrid.Visibility = Visibility.Hidden;
            //this.sendMess1Grid.Visibility = Visibility.Hidden;
            //this.TeamStatsParenGrid.Visibility = Visibility.Hidden;

        }

        private void Login(object sender, RoutedEventArgs e)
        {
            if (this.EmailTextBox.Text == "omar")
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

        private void backtoMainMenuFromMessages(object sender, RoutedEventArgs e)
        {
            this.MessagesParentGrid.Visibility = Visibility.Hidden;
        }

        private void mainMenuMessagesButton(object sender, RoutedEventArgs e)
        {
            this.MessagesParentGrid.Visibility = Visibility.Visible;
            MessageElementControl ME = new MessageElementControl();
            UGDMs.Children.Add(ME);
        }


        private void AddNewsButton_Click(object sender, RoutedEventArgs e)
        {
            NewsDialogBox ndb = new NewsDialogBox(this);
            ndb.Show();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NewsfeedGrid.Visibility = Visibility.Hidden;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            NameTextBox.Text = NameInput.Content.ToString();
            NameTextBox.Visibility = Visibility.Visible;
            NameInput.Visibility = Visibility.Hidden;

            PhoneTextBox.Text = PhoneInput.Content.ToString();
            PhoneTextBox.Visibility = Visibility.Visible;
            PhoneInput.Visibility = Visibility.Hidden;

            EmailTextBox.Text = EmailInput.Content.ToString();
            EmailTextBox.Visibility = Visibility.Visible;
            EmailInput.Visibility = Visibility.Hidden;

            BiographyTextBox.Text = BiographyInput.Content.ToString();
            BiographyTextBox.Visibility = Visibility.Visible;
            BiographyInput.Visibility = Visibility.Hidden;

            BirthdayPicker.Visibility = Visibility.Visible;
            BirthdayInput.Visibility = Visibility.Hidden;

            EditButton.Visibility = Visibility.Hidden;
            SaveButton.Visibility = Visibility.Visible;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            NameInput.Content = NameTextBox.Text;
            NameTextBox.Visibility = Visibility.Hidden;
            NameInput.Visibility = Visibility.Visible;

            PhoneInput.Content = PhoneTextBox.Text;
            PhoneTextBox.Visibility = Visibility.Hidden;
            PhoneInput.Visibility = Visibility.Visible;

            EmailInput.Content = EmailTextBox.Text;
            EmailTextBox.Visibility = Visibility.Hidden;
            EmailInput.Visibility = Visibility.Visible;

            BiographyInput.Content = BiographyTextBox.Text;
            BiographyTextBox.Visibility = Visibility.Hidden;
            BiographyInput.Visibility = Visibility.Visible;

            BirthdayInput.Content = BirthdayPicker.Text;
            BirthdayPicker.Visibility = Visibility.Hidden;
            BirthdayInput.Visibility = Visibility.Visible;

            EditButton.Visibility = Visibility.Visible;
            SaveButton.Visibility = Visibility.Hidden;
        }

        private void BackButtonProfile_Click(object sender, RoutedEventArgs e)
        {
            MyProfileGrid.Visibility = Visibility.Hidden;
        }

        private void UploadProfPhoto_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dfg = new Microsoft.Win32.OpenFileDialog();
            dfg.Filter = "JPG | *.jpg; PNG | *.png; GIF | *.gif";
            if (dfg.ShowDialog() == true)
            {
                Console.WriteLine(dfg.FileName);
                ProfilePhoto.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(dfg.FileName, UriKind.Relative)) };
            }
        }

        private void BackButtonPlanner_Click(object sender, RoutedEventArgs e)
        {
            PlannerGrid.Visibility = Visibility.Hidden;
        }

        private void AddPlanButton_Click(object sender, RoutedEventArgs e)
        {
            PlannerDialogBox pdb = new PlannerDialogBox(this);
            pdb.Show();
        }

        private void CommentButton1Plan_Click(object sender, RoutedEventArgs e)
        {
            Comment1Plan.Content = CommentBox1Plan.Text;
            Comment1Plan.Visibility = Visibility.Visible;
            YourCommentBox1Plan.Visibility = Visibility.Visible;
            Plan1CommentPic.Visibility = Visibility.Visible;
            Comment1YouPlan.Visibility = Visibility.Visible;

        }

        private void CommentButton2Plan_Click(object sender, RoutedEventArgs e)
        {
            Comment2Plan.Content = CommentBox2Plan.Text;
            Comment2Plan.Visibility = Visibility.Visible;
            YourCommentBox2Plan.Visibility = Visibility.Visible;
            Plan2CommentPic.Visibility = Visibility.Visible;
            Comment2YouPlan.Visibility = Visibility.Visible;
        }

        private void EditButtonPlan1_Click(object sender, RoutedEventArgs e)
        {
            Plan1DescTextBox.Text = Plan1Desc.Content.ToString();
            Plan1TitleTextBox.Text = Plan1Title.Content.ToString();
            Plan1Title.Visibility = Visibility.Hidden;
            Plan1TitleTextBox.Visibility = Visibility.Visible;
            Plan1DescTextBox.Visibility = Visibility.Visible;
            ChangePhotoPlan1Button.Visibility = Visibility.Visible;
            SaveButtonPlan1.Visibility = Visibility.Visible;
        }

        private void EditButtonPlan2_Click(object sender, RoutedEventArgs e)
        {
            Plan2DescTextBox.Text = Plan2Desc.Content.ToString();
            Plan2TitleTextBox.Text = Plan2Title.Content.ToString();
            Plan2Title.Visibility = Visibility.Hidden;
            Plan2TitleTextBox.Visibility = Visibility.Visible;
            Plan2DescTextBox.Visibility = Visibility.Visible;
            ChangePhotoPlan2Button.Visibility = Visibility.Visible;
            SaveButtonPlan2.Visibility = Visibility.Visible;
        }

        private void SaveButtonPlan1_Click(object sender, RoutedEventArgs e)
        {
            Plan1Desc.Content = Plan1DescTextBox.Text;
            Plan1Title.Content = Plan1TitleTextBox.Text;
            Plan1Title.Visibility = Visibility.Visible;
            Plan1TitleTextBox.Visibility = Visibility.Hidden;
            Plan1DescTextBox.Visibility = Visibility.Hidden;
            Plan1Desc.Visibility = Visibility.Visible;
            EditButtonPlan1.Visibility = Visibility.Visible;
            ChangePhotoPlan1Button.Visibility = Visibility.Hidden;
            SaveButtonPlan1.Visibility = Visibility.Hidden;
        }

        private void SaveButtonPlan2_Click(object sender, RoutedEventArgs e)
        {
            Plan2Desc.Content = Plan2DescTextBox.Text;
            Plan2Title.Content = Plan2TitleTextBox.Text;
            Plan2Title.Visibility = Visibility.Visible;
            Plan2TitleTextBox.Visibility = Visibility.Hidden;
            Plan2DescTextBox.Visibility = Visibility.Hidden;
            Plan2Desc.Visibility = Visibility.Visible;
            EditButtonPlan2.Visibility = Visibility.Visible;
            ChangePhotoPlan2Button.Visibility = Visibility.Hidden;
            SaveButtonPlan2.Visibility = Visibility.Hidden;
        }

        private void ChangePhotoPlan1Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dfg = new Microsoft.Win32.OpenFileDialog();
            dfg.Filter = "JPG | *.jpg; PNG | *.png; GIF | *.gif";
            if (dfg.ShowDialog() == true)
            {
                Console.WriteLine(dfg.FileName);
                Plan1Image.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(dfg.FileName, UriKind.Relative)) };
            }
        }

        private void ChangePhotoPlan2Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dfg = new Microsoft.Win32.OpenFileDialog();
            dfg.Filter = "JPG | *.jpg; PNG | *.png; GIF | *.gif";
            if (dfg.ShowDialog() == true)
            {
                Console.WriteLine(dfg.FileName);
                Plan2Image.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(dfg.FileName, UriKind.Relative)) };
            }
        }

        private void ShareButton_Click(object sender, RoutedEventArgs e)
        {
            ResourceTypeDialogBox rtdb = new ResourceTypeDialogBox(this);
            rtdb.Show();
        }

        private void BackButtonResources_Click(object sender, RoutedEventArgs e)
        {
            ResourcesGrid.Visibility = Visibility.Hidden;
        }

        private void CommentButtonResource1_Click(object sender, RoutedEventArgs e)
        {
            CommentResource1.Content = CommentBoxResource1.Text;
            CommentResource1.Visibility = Visibility.Visible;
            YourCommentBoxResource1.Visibility = Visibility.Visible;
            Resource1CommentPic.Visibility = Visibility.Visible;
            CommentYouResource1.Visibility = Visibility.Visible;
        }

        private void CommentButtonResource2_Click(object sender, RoutedEventArgs e)
        {
            CommentResource2.Content = CommentBoxResource2.Text;
            CommentResource2.Visibility = Visibility.Visible;
            YourCommentBoxResource2.Visibility = Visibility.Visible;
            Resource2CommentPic.Visibility = Visibility.Visible;
            CommentYouResource2.Visibility = Visibility.Visible;
        }

        public void SetResource(string resourceType)
        {
            this.resourceType = resourceType;
        }

        private void EditButtonResource2_Click(object sender, RoutedEventArgs e)
        {
            if (resourceType == "Text")
            {
                Resource2DescTextBox.Text = Resource2Desc.Content.ToString();
                Resource2TitleTextBox.Text = Resource2Title.Content.ToString();
                Resource2Title.Visibility = Visibility.Hidden;
                Resource2Desc.Visibility = Visibility.Hidden;
                Resource2TitleTextBox.Visibility = Visibility.Visible;
                Resource2DescTextBox.Visibility = Visibility.Visible;
                EditButtonResource2.Visibility = Visibility.Hidden;
                SaveButtonResource2.Visibility = Visibility.Visible;

            }
            else if (resourceType == "Video")
            {
                Resource2TitleTextBox.Text = "URL: " + Resource2Title.Content.ToString();
                Resource2Title.Visibility = Visibility.Hidden;
                Resource2TitleTextBox.Visibility = Visibility.Visible;
                EditButtonResource2.Visibility = Visibility.Hidden;
                SaveButtonResource2.Visibility = Visibility.Visible;
            }
        }

        private void SaveButtonResource2_Click(object sender, RoutedEventArgs e)
        {
            if (resourceType == "Text")
            {
                Resource2Desc.Content = Resource2DescTextBox.Text;
                Resource2Title.Content = Resource2TitleTextBox.Text;
                Resource2Title.Visibility = Visibility.Visible;
                Resource2Desc.Visibility = Visibility.Visible;
                Resource2TitleTextBox.Visibility = Visibility.Hidden;
                Resource2DescTextBox.Visibility = Visibility.Hidden;
                EditButtonResource2.Visibility = Visibility.Visible;
                SaveButtonResource2.Visibility = Visibility.Hidden;
            }
            else if (resourceType == "Video")
            {
                Resource2Title.Content = Resource2TitleTextBox.Text;
                Resource2Title.Visibility = Visibility.Visible;
                Resource2TitleTextBox.Visibility = Visibility.Hidden;
                EditButtonResource2.Visibility = Visibility.Visible;
                SaveButtonResource2.Visibility = Visibility.Hidden;
                //Resource2Video.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(path, UriKind.Relative)) };
            }
        }

        private void EditButtonResource1_Click(object sender, RoutedEventArgs e)
        {
            Resource1TitleTextBox.Text = "URL: " + Resource1Title.Content.ToString();
            Resource1Title.Visibility = Visibility.Hidden;
            Resource1TitleTextBox.Visibility = Visibility.Visible;
            EditButtonResource1.Visibility = Visibility.Hidden;
            SaveButtonResource1.Visibility = Visibility.Visible;
        }

        private void menuItemButton5_Click(object sender, RoutedEventArgs e)
        {
            this.PlannerGrid.Visibility = Visibility.Visible;
        }

        private void menuItemButton6_Click(object sender, RoutedEventArgs e)
        {
            this.ResourcesGrid.Visibility = Visibility.Visible;
        }

        private void menuItemButton_Click(object sender, RoutedEventArgs e)
        {
            this.MyProfileGrid.Visibility = Visibility.Visible;
        }

        private void menuItemButton7_Click(object sender, RoutedEventArgs e)
        {
            this.NewsfeedGrid.Visibility = Visibility.Visible;
        }

        private void CreateGroup(object sender, RoutedEventArgs e)
        {

        }

        private void BacktoMessages(object sender, RoutedEventArgs e)
        {
            this.ChooseGroupChatGrid.Visibility = Visibility.Hidden;
            this.MessagesParentGrid.Visibility = Visibility.Visible;
        }

        private void StartGroupClick(object sender, RoutedEventArgs e)
        {
            this.ChooseGroupChatGrid.Visibility = Visibility.Visible;
        }

        private void startDM(object sender, RoutedEventArgs e)
        {
            this.DMParentGrid.Visibility = Visibility.Visible;
          //  this.DMNotification.Visibility = Visibility.Hidden;
        }

        private void CreateGroupChat(object sender, RoutedEventArgs e)
        {
            //TODO:
        }

        private void BacktoMessagesFromDM(object sender, RoutedEventArgs e)
        {
            this.DMParentGrid.Visibility = Visibility.Hidden;
            this.MessagesParentGrid.Visibility = Visibility.Visible;
        }

        private void DMSendMess1(object sender, RoutedEventArgs e)
        {
           // this.sendMess1Grid.Visibility = Visibility.Visible;
        }

        private void BackButtonTeam_Click(object sender, RoutedEventArgs e)
        {
            this.MyTeamGrid.Visibility = Visibility.Hidden;
        }

        private void ExitProfile_Click(object sender, RoutedEventArgs e)
        {
            BackgroundGrid.Visibility = Visibility.Hidden;

            DefaultProfileGrid.Visibility = Visibility.Hidden;
            StatsGrid.Visibility = Visibility.Hidden;
            MessageGrid.Visibility = Visibility.Hidden;

            ProfileButton.Visibility = Visibility.Hidden;
            StatisticsButton.Visibility = Visibility.Hidden;
            MessageButton.Visibility = Visibility.Hidden;
            ProfilePhotoImage.Visibility = Visibility.Hidden;
            NamePlace.Visibility = Visibility.Hidden;

            ExitProfile.Visibility = Visibility.Hidden;
        }

        private void Player1Button_Click(object sender, RoutedEventArgs e)
        {
            BackgroundGrid.Visibility = Visibility.Visible;

            DefaultProfileGrid.Visibility = Visibility.Visible;
            StatsGrid.Visibility = Visibility.Hidden;
            MessageGrid.Visibility = Visibility.Hidden;

            ProfileButton.Visibility = Visibility.Visible;
            StatisticsButton.Visibility = Visibility.Visible;
            MessageButton.Visibility = Visibility.Visible;
            ProfilePhotoImage.Visibility = Visibility.Visible;
            NamePlace.Visibility = Visibility.Visible;

            NamePlaceProfile.Content = "Sarah Graham";
            AgeText.Content = "19";
            EmailText.Content = "sarahgman@ucalgary.ca";
            PhoneText.Content = "(403)223-5721";
            BioText.Content = "This is my third year playing field hockey.";

            SliderTeam.Value = 4;
            SliderEffort.Value = 4;
            SliderTechnique.Value = 1;
            SliderPower.Value = 2;
            ProfileNotes.Text = "She could use some assistance with her technique. -Tina";

            ExitProfile.Visibility = Visibility.Visible;
        }

        private void Coach1Button_Click(object sender, RoutedEventArgs e)
        {
            BackgroundGrid.Visibility = Visibility.Visible;

            DefaultProfileGrid.Visibility = Visibility.Visible;
            StatsGrid.Visibility = Visibility.Hidden;
            MessageGrid.Visibility = Visibility.Hidden;

            ProfileButton.Visibility = Visibility.Visible;
            StatisticsButton.Visibility = Visibility.Hidden;
            MessageButton.Visibility = Visibility.Visible;
            ProfilePhotoImage.Visibility = Visibility.Visible;
            NamePlace.Visibility = Visibility.Visible;

            NamePlaceProfile.Content = "Tina Ermin";
            AgeText.Content = "24";
            EmailText.Content = "terminator@ucalgary.ca";
            PhoneText.Content = "(403)412-2242";
            BioText.Content = "Your #1 junior coach!";

            ExitProfile.Visibility = Visibility.Visible;
        }

        private void Coach2Button_Click(object sender, RoutedEventArgs e)
        {
            BackgroundGrid.Visibility = Visibility.Visible;

            DefaultProfileGrid.Visibility = Visibility.Visible;
            StatsGrid.Visibility = Visibility.Hidden;
            MessageGrid.Visibility = Visibility.Hidden;

            ProfileButton.Visibility = Visibility.Visible;
            StatisticsButton.Visibility = Visibility.Hidden;
            MessageButton.Visibility = Visibility.Visible;
            ProfilePhotoImage.Visibility = Visibility.Visible;
            NamePlace.Visibility = Visibility.Visible;

            NamePlaceProfile.Content = "Brenda Muier";
            AgeText.Content = "49";
            EmailText.Content = "brenma@ucalgary.ca";
            PhoneText.Content = "(587)343-1431";
            BioText.Content = "20 years of field hockey experience";

            ExitProfile.Visibility = Visibility.Visible;
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            DefaultProfileGrid.Visibility = Visibility.Visible;
            StatsGrid.Visibility = Visibility.Hidden;
            MessageGrid.Visibility = Visibility.Hidden;
        }

        private void MessageButton_Click(object sender, RoutedEventArgs e)
        {
            DefaultProfileGrid.Visibility = Visibility.Hidden;
            StatsGrid.Visibility = Visibility.Hidden;
            MessageGrid.Visibility = Visibility.Visible;
        }

        private void StatisticsButton_Click(object sender, RoutedEventArgs e)
        {
            DefaultProfileGrid.Visibility = Visibility.Hidden;
            StatsGrid.Visibility = Visibility.Visible;
            MessageGrid.Visibility = Visibility.Hidden;
        }

        private void SendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Successfully Sent!", "Message");
            MessageBox.Text = "Say Something...";
        }

        private void menuItemButton4_Click(object sender, RoutedEventArgs e)
        {
            this.MyTeamGrid.Visibility = Visibility.Visible;
            BackgroundGrid.Visibility = Visibility.Hidden;

            DefaultProfileGrid.Visibility = Visibility.Hidden;
            StatsGrid.Visibility = Visibility.Hidden;
            MessageGrid.Visibility = Visibility.Hidden;

            ProfileButton.Visibility = Visibility.Hidden;
            StatisticsButton.Visibility = Visibility.Hidden;
            MessageButton.Visibility = Visibility.Hidden;
            ProfilePhotoImage.Visibility = Visibility.Hidden;
            NamePlace.Visibility = Visibility.Hidden;

            ExitProfile.Visibility = Visibility.Hidden;
        }

        private void OpenTeamStats(object sender, RoutedEventArgs e)
        {
            //this.TeamStatsParenGrid.Visibility = Visibility.Visible;
        }

        private void backtoMMfromStats(object sender, RoutedEventArgs e)
        {
            //this.TeamStatsParenGrid.Visibility = Visibility.Hidden;

        }

        private void SaveButtonResource1_Click(object sender, RoutedEventArgs e)
        {
            Resource1Title.Content = Resource1TitleTextBox.Text;
            Resource1Title.Visibility = Visibility.Visible;
            Resource1TitleTextBox.Visibility = Visibility.Hidden;
            EditButtonResource1.Visibility = Visibility.Visible;
            SaveButtonResource1.Visibility = Visibility.Hidden;
            //Resource1Video.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(path, UriKind.Relative)) };
        }
    }
}
