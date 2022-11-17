using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
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

namespace WpfApp {
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e) {
            var endpointurl = ConfigurationManager.AppSettings.Get("endpoint");

            using (var client = new HttpClient()) {
                try {
                    await client.PostAsJsonAsync(endpointurl, new {
                        id = Guid.NewGuid(),
                        source = "wpfapp",
                        message = $"{Environment.MachineName} | {Environment.UserName}"
                    });
                }
                catch { }
            }
        }
    }
}
