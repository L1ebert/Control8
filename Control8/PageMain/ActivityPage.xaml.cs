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
    /// Логика взаимодействия для ActivityPage.xaml
    /// </summary>
    public partial class ActivityPage : Page
    {
        public ActivityPage()
        {
            InitializeComponent();

            DirectionCmb.SelectedValuePath = "ID";
            DirectionCmb.DisplayMemberPath = "Name";
            DirectionCmb.ItemsSource = App.context.Direction.ToList();
        }

        private void AddActivitylBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NameActiviryTb.Text == "")
            {
                MessageBox.Show("Введите название активности");
            }
            if (DirectionCmb.Text == "")
            {
                MessageBox.Show("Выберите активность");
            }
            Activity addActivity = new Activity
            {
                Name = NameActiviryTb.Text,
                Direction = DirectionCmb.SelectedItem as Direction
            };
            App.context.Activity.Add(addActivity);
            App.context.SaveChanges();
            MessageBox.Show("Активность добавлена");
            NameActiviryTb.Text = "";
            DirectionCmb.Text = "";
        }
    }
}
