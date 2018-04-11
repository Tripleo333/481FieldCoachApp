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
    /// Interaction logic for EventUserControl.xaml
    /// </summary>
    public partial class EventUserControl : UserControl
    {
        //globals for each event user control
        String Date = "";
        String Description = "";
        String Title = "";
        String Place = "";
        public EventUserControl(String DateI, String DescriptionI, String TitleI, String PlaceI)
        {
            InitializeComponent();
            Date = DateI;
            Description = DescriptionI;
            Title = TitleI;
            Place = PlaceI;
            EventButton.Content = Title;
        }
    }
}
