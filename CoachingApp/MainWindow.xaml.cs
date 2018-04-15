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
        String LoginName, resourceType, PlannerPath, ResourcePath, PhotoPath;
        int day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11;
        int day12, day13, day14, day15, day16, day17, day18, day19, day20, day21;
        int day22, day23, day24, day25, day26, day27, day28, day29, day30, day31;
        int bdayyear = 1994,  matches = 5;
        TeamMemberControl MainUser;
        bool savestate = false;

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
            this.AddEventParentGrid.Visibility = Visibility.Hidden;


        }

        private void Login(object sender, RoutedEventArgs e)
        {
            if (this.EmailTextBox.Text == "simkrai" && PasswordLogin.Password.ToString() == "fieldhockey")
            {
                //                this.EmailTextBox.Visibility = Visibility.Hidden;
                this.LoginGrid.Visibility = Visibility.Hidden;
                this.CoachMainPageGrid.Visibility = Visibility.Visible;
                LoginName = EmailTextBox.Text;
                TeamMemberControl tmc = new TeamMemberControl(this, "Sarah Graham", "2/4/1999", "(587)321-1247","sarahgraham1@gmail.com","I love trying out new sports!",4,4,2,3,"Needs assistance with positioning", 0, "");
                PlayersUniGrid.Children.Add(tmc);


                MainUser = new TeamMemberControl(this, NameInput.Content.ToString(), BirthdayInput.Content.ToString(), PhoneInput.Content.ToString(), EmailInput.Content.ToString(), BiographyInput.Content.ToString(), 0, 0, 0, 0, "", 3,"");
                CoachesUniGrid.Children.Add(MainUser);

                TeamMemberControl coach1 = new TeamMemberControl(this, "Jess Weissman", "18/11/1987", "(403)553-2135", "jweiss@outlook.ca", "Taught as a junior coach for 2 years and decided to take my passion to the next step!", 0, 0, 0, 0, "", 1, "");
                TeamMemberControl coach2 = new TeamMemberControl(this, "Peter Buchelli", "18/11/1986", "(403)122-6523", "gmagnet@gmail.com", "I love what I do, and I do what I love.", 0, 0, 0, 0, "", 1, "");
                CoachesUniGrid.Children.Add(coach1);
                CoachesUniGrid.Children.Add(coach2);
            }
            else
            {
                CredentialsErrorGrid.Visibility = Visibility.Visible;
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
            NewsfeedScrollView.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NewsfeedGrid.Visibility = Visibility.Hidden;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            savestate = true;
            NameTextBox.Text = NameInput.Content.ToString();
            NameTextBox.Visibility = Visibility.Visible;
            NameInput.Visibility = Visibility.Hidden;

            PhoneTextBox.Text = PhoneInput.Content.ToString();
            PhoneTextBox.Visibility = Visibility.Visible;
            PhoneInput.Visibility = Visibility.Hidden;

            EmailTextBox1.Text = EmailInput.Content.ToString();
            EmailTextBox1.Visibility = Visibility.Visible;
            EmailInput.Visibility = Visibility.Hidden;

            BiographyTextBox.Text = BiographyInput.Content.ToString();
            BiographyTextBox.Visibility = Visibility.Visible;
            BiographyInput.Visibility = Visibility.Hidden;

            BirthdayInput.Visibility = Visibility.Hidden;

            string bday = BirthdayInput.Content.ToString();
            int count = 0;
            for(int i = 0; i < bday.Length; i++)
            {
                if (count == 0)
                {
                    if (bday[i] != '/')
                    {
                        BdayDayTextBox.Text += bday[i].ToString();
                    }
                    else
                    {
                        count++;
                    }
                }

                else if (count == 1)
                {
                    if (bday[i] != '/')
                    {
                        BdayMonthTextBox.Text += bday[i].ToString();
                    }
                    else
                    {
                        count++;
                    }
                }

                else if (count == 2)
                {
                    if (bday[i] != '/')
                    {
                        BdayYearTextBox.Text += bday[i].ToString();
                    }
                    else
                    {
                        count++;
                    }
                }
            }
                
            BdayDayTextBox.Visibility = Visibility.Visible;
            BdayMonthTextBox.Visibility = Visibility.Visible;
            BdayYearTextBox.Visibility = Visibility.Visible;

            EditButton.Visibility = Visibility.Hidden;
            SaveButton.Visibility = Visibility.Visible;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            savestate = false;
            NameInput.Content = NameTextBox.Text;
            NameTextBox.Visibility = Visibility.Hidden;
            NameInput.Visibility = Visibility.Visible;

            PhoneInput.Content = PhoneTextBox.Text;
            PhoneTextBox.Visibility = Visibility.Hidden;
            PhoneInput.Visibility = Visibility.Visible;

            EmailInput.Content = EmailTextBox1.Text;
            EmailTextBox1.Visibility = Visibility.Hidden;
            EmailInput.Visibility = Visibility.Visible;

            BiographyInput.Content = BiographyTextBox.Text;
            BiographyTextBox.Visibility = Visibility.Hidden;
            BiographyInput.Visibility = Visibility.Visible;

            BirthdayInput.Visibility = Visibility.Visible;
            BirthdayInput.Content = BdayDayTextBox.Text + '/' + BdayMonthTextBox.Text + '/' + BdayYearTextBox.Text;
            BdayDayTextBox.Visibility = Visibility.Hidden;
            BdayMonthTextBox.Visibility = Visibility.Hidden;
            BdayYearTextBox.Visibility = Visibility.Hidden;
            bdayyear = int.Parse(BdayYearTextBox.Text);
            BdayDayTextBox.Text = "";
            BdayMonthTextBox.Text = "";
            BdayYearTextBox.Text = "";

            EditButton.Visibility = Visibility.Visible;
            SaveButton.Visibility = Visibility.Hidden;
        }

        private void BackButtonProfile_Click(object sender, RoutedEventArgs e)
        {
            if (savestate == false)
            {
                MyProfileGrid.Visibility = Visibility.Hidden;
            } else if (savestate == true)
            {
                ConfirmationBox.Visibility = Visibility.Visible;
                ProfileDimGrid.Visibility = Visibility.Visible;
            }
                
        }

        private void UploadProfPhoto_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dfg = new Microsoft.Win32.OpenFileDialog();
            dfg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dfg.ShowDialog() == true)
            {
                Console.WriteLine(dfg.FileName);
                //ProfilePhoto.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(dfg.FileName, UriKind.Relative)) };
                CoachImage.Source = new BitmapImage(new Uri(dfg.FileName));
                CoachImage.Stretch = Stretch.UniformToFill;
                ProfilePhotoCoach.Source = new BitmapImage(new Uri(dfg.FileName));
                ProfilePhotoCoach.Stretch = Stretch.UniformToFill;
                MainUser.personImage.Source = new BitmapImage(new Uri(dfg.FileName));
                MainUser.personImage.Stretch = Stretch.UniformToFill;
                PhotoPath = dfg.FileName;
            }

        }

        public string getpath()
        {
            return PhotoPath;
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
            PlannerScrollView.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
        }

        private void ShareButton_Click(object sender, RoutedEventArgs e)
        {
            ResourcesDialogBox.Visibility = Visibility.Visible;
            ResourcesLabel.Visibility = Visibility.Hidden;
            ShareButton.Visibility = Visibility.Hidden;
            BackButtonResources.Visibility = Visibility.Hidden;
            ResourcesScrollView.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
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

        private void BackButtonStats_Click(object sender, RoutedEventArgs e)
        {
            TeamStatsGrid.Visibility = Visibility.Hidden;
        }

        private void menuItemButton8_Click(object sender, RoutedEventArgs e)
        {
            TeamStatsGrid.Visibility = Visibility.Visible;
        }

        private void AddStatsButton_Click(object sender, RoutedEventArgs e)
        {
            StatsDialogBox.Visibility = Visibility.Visible;
            CancelStats.Visibility = Visibility.Visible;
            AddStatsButton.Visibility = Visibility.Hidden;
            SaveStats.Visibility = Visibility.Visible;

        }

        private void menuItemButton4_Click(object sender, RoutedEventArgs e)
        {
            MyTeamGrid.Visibility = Visibility.Visible;
        }

        private void AddMemberClose_Click(object sender, RoutedEventArgs e)
        {
            BackgroundGrid.Visibility = Visibility.Hidden;
            AddMemberGrid.Visibility = Visibility.Hidden;
            MemberName.Text = "";
            MemberEmail.Text = "";
            CoachOrPlayer.Value = 0;

        }

        private void SendRefLink_Click(object sender, RoutedEventArgs e)
        {
            BackgroundGrid.Visibility = Visibility.Hidden;
            AddMemberGrid.Visibility = Visibility.Hidden;

            
            TeamMemberControl tmc = new TeamMemberControl(this, MemberName.Text, "", "", MemberEmail.Text, "", 0,0,0,0,"",CoachOrPlayer.Value, "");
            tmc.personName.Text = MemberName.Text;
            if (CoachOrPlayer.Value == 0)
            {
                PlayersUniGrid.Children.Add(tmc);
            } else
            {
                CoachesUniGrid.Children.Add(tmc);
            }
            tmc.TeamHandler.
            MemberName.Text = "";
            MemberEmail.Text = "";
            CoachOrPlayer.Value = 0;
        }

        private void AddMemberButton_Click(object sender, RoutedEventArgs e)
        {
            AddMemberGrid.Visibility = Visibility.Visible;
            BackgroundGrid.Visibility = Visibility.Visible;
        }

        private void YesConfirm_Click(object sender, RoutedEventArgs e)
        {
            savestate = false;
            NameInput.Content = NameTextBox.Text;
            NameTextBox.Visibility = Visibility.Hidden;
            NameInput.Visibility = Visibility.Visible;

            PhoneInput.Content = PhoneTextBox.Text;
            PhoneTextBox.Visibility = Visibility.Hidden;
            PhoneInput.Visibility = Visibility.Visible;

            EmailInput.Content = EmailTextBox1.Text;
            EmailTextBox1.Visibility = Visibility.Hidden;
            EmailInput.Visibility = Visibility.Visible;

            BiographyInput.Content = BiographyTextBox.Text;
            BiographyTextBox.Visibility = Visibility.Hidden;
            BiographyInput.Visibility = Visibility.Visible;

            BirthdayInput.Visibility = Visibility.Visible;
            BirthdayInput.Content = BdayDayTextBox.Text + '/' + BdayMonthTextBox.Text + '/' + BdayYearTextBox.Text;
            BdayDayTextBox.Visibility = Visibility.Hidden;
            BdayMonthTextBox.Visibility = Visibility.Hidden;
            BdayYearTextBox.Visibility = Visibility.Hidden;
            bdayyear = int.Parse(BdayYearTextBox.Text);
            BdayDayTextBox.Text = "";
            BdayMonthTextBox.Text = "";
            BdayYearTextBox.Text = "";

            EditButton.Visibility = Visibility.Visible;
            SaveButton.Visibility = Visibility.Hidden;
            ConfirmationBox.Visibility = Visibility.Hidden;
            ProfileDimGrid.Visibility = Visibility.Hidden;
            MyProfileGrid.Visibility = Visibility.Hidden;
        }

        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void gotoSuzieDMs(object sender, RoutedEventArgs e)
        {
            this.DMParentGrid.Visibility = Visibility.Visible;
        }

        private void NoConfirm_Click(object sender, RoutedEventArgs e)
        {
            savestate = false;
            NameTextBox.Visibility = Visibility.Hidden;
            NameInput.Visibility = Visibility.Visible;

            PhoneTextBox.Visibility = Visibility.Hidden;
            PhoneInput.Visibility = Visibility.Visible;

            EmailTextBox1.Visibility = Visibility.Hidden;
            EmailInput.Visibility = Visibility.Visible;

            BiographyTextBox.Visibility = Visibility.Hidden;
            BiographyInput.Visibility = Visibility.Visible;

            BirthdayInput.Visibility = Visibility.Visible;
            BdayDayTextBox.Visibility = Visibility.Hidden;
            BdayMonthTextBox.Visibility = Visibility.Hidden;
            BdayYearTextBox.Visibility = Visibility.Hidden;

            EditButton.Visibility = Visibility.Visible;
            SaveButton.Visibility = Visibility.Hidden;

            ConfirmationBox.Visibility = Visibility.Hidden;
            ProfileDimGrid.Visibility = Visibility.Hidden;
            MyProfileGrid.Visibility = Visibility.Hidden;
        }

        private void CancelStats_Click(object sender, RoutedEventArgs e)
        {
            StatsDialogBox.Visibility = Visibility.Hidden;
            CancelStats.Visibility = Visibility.Hidden;
            AddStatsButton.Visibility = Visibility.Visible;
            SaveStats.Visibility = Visibility.Hidden;
            TeamNameTextBox.Text = "Team Name";
            HomeScoreTextBox.Text = "";
            VisitorScoreTextBox.Text = "";
        }

        private void SaveStats_Click(object sender, RoutedEventArgs e)
        {
            MatchStatsControl control = new MatchStatsControl(this);
            control.Opponent.Text = TeamNameTextBox.Text;
            control.OpponentScore.Text = VisitorScoreTextBox.Text;
            control.HomeScore.Text = HomeScoreTextBox.Text;

            MatchStatsUniGrid.Children.Add(control);
            StatsDialogBox.Visibility = Visibility.Hidden;
            CancelStats.Visibility = Visibility.Hidden;
            AddStatsButton.Visibility = Visibility.Visible;
            SaveStats.Visibility = Visibility.Hidden;
            TeamNameTextBox.Text = "Team Name";
            HomeScoreTextBox.Text = "";
            VisitorScoreTextBox.Text = "";
        }

        private void EditGoals_Click(object sender, RoutedEventArgs e)
        {
            GoalsAmountLabel.Visibility = Visibility.Hidden;
            GoalsTextBox.Text = GoalsAmountLabel.Content.ToString();
            GoalsTextBox.Visibility = Visibility.Visible;
            EditGoals.Visibility = Visibility.Hidden;
            SaveGoals.Visibility = Visibility.Visible;
        }

        private void EditWins_Click(object sender, RoutedEventArgs e)
        {
            WinsAmountLabel.Visibility = Visibility.Hidden;
            WinsTextBox.Text = WinsAmountLabel.Content.ToString();
            WinsTextBox.Visibility = Visibility.Visible;
            EditWins.Visibility = Visibility.Hidden;
            SaveWins.Visibility = Visibility.Visible;
        }

        private void SaveWins_Click(object sender, RoutedEventArgs e)
        {
            WinsAmountLabel.Visibility = Visibility.Visible;
            WinsAmountLabel.Content = WinsTextBox.Text;
            WinsTextBox.Visibility = Visibility.Hidden;
            EditWins.Visibility = Visibility.Visible;
            SaveWins.Visibility = Visibility.Hidden;

            matches = int.Parse(WinsTextBox.Text) + int.Parse(LossAmountLabel.Content.ToString()) + int.Parse(DrawsAmountLabel.Content.ToString());
            PlayedAmount.Content = matches;
        }

        private void EditLosses_Click(object sender, RoutedEventArgs e)
        {
            LossAmountLabel.Visibility = Visibility.Hidden;
            LossesTextBox.Text = LossAmountLabel.Content.ToString();
            LossesTextBox.Visibility = Visibility.Visible;
            EditLosses.Visibility = Visibility.Hidden;
            SaveLoss.Visibility = Visibility.Visible;
        }

        private void SaveLoss_Click(object sender, RoutedEventArgs e)
        {
            LossAmountLabel.Visibility = Visibility.Visible;
            LossAmountLabel.Content = LossesTextBox.Text;
            LossesTextBox.Visibility = Visibility.Hidden;
            EditLosses.Visibility = Visibility.Visible;
            SaveLoss.Visibility = Visibility.Hidden;

            matches = int.Parse(WinsAmountLabel.Content.ToString()) + int.Parse(LossesTextBox.Text) + int.Parse(DrawsAmountLabel.Content.ToString());
            PlayedAmount.Content = matches;
        }

        private void EditDraws_Click(object sender, RoutedEventArgs e)
        {
            DrawsAmountLabel.Visibility = Visibility.Hidden;
            DrawsTextBox.Text = DrawsAmountLabel.Content.ToString();
            DrawsTextBox.Visibility = Visibility.Visible;
            EditDraws.Visibility = Visibility.Hidden;
            SaveDraws.Visibility = Visibility.Visible;
        }

        private void SaveDraws_Click(object sender, RoutedEventArgs e)
        {
            DrawsAmountLabel.Visibility = Visibility.Visible;
            DrawsAmountLabel.Content = DrawsTextBox.Text;
            DrawsTextBox.Visibility = Visibility.Hidden;
            EditDraws.Visibility = Visibility.Visible;
            SaveDraws.Visibility = Visibility.Hidden;

            matches = int.Parse(WinsAmountLabel.Content.ToString()) + int.Parse(LossAmountLabel.Content.ToString()) + int.Parse(DrawsTextBox.Text);
            PlayedAmount.Content = matches;
        }

        private void SaveGoals_Click(object sender, RoutedEventArgs e)
        {
            GoalsAmountLabel.Visibility = Visibility.Visible;
            GoalsAmountLabel.Content = GoalsTextBox.Text;
            GoalsTextBox.Visibility = Visibility.Hidden;
            EditGoals.Visibility = Visibility.Visible;
            SaveGoals.Visibility = Visibility.Hidden;
        }

        private void startDM(object sender, RoutedEventArgs e)
        {
            this.DMParentGrid.Visibility = Visibility.Visible;
          //  this.DMNotification.Visibility = Visibility.Hidden;
        }

        private void CreateAccountBack_Click(object sender, RoutedEventArgs e)
        {
            CreateAccountGrid.Visibility = Visibility.Hidden;
            BdayDayCA.Text = "DD";
            BdayMonthCA.Text = "MM";
            BdayYearCA.Text = "YYYY";

        }

        private void CreateGroupChat(object sender, RoutedEventArgs e)
        {
            this.ChooseGroupChatGrid.Visibility = Visibility.Hidden;
            //            this.DMParentGrid.Visibility = Visibility.Visible;
            if (suzieCheckBox.IsChecked == true)
            {
                MessageElement.Visibility = Visibility.Visible;
            }
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
            ResourceTextBox.Text = "Enter Text";
            ResourceTitleTextBox.Text = "Enter Title";
            ResourceVideoURLBox.Text = "Enter URL";
            ShareButton.Visibility = Visibility.Visible;
            ResourcesLabel.Visibility = Visibility.Visible;
            BackButtonResources.Visibility = Visibility.Visible;

            ResourceTitleTextBox.Visibility = Visibility.Hidden;
            VideoPreview.Visibility = Visibility.Hidden;
            ResourceVideoURLBox.Visibility = Visibility.Hidden;
            ResourceTextBox.Visibility = Visibility.Hidden;
            PreviewURLButton.Visibility = Visibility.Hidden;

            TextResourceButton.Background = Brushes.LightGray;
            VideoResourceButton.Background = Brushes.LightGray;
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
            TextResourceButton.Background = Brushes.Gray;
            VideoResourceButton.Background = Brushes.LightGray;
        }

        private void PreviewURLButton_Click(object sender, RoutedEventArgs e)
        {
            // TEMPORARY
            Microsoft.Win32.OpenFileDialog dfg = new Microsoft.Win32.OpenFileDialog();
            dfg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dfg.ShowDialog() == true)
            {
                Console.WriteLine(dfg.FileName);
                VideoPreview.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(dfg.FileName, UriKind.Relative)) };
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
            EventDateInput.Text = "DD/MM/YY";
            NewEventPlaceBox.Text = "";
            NewEventTitleBox.Text = "";
            NewEventDetailsBox.Text = "";
            EventTimeInputBox.Text = "";
        }

        private void AddNewCalendarEvent_Click(object sender, RoutedEventArgs e)
        {
            this.AddEventParentGrid.Visibility = Visibility.Visible;
        }

        private void AddEventClick(object sender, RoutedEventArgs e)
        {

            string date, day = "";
            date = EventDateInput.Text;
            for (int i = 0; date[i] != '/';)
            {
                day += date[i];
                if (date[i + 1] != '/')
                {
                    day += date[i + 1];
                    break;
                }
                else
                {
                    break;
                }
            }

            if (day != "DD" && day.Length < 3)
            {
                int daynum = int.Parse(day);
                if (daynum > 31 || daynum < 1)
                {
                    System.Windows.MessageBox.Show("Invalid Date", "Error");
                }
                else if(daynum == 1)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day1++;
                    if (day1 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    } else
                    {
                        EventsUniformGridDay1.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 2)
                {
                    EventUserControl EUC3 = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day2++;
                    if (day2 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay2.Children.Add(EUC3);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 3)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day3++;
                    if (day3 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay3.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 4)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day4++;
                    if (day4 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay4.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 5)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day5++;
                    if (day5 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay5.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 6)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day6++;
                    if (day6 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay6.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 7)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day7++;
                    if (day7 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay7.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 8)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day8++;
                    if (day8 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay8.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 9)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day9++;
                    if (day9 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay9.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 10)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day10++;
                    if (day10 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay10.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 11)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day11++;
                    if (day11 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay11.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 12)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day12++;
                    if (day12 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay12.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 13)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day13++;
                    if (day13 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay13.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 14)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day14++;
                    if (day14 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay14.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 15)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day15++;
                    if (day15 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay15.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 16)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day16++;
                    if (day16 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay16.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 17)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day17++;
                    if (day17 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay17.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 18)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day18++;
                    if (day18 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay18.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 19)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day19++;
                    if (day19 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay19.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 20)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day20++;
                    if (day20 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay20.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 21)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day21++;
                    if (day21 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay21.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 22)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day22++;
                    if (day22 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay22.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 23)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day23++;
                    if (day23 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay23.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 24)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day24++;
                    if (day24 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay24.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 25)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day25++;
                    if (day25 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay25.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 26)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day26++;
                    if (day26 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay26.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 27)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day27++;
                    if (day27 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay27.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 28)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day28++;
                    if (day28 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay28.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 29)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day29++;
                    if (day29 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay29.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 30)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day30++;
                    if (day30 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay30.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
                else if (daynum == 31)
                {
                    EventUserControl EUC = new EventUserControl(EventDateInput.Text, NewEventPlaceBox.Text, NewEventTitleBox.Text, NewEventDetailsBox.Text, EventTimeInputBox.Text, this);
                    day31++;
                    if (day31 > 3)
                    {
                        System.Windows.MessageBox.Show("Event Limit Reached!", "Mental Health System");
                    }
                    else
                    {
                        EventsUniformGridDay31.Children.Add(EUC);
                        this.AddEventParentGrid.Visibility = Visibility.Hidden;
                        EventDateInput.Text = "DD/MM/YY";
                        NewEventPlaceBox.Text = "";
                        NewEventTitleBox.Text = "";
                        NewEventDetailsBox.Text = "";
                        EventTimeInputBox.Text = "";
                    }
                }
            } else
            {
                System.Windows.MessageBox.Show("Invalid Date", "Error");
            }

        }

        private void EventDetailsClose_Click(object sender, RoutedEventArgs e)
        {
            EventDetailsGrid.Visibility = Visibility.Hidden;
            BackgroundDimEvent.Visibility = Visibility.Hidden;
        }

        private void VideoResourceButton_Click(object sender, RoutedEventArgs e)
        {
            ResourceTitleTextBox.Visibility = Visibility.Visible;
            VideoPreview.Visibility = Visibility.Visible;
            ResourceVideoURLBox.Visibility = Visibility.Visible;
            ResourceTextBox.Visibility = Visibility.Hidden;
            PreviewURLButton.Visibility = Visibility.Visible;
            ShareResourceButton.IsEnabled = true;
            resourceType = "Video";
            TextResourceButton.Background = Brushes.LightGray;
            VideoResourceButton.Background = Brushes.Gray;
        }

        private void ShareResourceButton_Click(object sender, RoutedEventArgs e)
        {
            if (resourceType == "Text")
            {
                NewsPageControl text = new NewsPageControl();
                text.TitleLabel.Content = ResourceTitleTextBox.Text;
                text.NewsTextBlock.Text = ResourceTextBox.Text;
                ResourcesUniGrid.Children.Insert(0, text);
                ResourceTextBox.Text = "Enter Text";
                ResourceTitleTextBox.Text = "Enter Title";
                ResourceVideoURLBox.Text = "Enter URL";
                ResourceTitleTextBox.Visibility = Visibility.Hidden;
                VideoPreview.Visibility = Visibility.Hidden;
                ResourceVideoURLBox.Visibility = Visibility.Hidden;
                ResourceTextBox.Visibility = Visibility.Hidden;
                PreviewURLButton.Visibility = Visibility.Hidden;
                ResourcesDialogBox.Visibility = Visibility.Hidden;

                ResourcesLabel.Visibility = Visibility.Visible;
                BackButtonResources.Visibility = Visibility.Visible;
                ShareButton.Visibility = Visibility.Visible;
                TextResourceButton.Background = Brushes.LightGray;
                VideoResourceButton.Background = Brushes.LightGray;
            }
            else if (resourceType == "Video" && ResourcePath != null)
            {
                ResourcesPhotoControl video = new ResourcesPhotoControl();
                video.TitleLabel.Content = ResourceTitleTextBox.Text;
                video.ResourcePhoto.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(ResourcePath, UriKind.Relative)) };
                ResourcesUniGrid.Children.Insert(0, video);
                ResourceTextBox.Text = "Enter Text";
                ResourceTitleTextBox.Text = "Enter Title";
                ResourceVideoURLBox.Text = "Enter URL";
                ResourceTitleTextBox.Visibility = Visibility.Hidden;
                VideoPreview.Visibility = Visibility.Hidden;
                ResourceVideoURLBox.Visibility = Visibility.Hidden;
                ResourceTextBox.Visibility = Visibility.Hidden;
                PreviewURLButton.Visibility = Visibility.Hidden;
                ResourcesDialogBox.Visibility = Visibility.Hidden;
                ResourcesLabel.Visibility = Visibility.Visible;
                BackButtonResources.Visibility = Visibility.Visible;
                ShareButton.Visibility = Visibility.Visible;
                TextResourceButton.Background = Brushes.LightGray;
                VideoResourceButton.Background = Brushes.LightGray;
            } else if (resourceType == "Video" && ResourcePath == null)

            {
                System.Windows.MessageBox.Show("No video specified", "Error");
            }
        }

        private void UploadPlanButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dfg = new Microsoft.Win32.OpenFileDialog();
            dfg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dfg.ShowDialog() == true)
            {
                Console.WriteLine(dfg.FileName);
                UploadPhotoPlan.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(dfg.FileName, UriKind.Relative)) };
                PlannerPath = dfg.FileName;
            }
        }
    }
}
