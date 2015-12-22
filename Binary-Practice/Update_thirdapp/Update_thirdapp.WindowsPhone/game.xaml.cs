using Update_thirdapp.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI;
using Windows.UI.Xaml.Media.Imaging;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Update_thirdapp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class game : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public game()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>



        public void estimate()
        {

            Random rnd = new Random();

            int choice = MainPage.choice;

            switch (choice)
            {

                case 0:
                    result = rnd.Next(0, 10);
                    number.Text = result.ToString();
                    break;

                case 1:
                    result = rnd.Next(11, 50);
                    number.Text = result.ToString();
                    break;

                case 2:
                    result = rnd.Next(51, 255);
                    number.Text = result.ToString();
                    break;

            }


        }

        public int result;

        
        
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {

            estimate();
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Provides data for navigation methods and event
        /// handlers that cannot cancel the navigation request.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion




        public int[] x = { 0, 0, 0, 0, 0, 0, 0, 0 };

        private void seven_Tapped(object sender, TappedRoutedEventArgs e)
        {

            if (x[7] == 0)
            {
                seven.Source = new BitmapImage(new Uri("ms-appx:///Assets/"));
                seven.Source = new BitmapImage(new Uri("ms-appx:///Assets/one.png"));
                x[7] = 1;
                playSound.Play();
            }
            else
            {
                seven.Source = new BitmapImage(new Uri("ms-appx:///Assets/"));
                seven.Source = new BitmapImage(new Uri("ms-appx:///Assets/zero.png"));
                x[7] = 0;
                playSound.Play();
            }


        }

        private void six_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (x[6] == 0)
            {
                six.Source = new BitmapImage(new Uri("ms-appx:///Assets/"));
                six.Source = new BitmapImage(new Uri("ms-appx:///Assets/one.png"));
                x[6] = 1;
                playSound.Play();
            }
            else
            {
                six.Source = new BitmapImage(new Uri("ms-appx:///Assets/"));
                six.Source = new BitmapImage(new Uri("ms-appx:///Assets/zero.png"));
                x[6] = 0;
                playSound.Play();
            }
        }

        private void five_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (x[5] == 0)
            {
                five.Source = new BitmapImage(new Uri("ms-appx:///Assets/"));
                five.Source = new BitmapImage(new Uri("ms-appx:///Assets/one.png"));
                x[5] = 1;
                playSound.Play();
            }
            else
            {
                five.Source = new BitmapImage(new Uri("ms-appx:///Assets/"));
                five.Source = new BitmapImage(new Uri("ms-appx:///Assets/zero.png"));
                x[5] = 0;
                playSound.Play();
            }
        }

        private void four_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (x[4] == 0)
            {
                four.Source = new BitmapImage(new Uri("ms-appx:///Assets/"));
                four.Source = new BitmapImage(new Uri("ms-appx:///Assets/one.png"));
                x[4] = 1;
                playSound.Play();
            }
            else
            {
                four.Source = new BitmapImage(new Uri("ms-appx:///Assets/"));
                four.Source = new BitmapImage(new Uri("ms-appx:///Assets/zero.png"));
                x[4] = 0;
                playSound.Play();
            }
        }

        private void three_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (x[3] == 0)
            {
                three.Source = new BitmapImage(new Uri("ms-appx:///Assets/"));
                three.Source = new BitmapImage(new Uri("ms-appx:///Assets/one.png"));
                x[3] = 1;
                playSound.Play();
            }
            else
            {
                three.Source = new BitmapImage(new Uri("ms-appx:///Assets/"));
                three.Source = new BitmapImage(new Uri("ms-appx:///Assets/zero.png"));
                x[3] = 0;
                playSound.Play();
            }
        }

        private void two_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (x[2] == 0)
            {
                two.Source = new BitmapImage(new Uri("ms-appx:///Assets/"));
                two.Source = new BitmapImage(new Uri("ms-appx:///Assets/one.png"));
                x[2] = 1;
                playSound.Play();
            }
            else
            {
                two.Source = new BitmapImage(new Uri("ms-appx:///Assets/"));
                two.Source = new BitmapImage(new Uri("ms-appx:///Assets/zero.png"));
                x[2] = 0;
                playSound.Play();
            }
        }

        private void one_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (x[1] == 0)
            {
                one.Source = new BitmapImage(new Uri("ms-appx:///Assets/"));
                one.Source = new BitmapImage(new Uri("ms-appx:///Assets/one.png"));
                x[1] = 1;
                playSound.Play();
            }
            else
            {
                one.Source = new BitmapImage(new Uri("ms-appx:///Assets/"));
                one.Source = new BitmapImage(new Uri("ms-appx:///Assets/zero.png"));
                x[1] = 0;
                playSound.Play();
            }
        }

        private void zero_Tapped(object sender, TappedRoutedEventArgs e)
        {

            if (x[0] == 0)
            {
                zero.Source = new BitmapImage(new Uri("ms-appx:///Assets/"));
                zero.Source = new BitmapImage(new Uri("ms-appx:///Assets/one.png"));
                x[0] = 1;
                playSound.Play();
            }
            else
            {
                zero.Source = new BitmapImage(new Uri("ms-appx:///Assets/"));
                zero.Source = new BitmapImage(new Uri("ms-appx:///Assets/zero.png"));
                x[0] = 0;
                playSound.Play();
            }

        }



        public int correct_wrong;

        private void submit_Tapped(object sender, TappedRoutedEventArgs e)
        {
            int sum = 0;

            for (int i = 0; i < 8; i++)
            {

                if (x[i] != 0)
                    sum += (int)Math.Pow(2, i);
            }
            // pageTitle.Text = sum.ToString();

            if (result == sum)
            {

                ok_or_no.Text = "Excellent";
                correct_wrong = 1;
                ok_or_no.Foreground = new SolidColorBrush(Color.FromArgb(255, 111, 210, 153));


                switch (correct_wrong)
                {

                    case 0:
                        make_zeroes();
                        submit.Visibility = Visibility.Visible;
                        again.Visibility = Visibility.Collapsed;
                        ok_or_no.Text = "";
                        break;

                    case 1:

                        make_zeroes();
                        submit.Visibility = Visibility.Visible;
                        again.Visibility = Visibility.Collapsed;


                        estimate();

                        break;
                }


            }
            else
            {


                ok_or_no.Text = "Try again  your submission = " + sum;

                ok_or_no.Foreground = new SolidColorBrush(Colors.Red);
                submit.Visibility = Visibility.Collapsed;
                again.Visibility = Visibility.Visible;

                correct_wrong = 0;

            }


        }

        private void again_Tapped(object sender, TappedRoutedEventArgs e)
        {



            switch (correct_wrong)
            {

                case 0:
                    make_zeroes();
                    submit.Visibility = Visibility.Visible;
                    again.Visibility = Visibility.Collapsed;
                    ok_or_no.Text = "";
                    break;

                case 1:

                    make_zeroes();
                    submit.Visibility = Visibility.Visible;
                    again.Visibility = Visibility.Collapsed;
                    ok_or_no.Text = "";

                    estimate();

                    break;
            }

        }


        public void make_zeroes()
        {


            seven.Source = new BitmapImage(new Uri("ms-appx:///Assets"));
            six.Source = new BitmapImage(new Uri("ms-appx:///Assets"));
            five.Source = new BitmapImage(new Uri("ms-appx:///Assets"));
            four.Source = new BitmapImage(new Uri("ms-appx:///Assets"));
            three.Source = new BitmapImage(new Uri("ms-appx:///Assets"));
            two.Source = new BitmapImage(new Uri("ms-appx:///Assets"));
            one.Source = new BitmapImage(new Uri("ms-appx:///Assets"));
            zero.Source = new BitmapImage(new Uri("ms-appx:///Assets"));


            seven.Source = new BitmapImage(new Uri("ms-appx:///Assets/zero.png"));
            six.Source = new BitmapImage(new Uri("ms-appx:///Assets/zero.png"));
            five.Source = new BitmapImage(new Uri("ms-appx:///Assets/zero.png"));
            four.Source = new BitmapImage(new Uri("ms-appx:///Assets/zero.png"));
            three.Source = new BitmapImage(new Uri("ms-appx:///Assets/zero.png"));
            two.Source = new BitmapImage(new Uri("ms-appx:///Assets/zero.png"));
            one.Source = new BitmapImage(new Uri("ms-appx:///Assets/zero.png"));
            zero.Source = new BitmapImage(new Uri("ms-appx:///Assets/zero.png"));
            for (int i = 0; i < 8; i++)
            {
                x[i] = 0;
            }
        }

    }
}
