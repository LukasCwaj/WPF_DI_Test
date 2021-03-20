using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_DependencyInjection.Interface;

namespace WPF_DependencyInjection.Model
{
    class AlertChooser
    {
        private readonly IAlertChooser alertChooser;
        public AlertChooser(IAlertChooser alertChooser)
        {
            if (alertChooser == null)
            {
                throw new ArgumentNullException();
            }
            this.alertChooser = alertChooser;
        }
        public void BuildAlert()
        {
            this.alertChooser.ShowAlert();
        }

    }
}
