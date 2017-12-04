using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DAHMonitorings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewMonitoringPage : ContentPage
    {
        public NewMonitoringPage()
        {
            InitializeComponent();
            DisplayAlert("Hi", "Welcome to DAH-Monitoring", "Thanks!");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "We handled the click event", "Great!");
        }
    }
}