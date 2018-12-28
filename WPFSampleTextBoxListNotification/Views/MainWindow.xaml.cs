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
    }
}
