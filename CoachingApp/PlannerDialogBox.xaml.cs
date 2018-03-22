using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for PlannerDialogBox.xaml
    /// </summary>
    public partial class PlannerDialogBox : Window
    {
        public PlannerDialogBox(MainWindow Planner)
        {
            InitializeComponent();
            PlannerHandler = Planner;
        }

        private MainWindow PlannerHandler;
        string Path;


        private void UploadPlanPhoto_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dfg = new Microsoft.Win32.OpenFileDialog();
            dfg.Filter = "JPG | *.jpg; PNG | *.png; GIF | *.gif";
            if (dfg.ShowDialog() == true)
            {
                Console.WriteLine(dfg.FileName);
                UploadPhotoPlan.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(dfg.FileName, UriKind.Relative)) };
                Path = dfg.FileName;
            }
        }

        private void AddPlanButton_Click(object sender, RoutedEventArgs e)
        {

            if (Path != null)
            {
                PlannerHandler.Plan2Title.Content = this.TitleTextBox.Text;
                PlannerHandler.Plan2Desc.Content = this.Description_TextBox.Text;
                PlannerHandler.Plan2Title.Visibility = Visibility.Visible;
                PlannerHandler.Plan2Desc.Visibility = Visibility.Visible;
                PlannerHandler.CommentBoxShape2Plan.Visibility = Visibility.Visible;
                PlannerHandler.CommentBox2Plan.Visibility = Visibility.Visible;
                PlannerHandler.CommentButton2Plan.Visibility = Visibility.Visible;
                PlannerHandler.EditButtonPlan2.Visibility = Visibility.Visible;
                PlannerHandler.Plan2Image.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(Path, UriKind.Relative)) };
                PlannerHandler.Plan2Image.Visibility = Visibility.Visible;
                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Error", "Plan requires a photo");
            }

        }
    }
}
