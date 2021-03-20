using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPF_DependencyInjection.Interface;

namespace WPF_DependencyInjection.Alerts
{
    class InfoAlert : IAlertChooser
    {
        public void ShowAlert()
        {
            MessageBox.Show("Information Alert", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
