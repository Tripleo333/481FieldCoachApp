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
    /// Interaction logic for MessageElementControl.xaml
    /// </summary>
    public partial class MessageElementControl : UserControl
    {
        public MessageElementControl(MainWindow Message)
        {
            InitializeComponent();
        }

        public MessageElementControl()
        {
        }

        private UserControl Something;

        private void gotoDMButton(object sender, RoutedEventArgs e)
        {
            MainWindow mw = (MainWindow)Window.GetWindow(this);
            mw.DMParentGrid.Visibility = Visibility.Visible;
        }

        private void gotoDMButton(object sender, MouseButtonEventArgs e)
        {
            MainWindow mw = (MainWindow)Window.GetWindow(this);
            mw.DMParentGrid.Visibility = Visibility.Visible;
        }
    }
}
