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
        }

        private void AddlBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(BeginningDP.Text))
                mes += "Выберите начало даты\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            var a = (DateTime)BeginningDP.SelectedDate;
            var b = (DateTime)EndDP.SelectedDate;
            var qwery = App.context.View_1.
                Where(x => x.DateEvent >= a && x.DateEvent <= b). //
                GroupBy(y => y.Name). //Группируем
                Select(g => new { Группа = g.Key, Оценка = g.Sum(s => s.Mark) }). //Устанавливаем
                OrderByDescending(n => n.Группа); //Сортируем

            JournalDG.ItemsSource = qwery.ToList();
        }
    }
}
