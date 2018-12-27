using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WPFSampleTextBoxListNotification.ViewModels
{
    public class NormalWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public string _title = "素のWPF";
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public ObservableCollection<int> _numbers;
        public ObservableCollection<int> Numbers
        {
            get => _numbers;
            set
            {
                _numbers = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public int _total;
        public int Total
        {
            get => _total;
            set
            {
                _total = value;
                OnPropertyChanged(nameof(Total));
            }
        }

        public NormalWindowViewModel()
        {

        }
    }
}
