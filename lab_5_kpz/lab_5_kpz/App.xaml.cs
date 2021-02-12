using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DataModel.DataModels;

namespace lab_5_kpz
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        DataModel.DataModels.DataModel _model;
        public App()
        {
            _model = DataModel.DataModels.DataModel.Load();
            var window = new MainWindow() { DataContext = _model };
            window.Show();
        }
    }
}
