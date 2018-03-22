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

        private void EditButton1_Click(object sender, RoutedEventArgs e)
        {
            News1TextBox.Text = News1.Content.ToString();
            Title1TextBox.Text = Title1Label.Content.ToString();
            Title1Label.Visibility = Visibility.Hidden;
            Title1TextBox.Visibility = Visibility.Visible;
            News1TextBox.Visibility = Visibility.Visible;
            EditButton1.Visibility = Visibility.Hidden;
            SaveButton1.Visibility = Visibility.Visible;
        }

        private void SaveButton1_Click(object sender, RoutedEventArgs e)
        {
            News1.Content = News1TextBox.Text;
            Title1Label.Content = Title1TextBox.Text;
            Title1Label.Visibility = Visibility.Visible;
            Title1TextBox.Visibility = Visibility.Hidden;
            News1TextBox.Visibility = Visibility.Hidden;
            EditButton1.Visibility = Visibility.Visible;
            SaveButton1.Visibility = Visibility.Hidden;
        }

        private void EditButton2_Click(object sender, RoutedEventArgs e)
        {
            News2TextBox.Text = News2.Content.ToString();
            Title2TextBox.Text = Title2Label.Content.ToString();
            Title2Label.Visibility = Visibility.Hidden;
            Title2TextBox.Visibility = Visibility.Visible;
            News2TextBox.Visibility = Visibility.Visible;
            EditButton2.Visibility = Visibility.Hidden;
            SaveButton2.Visibility = Visibility.Visible;
        }

        private void SaveButton2_Click(object sender, RoutedEventArgs e)
        {
            News2.Content = News2TextBox.Text;
            Title2Label.Content = Title2TextBox.Text;
            Title2Label.Visibility = Visibility.Visible;
            Title2TextBox.Visibility = Visibility.Hidden;
            News2TextBox.Visibility = Visibility.Hidden;
            EditButton2.Visibility = Visibility.Visible;
            SaveButton2.Visibility = Visibility.Hidden;
        }

        private void CommentButton1_Click(object sender, RoutedEventArgs e)
        {
            Comment1.Content = CommentBox1.Text;
            Comment1.Visibility = Visibility.Visible;
            YourCommentBox1.Visibility = Visibility.Visible;
            News1CommentPic.Visibility = Visibility.Visible;
            Comment1You.Visibility = Visibility.Visible;
        }

        private void CommentButton2_Click(object sender, RoutedEventArgs e)
        {
            Comment2.Content = CommentBox2.Text;
            Comment2.Visibility = Visibility.Visible;
            YourCommentBox2.Visibility = Visibility.Visible;
            News2CommentPic.Visibility = Visibility.Visible;
            Comment2You.Visibility = Visibility.Visible;
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
            EditButton1.Visibility = Visibility.Hidden;
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
            EditButton2.Visibility = Visibility.Hidden;
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
