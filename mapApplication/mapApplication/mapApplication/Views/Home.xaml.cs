﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mapApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {        
        public Home()
        {
            InitializeComponent();
        }

        #region Navigation
        private async void HomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
        private async void AccountClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Account());
        }
        private async void MapClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Map());
        }
        private async void NotificationsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Notifications());
        }
        private async void MapImageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Map());
        }
        #endregion       
    }
}