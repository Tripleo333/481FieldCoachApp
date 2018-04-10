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
        String LoginName, resourceType, PlannerPath, ResourcePath;
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
            NewsDialogBox.Visibility = Visibility.Visible;
            AddNewsButton.Visibility = Visibility.Hidden;
            BackButton.Visibility = Visibility.Hidden;
            NewsfeedLabel.Visibility = Visibility.Hidden;
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
            PlannerLabel.Visibility = Visibility.Hidden;
            BackButtonPlanner.Visibility = Visibility.Hidden;
            AddPlanButton.Visibility = Visibility.Hidden;
            PlannerDialogBox.Visibility = Visibility.Visible;
        }

        private void ShareButton_Click(object sender, RoutedEventArgs e)
        {
            ResourcesDialogBox.Visibility = Visibility.Visible;
            ResourcesLabel.Visibility = Visibility.Hidden;
            ShareButton.Visibility = Visibility.Hidden;
            BackButtonResources.Visibility = Visibility.Hidden;
        }

        private void BackButtonResources_Click(object sender, RoutedEventArgs e)
        {
            ResourcesGrid.Visibility = Visibility.Hidden;
        }

        public void SetResource(string resourceType)
        {
            this.resourceType = resourceType;
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
            this.ChooseGroupChatGrid.Visibility = Visibility.Hidden;
            this.DMParentGrid.Visibility = Visibility.Visible;
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

            NamePlace.Content = "Sarah Graham";
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

            NamePlace.Content = "Tina Ermin";
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

            NamePlace.Content = "Brenda Muier";
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

            ProfileButton.IsEnabled = false;
            MessageButton.IsEnabled = true;
            StatisticsButton.IsEnabled = true;
        }

        private void MessageButton_Click(object sender, RoutedEventArgs e)
        {
            DefaultProfileGrid.Visibility = Visibility.Hidden;
            StatsGrid.Visibility = Visibility.Hidden;
            MessageGrid.Visibility = Visibility.Visible;

            ProfileButton.IsEnabled = true;
            MessageButton.IsEnabled = true;
            StatisticsButton.IsEnabled = false;
        }

        private void StatisticsButton_Click(object sender, RoutedEventArgs e)
        {
            DefaultProfileGrid.Visibility = Visibility.Hidden;
            StatsGrid.Visibility = Visibility.Visible;
            MessageGrid.Visibility = Visibility.Hidden;

            ProfileButton.IsEnabled = true;
            MessageButton.IsEnabled = true;
            StatisticsButton.IsEnabled = false;
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

        private void AddButton_Click_1(object sender, RoutedEventArgs e)
        {
            NewsPageControl newspage = new NewsPageControl();
            newspage.TitleLabel.Content = TitleTextBox.Text;
            newspage.NewsTextBlock.Text = Description_TextBox.Text;
            NewsUniGrid.Children.Insert(0, newspage);
            Description_TextBox.Text = "";
            TitleTextBox.Text = "";
            NewsDialogBox.Visibility = Visibility.Hidden;
            NewsfeedLabel.Visibility = Visibility.Visible;
            AddNewsButton.Visibility = Visibility.Visible;
            BackButton.Visibility = Visibility.Visible;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            NewsDialogBox.Visibility = Visibility.Hidden;
            Description_TextBox.Text = "";
            TitleTextBox.Text = "";
            NewsfeedLabel.Visibility = Visibility.Visible;
            AddNewsButton.Visibility = Visibility.Visible;
            BackButton.Visibility = Visibility.Visible;
        }

        private void PlannerDialogCloseButton_Click(object sender, RoutedEventArgs e)
        {
            PlannerDialogBox.Visibility = Visibility.Hidden;
            PlannerTitleTextBox.Text = "";
            PlannerDescTextBox.Text = "";
            AddPlanButton.Visibility = Visibility.Visible;
            PlannerLabel.Visibility = Visibility.Visible;
            BackButtonPlanner.Visibility = Visibility.Visible;
        }

        private void PlannerDialogAddPlan_Click(object sender, RoutedEventArgs e)
        {
            if (PlannerPath != null)
            {
                PlannerUserControl planner = new PlannerUserControl();
                planner.TitleLabel.Content = PlannerTitleTextBox.Text;
                planner.NewsTextBlock.Text = PlannerDescTextBox.Text;
                planner.PlanPhoto.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(PlannerPath, UriKind.Relative)) };
                PlannerUniGrid.Children.Insert(0, planner);
                PlannerTitleTextBox.Text = "";
                PlannerDescTextBox.Text = "";
                AddPlanButton.Visibility = Visibility.Visible;
                BackButtonPlanner.Visibility = Visibility.Visible;
                PlannerLabel.Visibility = Visibility.Visible;
                PlannerDialogBox.Visibility = Visibility.Hidden;
            } else
            {
                System.Windows.MessageBox.Show("Plan requires a photo", "Error");
            }
        }

        private void ResourceDialogCloseButton_Click(object sender, RoutedEventArgs e)
        {
            ResourcesDialogBox.Visibility = Visibility.Hidden;
            ResourceTextBox.Text = "";
            ResourceTitleTextBox.Text = "";
            ResourceVideoURLBox.Text = "";
            ShareButton.Visibility = Visibility.Visible;
            ResourcesLabel.Visibility = Visibility.Visible;
            BackButtonResources.Visibility = Visibility.Visible;

            ResourceTitleTextBox.Visibility = Visibility.Hidden;
            VideoPreview.Visibility = Visibility.Hidden;
            ResourceVideoURLBox.Visibility = Visibility.Hidden;
            ResourceTextBox.Visibility = Visibility.Hidden;
            PreviewURLButton.Visibility = Visibility.Hidden;
        }

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

        private void PreviewURLButton_Click(object sender, RoutedEventArgs e)
        {
            // TEMPORARY
            Microsoft.Win32.OpenFileDialog dfg = new Microsoft.Win32.OpenFileDialog();
            dfg.Filter = "JPG | *.jpg; PNG | *.png; GIF | *.gif";
            if (dfg.ShowDialog() == true)
            {
                Console.WriteLine(dfg.FileName);
                UploadPhotoPlan.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(dfg.FileName, UriKind.Relative)) };
                ResourcePath = dfg.FileName;
            }
        }

        private void DMtoMessagesList(object sender, RoutedEventArgs e)
        {
            this.DMParentGrid.Visibility = Visibility.Hidden;
        }

        private void Send_Button_Click(object sender, RoutedEventArgs e)
        {
            sendMessageUserControl sentMessage = new sendMessageUserControl();
            sentMessage.sendMessageTextBox.Text = currentMessageTextBox.Text;
            currentMessageTextBox.Text = "";
            MessagesUniformGrid.Children.Add(sentMessage);
        }

        private void ExitCreateEvent_Click(object sender, RoutedEventArgs e)
        {
            this.AddEventParentGrid.Visibility = Visibility.Hidden;
        }

        private void AddNewCalendarEvent_Click(object sender, RoutedEventArgs e)
        {
            this.AddEventParentGrid.Visibility = Visibility.Visible;
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
                NewsPageControl text = new NewsPageControl();
                text.TitleLabel.Content = ResourceTitleTextBox.Text;
                text.NewsTextBlock.Text = ResourceTextBox.Text;
                ResourcesUniGrid.Children.Insert(0, text);
                ResourceTextBox.Text = "";
                ResourceTitleTextBox.Text = "";
                ResourceVideoURLBox.Text = "";
                ResourceTitleTextBox.Visibility = Visibility.Hidden;
                VideoPreview.Visibility = Visibility.Hidden;
                ResourceVideoURLBox.Visibility = Visibility.Hidden;
                ResourceTextBox.Visibility = Visibility.Hidden;
                PreviewURLButton.Visibility = Visibility.Hidden;
                ResourcesDialogBox.Visibility = Visibility.Hidden;

                ResourcesLabel.Visibility = Visibility.Visible;
                BackButtonResources.Visibility = Visibility.Visible;
                ShareButton.Visibility = Visibility.Visible;
            }
            else if (resourceType == "Video" && ResourcePath != null)
            {
                ResourcesPhotoControl video = new ResourcesPhotoControl();
                video.TitleLabel.Content = ResourceTitleTextBox.Text;
                video.ResourcePhoto.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(ResourcePath, UriKind.Relative)) };
                ResourcesUniGrid.Children.Insert(0, video);
                ResourceTextBox.Text = "";
                ResourceTitleTextBox.Text = "";
                ResourceVideoURLBox.Text = "";
                ResourceTitleTextBox.Visibility = Visibility.Hidden;
                VideoPreview.Visibility = Visibility.Hidden;
                ResourceVideoURLBox.Visibility = Visibility.Hidden;
                ResourceTextBox.Visibility = Visibility.Hidden;
                PreviewURLButton.Visibility = Visibility.Hidden;
                ResourcesDialogBox.Visibility = Visibility.Hidden;
                ResourcesLabel.Visibility = Visibility.Visible;
                BackButtonResources.Visibility = Visibility.Visible;
                ShareButton.Visibility = Visibility.Visible;
            } else if (resourceType == "Video" && ResourcePath == null)

            {
                System.Windows.MessageBox.Show("No video specified", "Error");
            }
        }

        private void UploadPlanButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dfg = new Microsoft.Win32.OpenFileDialog();
            dfg.Filter = "JPG | *.jpg; PNG | *.png; GIF | *.gif";
            if (dfg.ShowDialog() == true)
            {
                Console.WriteLine(dfg.FileName);
                UploadPhotoPlan.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(dfg.FileName, UriKind.Relative)) };
                PlannerPath = dfg.FileName;
            }
        }
    }
}
