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

        private async void AppBarButton_Click_2(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store:reviewapp?appid=" + CurrentApp.AppId));
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
    }
}
