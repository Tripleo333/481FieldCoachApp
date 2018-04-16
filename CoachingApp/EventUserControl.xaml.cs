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
    /// Interaction logic for EventUserControl.xaml
    /// </summary>
    public partial class EventUserControl : UserControl
    {
        //globals for each event user control
        String Date = "";
        String Description = "";
        String Title = "";
        String Place = "";
        String Time = "";
        public EventUserControl(String DateI, String DescriptionI, String TitleI, String PlaceI, String TimeI, MainWindow EventDetails)
        {
            InitializeComponent();
            Date = DateI;
            Description = DescriptionI;
            Title = TitleI;
            Place = PlaceI;
            Time = TimeI;
            EventButton.Content = Title;
            DetailsHandler = EventDetails;

        }

        private MainWindow DetailsHandler;

        private void EventButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DetailsHandler.BackgroundGridEvent.Visibility = Visibility.Visible;
            DetailsHandler.EventDetailsGrid.Visibility = Visibility.Visible;
            DetailsHandler.EventTitleLabel.Content = Title;
            DetailsHandler.EventDateLabel.Content = Time;
            DetailsHandler.EventPlaceLabel.Text = Place;
            DetailsHandler.EventDetailsLabel.Content = Description;
            
        }
    }
}
