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
    class AttentionAlert : IAlertChooser
    {
        public void ShowAlert()
        {
            MessageBox.Show("AttentionAlert", "Alert", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
