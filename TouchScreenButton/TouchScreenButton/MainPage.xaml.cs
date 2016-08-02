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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TouchScreenButton
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
        private void button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            int x = Convert.ToInt32(page.ActualWidth);
            int y = Convert.ToInt32(page.ActualHeight);

            Random r = new Random();
            x = r.Next(1, x);
            y = r.Next(1, y);
            button.Margin = new Thickness(x-button.ActualWidth, y-button.ActualHeight, 0, 0);
        }
    }
}
