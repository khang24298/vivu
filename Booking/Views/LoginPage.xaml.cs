using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Booking.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void forgotpass_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ForgotPage());
        }

        void signup_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SignupPage());
        }

        void login_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        void home_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}