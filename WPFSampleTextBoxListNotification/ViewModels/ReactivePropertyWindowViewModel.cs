using Prism.Mvvm;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using WPFSampleTextBoxListNotification.Models;

namespace WPFSampleTextBoxListNotification.ViewModels
{
    public class ReactivePropertyWindowViewModel : BindableBase
    {
        public ReactiveProperty<string> Title { get; set; }
            = new ReactiveProperty<string>("Prism + ReactiveProperty");

        public ReactiveCollection<NumberReactiveProperty> Numbers { get; }
            = new ReactiveCollection<NumberReactiveProperty>();

        public ReactiveProperty<int> Total { get; } = new ReactiveProperty<int>();

        public ReactivePropertyWindowViewModel()
        {
            var list = new ObservableCollection<NumberReactiveProperty>()
            {
                new NumberReactiveProperty(100),
                new NumberReactiveProperty(200),
                new NumberReactiveProperty(300),
            };

            Numbers
                .ObserveElementObservableProperty(x => x.Amount)
                .Subscribe(x =>
                {
                    Total.Value = Numbers.Sum(y => y.Amount.Value);
                });
            Numbers.AddRange(list);
        }
    }
}
