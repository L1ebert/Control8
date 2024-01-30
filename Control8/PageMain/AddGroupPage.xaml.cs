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
    /// Логика взаимодействия для AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : Page
    {
        public AddGroupPage()
        {
            InitializeComponent();

            SpecialCmb.SelectedValuePath = "Code";
            SpecialCmb.DisplayMemberPath = "Name";
            SpecialCmb.ItemsSource = App.context.Special.ToList();
        }

        private void AddGrouplBtn_Click(object sender, RoutedEventArgs e)
        {
            if(NameGroupTb.Text == "")
            {
                MessageBox.Show("Введите наименование группы");
            }
            if(SpecialCmb.Text == "")
            {
                MessageBox.Show("Выберите специальность");
            }
            Group addGroup = new Group
            {
                Name = NameGroupTb.Text,
                Special = SpecialCmb.SelectedItem as Special
            };
            App.context.Group.Add(addGroup);
            App.context.SaveChanges();
            MessageBox.Show("Группа добавлена!");
            NameGroupTb.Text = "";
            SpecialCmb.Text = "";
        }
    }
}
