using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        void GestureSwipeNavigation_Swiped(object sender, SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Left:
                    //Handle the direction of the swipe
                    break;
                case SwipeDirection.Right:
                    //Handle the direction of the swipe
                    break;
            }
        }

        public class SwipeContainer : ContentView
        {
            public event EventHandler<SwipedEventArgs> Swipe;

            public SwipeContainer()
            {
                GestureRecognizers.Add(GetSwipeGestureRecognizer(SwipeDirection.Left));
                GestureRecognizers.Add(GetSwipeGestureRecognizer(SwipeDirection.Right));
            }

            SwipeGestureRecognizer GetSwipeGestureRecognizer(SwipeDirection direction)
            {
                var swipe = new SwipeGestureRecognizer { Direction = direction };
                swipe.Swiped += (sender, e) => Swipe?.Invoke(this, e);
                return swipe;
            }
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Account());
        }
    }
}