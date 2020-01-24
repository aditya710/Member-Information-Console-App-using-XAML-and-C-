using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using System.Collections.ObjectModel;
using Club_2020_WinComm.Classes;
using System.Windows.Threading;

namespace Club_2020_WinComm
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ObservableCollection<Member> _members;

        DispatcherTimer timer = new DispatcherTimer();

        private void Application_Startup(object sender, StartupEventArgs e) 
        {
            //Get the needed data

            //_members = GenerateMembers(20);

            _members = MyStorage.ReadXML<ObservableCollection<Member>>("ClubMembers.xml");

            if(_members == null)
            {
                _members = new ObservableCollection<Member>();
            }

            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var mem = GenerateMembers(1);
            _members.Add(mem[0]);
        }

        private ObservableCollection<Member> GenerateMembers(int cnt)
        {
            var obvlist = new ObservableCollection<Member>();

            for (int i = 0; i < cnt; i++)
            {
                obvlist.Add(new Member { firstName = "fn" + i, lastName = "ln" + i, gender = true });
            }

            return obvlist;
        }

        private void Application_Exit(object sender, ExitEventArgs e) 
        {
            MyStorage.WriteXml<ObservableCollection<Member>>(_members, "ClubMembers.xml");
        }
    }
}
