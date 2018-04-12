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
    /// Interaction logic for MatchStatsControl.xaml
    /// </summary>
    public partial class MatchStatsControl : UserControl
    {
        public MatchStatsControl(MainWindow StatsHandler)
        {
            InitializeComponent();

            int oppscore = int.Parse(StatsHandler.VisitorScoreTextBox.Text);
            int homescore = int.Parse(StatsHandler.HomeScoreTextBox.Text);

            if(oppscore > homescore)
            {
                Loss.Visibility = Visibility.Visible;
            } else if (oppscore < homescore)
            {
                Win.Visibility = Visibility.Visible;
            } else if (oppscore == homescore)
            {
                Draw.Visibility = Visibility.Visible;
            }
        }
    }
}
