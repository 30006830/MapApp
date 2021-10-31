using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mapApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    { 
        public Login()
        {                        
            InitializeComponent();                                   
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if(Email.Text == "placeholder@gmail.com" && Password.Text == "password")
            {
                await Navigation.PushAsync(new Home());
            }
            else
            {
                await DisplayAlert("Incorrect Password", "That was wrong", "OK");
                await Navigation.PushAsync(new Login());
            }
        }

        private async void GuestLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
    }
}