using Resevoom.Models;
using Resevoom.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Resevoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Hotel _hotel;
        public App()
        {
            _hotel = new Hotel("TheHotel");
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_hotel)

            };
            MainWindow.Show();  
            base.OnStartup(e);
        }
        //https://github.com/SingletonSean/reservoom
        //https://www.youtube.com/watch?v=DNez3wIpHeE&t=3s

    }
}
