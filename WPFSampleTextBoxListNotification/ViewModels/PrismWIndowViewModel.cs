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

        public ObservableCollection<NumberPrism> _numbers;
        public ObservableCollection<NumberPrism> Numbers
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
            var list = new ObservableCollection<NumberPrism>()
            {
                new NumberPrism(100, () => RaisePropertyChanged(nameof(Total))),
                new NumberPrism(200, () => RaisePropertyChanged(nameof(Total))),
                new NumberPrism(300, () => RaisePropertyChanged(nameof(Total))),
            };

            Numbers = list;
        }
    }
}
