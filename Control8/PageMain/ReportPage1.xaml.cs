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
    /// Логика взаимодействия для ReportPage1.xaml
    /// </summary>
    public partial class ReportPage1 : Page
    {
        public ReportPage1(Group group)
        {
            InitializeComponent();
            JournallDG.ItemsSource = App.context.Journal.Where(x => x.IdGroup == group.ID).ToList();
        }

        private void PrintBtn_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(JournallDG, "Баллы");
            }
        }
    }
}
