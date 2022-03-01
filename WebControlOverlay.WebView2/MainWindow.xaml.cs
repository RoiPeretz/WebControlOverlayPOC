using System.Windows;

namespace WebControlOverlay.WebView2
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
            webView.NavigateToString("https://www.ynet.co.il/home/");
        }
    }
}
