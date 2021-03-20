using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_DependencyInjection.Command;
using WPF_DependencyInjection.Interface;
using WPF_DependencyInjection.Alerts;
using WPF_DependencyInjection.Model;

namespace WPF_DependencyInjection.ViewModel
{
    class AlertChooserViewModel
    {
        private ICommand _AttentionAlert;
        public ICommand AttentionAlert
        {
            get
            {
                if (_AttentionAlert == null)
                {
                    _AttentionAlert = new RelayCommand(AttentionAlertExecute);
                }
                return _AttentionAlert;
            }
        }

        private void AttentionAlertExecute(object parameter)
        {
            IAlertChooser alert = new AttentionAlert();
            var alertChooser = new AlertChooser(alert);
            alertChooser.BuildAlert();
        }

        private ICommand _InfoAlert;
        public ICommand InfoAlert
        {
            get
            {
                if (_InfoAlert == null)
                {
                    _InfoAlert = new RelayCommand(InfoAlertExecute);
                }
                return _InfoAlert;
            }
        }

        private void InfoAlertExecute(object parameter)
        {
            IAlertChooser alert = new InfoAlert();
            var alertChooser = new AlertChooser(alert);
            alertChooser.BuildAlert();
        }
    }
}
