using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Linq;
using WPFSampleTextBoxListNotification.Models;

namespace WPFSampleTextBoxListNotification.ViewModels
{
    public class PrismWIndowViewModel : BindableBase
    {
        public string _title = "Prism";
        public string Title
        {
            get => _title;
            set
            {
                SetProperty(ref _title, value);
            }
        }

        public ObservableCollection<Number> _numbers;
        public ObservableCollection<Number> Numbers
        {
            get => _numbers;
            set
            {
                SetProperty(ref _numbers, value);
            }
        }

        public int Total
        {
            get => Numbers.Sum(x => x.Amount);
        }

        public PrismWIndowViewModel()
        {
            var list = new ObservableCollection<Number>()
            {
                new Number(100, () => RaisePropertyChanged(nameof(Total))),
                new Number(200, () => RaisePropertyChanged(nameof(Total))),
                new Number(300, () => RaisePropertyChanged(nameof(Total))),
            };

            Numbers = list;
        }
    }
}
