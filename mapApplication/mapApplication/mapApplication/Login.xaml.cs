using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using mapApplication.ViewModels;

namespace mapApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            var vm = new LoginDetails();
            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Oops sorry!", "Invalid Login", "Try again", " OK");
            InitializeComponent();
            
            Email.Completed += (object sender, EventArgs e) =>
            {
                Password.Focus();
            };

            Password.Completed += (object sender, EventArgs e) =>
            {
                vm.SubmitCommand.Execute(null);               
            };           
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var passwordCorrect = true;            
            if (passwordCorrect)
            {
                await Navigation.PushAsync(new Home());
            }
        }

        private void CreateAccount_Clicked(object sender, EventArgs e)
        {
              
        }
    }
}