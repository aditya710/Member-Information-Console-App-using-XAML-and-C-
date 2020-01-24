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
using System.Windows.Shapes;

namespace Club_2020_WinComm
{
    /// <summary>
    /// Interaction logic for Win_Client.xaml
    /// </summary>
    public partial class W_Client_Profile : Window
    {
        public W_Client_Profile()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Lbx_members.ItemsSource = App._members;
        }

        private void Tbx_filter_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Lbx_members_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Tctl_Mobile.SelectedIndex = 1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win1 = new Win_Client_Profile();
            win1.Owner = this;
            win1.Height = Height;
            win1.Width = Width;
            win1.Show();
            Visibility = Visibility.Collapsed;
        }
    }
}
