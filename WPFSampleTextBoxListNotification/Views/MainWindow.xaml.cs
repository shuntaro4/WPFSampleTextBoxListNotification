using System.Windows;

namespace WPFSampleTextBoxListNotification.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new NormalWindow();
            window.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            var window = new PrismWIndow();
            window.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            var window = new ReactivePropertyWindow();
            window.Show();
        }
    }
}
