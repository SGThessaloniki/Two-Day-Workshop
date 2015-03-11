﻿using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace NavigationExample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Person p2 = new Person();
            p2.Name = "orfeas";
            p2.Age = 20;

            this.Frame.Navigate(typeof(Page1), p2);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string myPages = String.Empty;
            foreach(var page in Frame.BackStack)
            {
                myPages += page.SourcePageType.ToString() + "\n";
            }

            myTextBlock2.Text = myPages;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
