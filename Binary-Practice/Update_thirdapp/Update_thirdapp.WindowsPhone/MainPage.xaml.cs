using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Store;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Update_thirdapp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }


        public static int choice;

        private void easy_Tapped(object sender, TappedRoutedEventArgs e)
        {
            choice = 0;
            this.Frame.Navigate(typeof(game));
            b1.Visibility = Visibility.Visible;
            b2.Visibility = Visibility.Visible;
            b3.Visibility = Visibility.Visible;
            b4.Visibility = Visibility.Visible;

            easy.Visibility = Visibility.Collapsed;
            medium.Visibility = Visibility.Collapsed;
            hard.Visibility = Visibility.Collapsed;

        }

        private void medium_Tapped(object sender, TappedRoutedEventArgs e)
        {
            choice = 1;
            this.Frame.Navigate(typeof(game));
            b1.Visibility = Visibility.Visible;
            b2.Visibility = Visibility.Visible;
            b3.Visibility = Visibility.Visible;
            b4.Visibility = Visibility.Visible;

            easy.Visibility = Visibility.Collapsed;
            medium.Visibility = Visibility.Collapsed;
            hard.Visibility = Visibility.Collapsed;

        }

        private void hard_Tapped(object sender, TappedRoutedEventArgs e)
        {
            choice = 2;
            this.Frame.Navigate(typeof(game));
            b1.Visibility = Visibility.Visible;
            b2.Visibility = Visibility.Visible;
            b3.Visibility = Visibility.Visible;
            b4.Visibility = Visibility.Visible;

            easy.Visibility = Visibility.Collapsed;
            medium.Visibility = Visibility.Collapsed;
            hard.Visibility = Visibility.Collapsed;

        }

        private void b1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            b1.Visibility = Visibility.Collapsed;
            b2.Visibility = Visibility.Collapsed;
            b3.Visibility = Visibility.Collapsed;
            b4.Visibility = Visibility.Collapsed;

            easy.Visibility = Visibility.Visible;
            medium.Visibility = Visibility.Visible;
            hard.Visibility = Visibility.Visible;

        }

      

        private void b2_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void b3_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void b4_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(about_page));
        }



    }
}
