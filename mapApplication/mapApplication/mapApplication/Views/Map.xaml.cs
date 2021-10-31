using System;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.GoogleMaps;
using System.Reflection;

namespace mapApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Map : ContentPage
    {
        public Map()
        {
            InitializeComponent();
            AddMapStyle();
            
            myMap.MoveToRegion(MapSpan.FromCenterAndRadius(
            new Position(-38.989268, 175.809643), 
            Distance.FromKilometers(2)));               
        }

        void AddMapStyle()
        {
            var assembly = typeof(Map).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream($"mapApplication.MapStyle.json");
            string styleFile;
            using (var reader = new System.IO.StreamReader(stream))
            {
                styleFile = reader.ReadToEnd();
            }

            myMap.MapStyle = MapStyle.FromJson(styleFile);
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
        #endregion
    }
}