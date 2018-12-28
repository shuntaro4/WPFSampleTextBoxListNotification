using System.Windows;
using WPFSampleTextBoxListNotification.ViewModels;

namespace WPFSampleTextBoxListNotification.Views
{
    public partial class NormalWindow : Window
    {
        public NormalWindow()
        {
            InitializeComponent();

            DataContext = new NormalWindowViewModel();
        }
    }
}
