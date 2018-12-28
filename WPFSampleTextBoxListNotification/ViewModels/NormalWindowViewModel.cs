using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using WPFSampleTextBoxListNotification.Models;

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

        public ObservableCollection<Number> _numbers;
        public ObservableCollection<Number> Numbers
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
            get => Numbers.Sum(x => x.Amount);
        }

        public NormalWindowViewModel()
        {
            var list = new ObservableCollection<Number>()
            {
                new Number(100, () => OnPropertyChanged(nameof(Total))),
                new Number(200, () => OnPropertyChanged(nameof(Total))),
                new Number(300, () => OnPropertyChanged(nameof(Total))),
            };

            Numbers = list;
        }
    }
}
