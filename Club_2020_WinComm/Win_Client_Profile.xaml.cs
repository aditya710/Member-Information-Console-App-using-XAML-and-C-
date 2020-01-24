using Microsoft.Win32;
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
    /// Interaction logic for Win_Client_Profile.xaml
    /// </summary>
    public partial class Win_Client_Profile : Window
    {
        static public Member profile = new Member { firstName = "My Profile" };
        public Win_Client_Profile()
        {
            InitializeComponent();
        }

        private void Elp_AddImage(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.PNG; *.JPG)| *.PNG; *.JPG";
            var result = dlg.ShowDialog();

            if(result == true)
            {
                profile.imagePath = "Images\IMG_20190731_000619.jpg";
                this.DataContext = profile;
            }

        }
    }
}
