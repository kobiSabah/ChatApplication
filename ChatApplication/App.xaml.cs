using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ChatApplication.Core;

namespace ChatApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        ///  Override OnStatUp for dependance injector
        /// </summary>
        /// <param name="e"></param>
        /// 
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IoC.SetUp();
        }
    }
}
