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
    /// Логика взаимодействия для AddActivityPage.xaml
    /// </summary>
    public partial class AddActivityPage : Page
    {
        public AddActivityPage()
        {
            InitializeComponent();
            ActivityCmb.SelectedValuePath = "ID";
            ActivityCmb.DisplayMemberPath = "Name";
            ActivityCmb.ItemsSource = App.context.Activity.ToList();

            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();

            DirectionCmb.SelectedValuePath = "ID";
            DirectionCmb.DisplayMemberPath = "Name";
            DirectionCmb.ItemsSource = App.context.Direction.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(ChoiceDP.Text))
                mes += "Выберите дату\n";
            if (string.IsNullOrWhiteSpace(ActivityCmb.Text))
                mes += "Выберите активность\n";
            if (string.IsNullOrWhiteSpace(GroupCmb.Text))
                mes += "Выберите группу\n";
            if (string.IsNullOrWhiteSpace(DirectionCmb.Text))
                mes += "Выберите направление активности\n";
            if (string.IsNullOrWhiteSpace(MarkTb.Text))
                mes += "Введите балл\n";
            if(mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Journal journal = new Journal
            {
                DateEvent = Convert.ToDateTime(ChoiceDP.Text),
                Activity = ActivityCmb.SelectedItem as Activity,
                Group = GroupCmb.SelectedItem as Group,
                Mark = Convert.ToDecimal(MarkTb.Text)
            };
            App.context.Journal.Add(journal);
            App.context.SaveChanges();
            MessageBox.Show("Учет добавлен!");

            ChoiceDP.Text = "";
            GroupCmb.Text = "";
            DirectionCmb.Text = "";
            ActivityCmb.Text = "";
            MarkTb.Text = "";
        }
        private void DirectionCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedDirection = Convert.ToInt32(DirectionCmb.SelectedValue);
            ActivityCmb.ItemsSource = App.context.Activity.Where(a => a.Direction.ID == selectedDirection).ToList();
        }
    }
}
