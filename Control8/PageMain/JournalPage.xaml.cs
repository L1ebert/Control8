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
    /// Логика взаимодействия для JournalPage.xaml
    /// </summary>
    public partial class JournalPage : Page
    {
        public JournalPage()
        {
            InitializeComponent();
            MarkCmb.SelectedValuePath = "Mark";
            MarkCmb.DisplayMemberPath = "Mark";
            MarkCmb.ItemsSource = App.context.Journal.ToList();
        }

        private void JournalDG_Loaded(object sender, RoutedEventArgs e)
        {
            JournalDG.ItemsSource = App.context.Journal.ToList();
        }

        private void AddlBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(BeginningDP.Text))
                mes += "Выберите начало даты\n";
            if (mes != "")
            if (string.IsNullOrWhiteSpace(MarkCmb.Text))
                mes += "Выберите оценку";
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            var a = (DateTime)BeginningDP.SelectedDate;

            //JournalDG.ItemsSource = App.context.Journal.Where(x => x.DateEvent >= a && x.DateEvent <=).ToList();

            //var summa = App.context.Accounting.Where(x => x.DateEvent >= a && x.DateEvent <= b).Select(g => g.Amount).Sum();
        }
    }
}
