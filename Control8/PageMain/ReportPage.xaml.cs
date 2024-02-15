using Control8.Class;
using Control8.Model;
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
    /// Логика взаимодействия для ReportPage.xaml
    /// </summary>
    public partial class ReportPage : Page
    {
        public ReportPage()
        {
            InitializeComponent();
            SpecialCmb.SelectedValuePath = "Code";
            SpecialCmb.DisplayMemberPath = "Name";
            SpecialCmb.ItemsSource = App.context.Special.ToList();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            int SelectedS = Convert.ToInt32(SpecialCmb.SelectedValue);

            InfoDG.ItemsSource = App.context.Group.Where(x => x.IdSpecial == SelectedS).ToList();
        }

        private void BallBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.ReportPage1((sender as Button).DataContext as Group));
        }                             
    }
}
