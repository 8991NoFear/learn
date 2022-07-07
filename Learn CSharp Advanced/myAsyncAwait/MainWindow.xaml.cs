using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyAsyncAwait
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

        public async void DonwloadHTML(object sender, RoutedEventArgs e)
        {
            //var html = GetHtml();
            var task = GetHtmlAsync();
            MessageBox.Show("Waiting for the task to complete");
            var html = await task;
            MessageBox.Show(html.Substring(0, 16));
        }

        public async Task<string> GetHtmlAsync()
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(@"https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/generate-consume-asynchronous-stream");
            return html;
        }

        public string GetHtml()
        {
            var webClient = new WebClient();
            return webClient.DownloadString(@"https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/generate-consume-asynchronous-stream");
        }
    }
}
