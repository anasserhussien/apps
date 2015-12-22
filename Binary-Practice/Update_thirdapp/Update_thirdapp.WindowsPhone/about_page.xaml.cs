﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.ApplicationModel.Email;
using Windows.ApplicationModel.Store;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Update_thirdapp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class about_page : Page
    {
        public about_page()
        {
            this.InitializeComponent();
            // logoAnim storybord start
            LogoAnim.Begin();
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            if (frame == null)
            {
                return;
            }

            if (frame.CanGoBack)
            {
                frame.GoBack();
                e.Handled = true;
            }
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        //application rate and review
        private async void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store:reviewapp?appid=" + CurrentApp.AppId));
        }


        //application share 
        private void ShareSourceLoad()
        {
            DataTransferManager dataTransferManager = DataTransferManager.GetForCurrentView();
            dataTransferManager.DataRequested += new TypedEventHandler<DataTransferManager, DataRequestedEventArgs>(this.DataRequested);
        }

        private void DataRequested(DataTransferManager sender, DataRequestedEventArgs e)
        {
            DataRequest request = e.Request;
            request.Data.Properties.Title = "Binary Practice This is funny app helps new people studying binary system to practice converting from decimal to binary through simple game and soon i'm going to open closed subgames Enjoy ! :)";
            request.Data.Properties.Description = "This is funny app helps new people studying binary system to practice converting from decimal to binary through simple game and soon i'm going to open closed subgames Enjoy ! :)";
            request.Data.SetText(" Binary Practice This is funny app helps new people studying binary system to practice converting from decimal to binary through simple game and soon i'm going to open closed subgames Enjoy ! :) ");
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            Windows.ApplicationModel.DataTransfer.DataTransferManager.ShowShareUI();
            ShareSourceLoad();
        }



        //app feedback
  





        private async void AppBarButton_Click_2(object sender, RoutedEventArgs e)
        {




            EmailRecipient sendTo = new EmailRecipient()
            {
                Name = "anasserhussien@fcih1.com",
                Address = "anasserhussien@fcih1.com",
            };

            // Create email object
            EmailMessage mail = new EmailMessage();
            mail.To.Add(sendTo);
            mail.Subject = "Binary Practice";
            mail.Body = "";


            // Open the share contract with Mail only:
            await EmailManager.ShowComposeNewEmailAsync(mail);
        }

       
        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var uri = new Uri("https://www.facebook.com/EGAppFactory");
            IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            var uri = new Uri("https://twitter.com/EGAppFactory");
            IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private void TextBlock_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            var uri = new Uri("https://www.facebook.com/EGAppFactory");
            IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
        }
        private void TextBlock_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            var uri = new Uri("https://twitter.com/EGAppFactory");
            IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
        }
    }
}