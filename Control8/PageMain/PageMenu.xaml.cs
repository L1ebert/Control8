using Control8.Class;
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

namespace Control8.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
        }

        private void HL1_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.AddGroupPage());
        }

        private void HL2_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.ActivityPage());
        }
        private void HL3_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.AddActivityPage());
        }
        private void HL4_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.JournalPage());
        }

        private void P5_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.ReportPage());
        }
    }
}
