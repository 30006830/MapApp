using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mapApplication.ViewModels
{
    public class LoginDetails : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string email;
        public string Email
        {
            get { return email; }
            set
            { 
                email = value; 
                PropertyChanged(this, new PropertyChangedEventArgs("Email")); 
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set 
            { 
                password = value; 
                PropertyChanged(this, new PropertyChangedEventArgs("Password")); 
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public LoginDetails()
        {
            SubmitCommand = new Command(OnSubmit);
        }            
        public void OnSubmit()
        {
            if (email != "placeholder@gmail.com" || password != "password")
            {
                DisplayInvalidLoginPrompt();               
            }
        }
    }
}
