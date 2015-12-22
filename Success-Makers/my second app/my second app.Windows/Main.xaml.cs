﻿using my_second_app.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using NotificationsExtensions.ToastContent;
using Windows.UI.Notifications;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Data.Xml.Dom;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace my_second_app
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Main : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public Main()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>

        public static int time = 0;
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            DOB_fill obj2 = new DOB_fill();
            obj2.famous();

            quote_fill obj = new quote_fill();
            obj.fun1();
            flipView1.ItemsSource = obj.q;

            


            DateTime x = DateTime.Today;

            int day = x.Day ;
            int month = x.Month;
              

            for (int i = 0; i < obj2.famous_list.Count; i++)
            {

                if (obj2.famous_list[i].day == day && obj2.famous_list[i].month == month && time==0)
                {
                    time++;
                    

                    IToastNotificationContent toastContent = null;
                    IToastImageAndText02 templateContent = ToastContentFactory.CreateToastImageAndText02();

                    templateContent.TextHeading.Text = "Do You Know that ?!";
                    templateContent.TextBodyWrap.Text = "Today is " + obj2.famous_list[i].name+" birthday\n"+ obj2.famous_list[i].job;                    
                    templateContent.Image.Src = obj2.famous_list[i].img;
                    toastContent = templateContent;
                    
                    ToastNotification toast = toastContent.CreateNotification(); 
                    ToastNotificationManager.CreateToastNotifier().Show(toast);
                }


            }

        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        public static int first_selection ;


        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            first_selection = 0;
            this.Frame.Navigate(typeof(Page2));
            

        }

        private void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            first_selection = 1;
            this.Frame.Navigate(typeof(Page2));
            
        }

        private void Image_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            first_selection = 2;
            this.Frame.Navigate(typeof(Page2));
            
        }

        private void Image_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            first_selection = 3;
            this.Frame.Navigate(typeof(Page2));
            
        }

       

        

    }
}
