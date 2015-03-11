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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Storage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Save_Btn_Click(object sender, RoutedEventArgs e)
        {
            string dataToBeSaved = Input_TxT.Text;

            localSettings.Values[Constants.MySetting] = dataToBeSaved;

            Output_TxT.Text = "Data saved.";
        }

        private void Load_Btn_Click(object sender, RoutedEventArgs e)
        {
            
            Object loadedData = localSettings.Values[Constants.MySetting];

            if (loadedData != null)
            {
                string output = loadedData.ToString();

                Output_TxT.Text = "Your data was:" + output;
            }

        }

        private void Delete_Btn_Click(object sender, RoutedEventArgs e)
        {
            
            localSettings.Values.Remove(Constants.MySetting);
            

        }
    }
}
