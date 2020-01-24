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

namespace Club_2020_WinComm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Lbx_members.ItemsSource = App._members;

            var win = new W_Client_Profile();
            win.Owner = this;
            win.Top = 50;
            win.Left = 600;
            win.Show();
        }

        private void Tbx_filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            string input = Tbx_filter.Text.ToLower();
            var list = from m in App._members where m.firstName.ToLower().Contains(input) select m;
            Lbx_members.ItemsSource = list;
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            var mem = new Member { firstName = "Please Edit", lastName = "Please Edit", gender = true };
            App._members.Add(mem);

            Lbx_members.SelectedItem = mem;
            Lbx_members.ScrollIntoView(mem);
        }

        private void Btn_Del_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = Lbx_members.SelectedItem;

            if (selectedItem == null)
            {
                MessageBox.Show("Please select item to delete","Error !!");
            }

            else
            {
                App._members.Remove(selectedItem as Member);
            }
        }

    }
}
