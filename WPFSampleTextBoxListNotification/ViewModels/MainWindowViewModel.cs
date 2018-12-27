using Prism.Mvvm;

namespace WPFSampleTextBoxListNotification.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "WPF Sample App";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
