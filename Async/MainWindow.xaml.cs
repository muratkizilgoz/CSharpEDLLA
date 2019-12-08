using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;

namespace Async
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    /// 
    ///  Synchronous => executed line by line one at a time. => when func called, prog execution wait until the function return
    ///  Asynchronous => when func called, prog execution continues to the next line without waiting for the func to complete.

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DownloadHtml("https://mynet.com");

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            DownloadHtmlAsync("https://mynet.com");
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var html = GetHtml("https://mynet.com");
            MessageBox.Show(html.Substring(1, 1000));
        }

        private async void button2_Click(object sender, RoutedEventArgs e)
        {
            var html = await GetHtmlAsync("https://mynet.com");
            MessageBox.Show("loading");
            MessageBox.Show(html.Substring(1, 1000));
        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"c:\test\sync.html"))
            {
                streamWriter.Write(html);
            }
        }

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            // işlem bitene kadar programı kitlemeye gerek yok
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"c:\test\async.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }


    }
}
