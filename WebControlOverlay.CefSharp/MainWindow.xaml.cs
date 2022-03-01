using System.Windows;
using CefSharp.Wpf;

namespace www
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OverlayButton_OnClick(object sender, RoutedEventArgs e)
        {
            var browserElement = FindName("Browser");
            var browser = browserElement as ChromiumWebBrowser;

            browser.Address = "https://www.ynet.co.il/";
        }
    }
}
