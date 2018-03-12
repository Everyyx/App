using App1.PageElements;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //string appName = Windows.ApplicationModel.Package.Current.DisplayName;
            //AppTitle.Text = appName;
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {   
            if (args.IsSettingsSelected)
            {
                Contentframe.Navigate(typeof(SettingPage));
            }
            else
            {
                NavigationViewItem item = args.SelectedItem as NavigationViewItem;
                switch (item.Tag)
                {
                    case "home":
                        Contentframe.Navigate(typeof(HomePage));
                        NavView.Header = "HomePage";
                        break;
                    case "allapp":
                        Contentframe.Navigate(typeof(AllAppsPage));
                        NavView.Header = "HosePage";
                        break;
                    case "video":
                        Contentframe.Navigate(typeof(CameraPage));
                        NavView.Header = "CameraPage";
                        break;
                    case "camera":
                        Contentframe.Navigate(typeof(PicturePage));
                        NavView.Header = "PicturePage";
                        break;
                    case "picture":
                        Contentframe.Navigate(typeof(VideoPage));
                        NavView.Header = "VideoPage";
                        break;
                }
            }
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            //var loader = new Windows.ApplicationModel.Resources.ResourceLoader();
            //if (args.IsSettingsInvoked)
            //{
            //    Contentframe.Navigate(typeof(SettingPage));
            //}
            //else
            //{
            //    switch (args.InvokedItem)
            //    {
            //        case loader.GetString(""):
            //            Contentframe.Navigate(typeof());
            //            break;
            //        default:
            //            break;
            //    }
            //}
        }

        private void MoreInfoBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
