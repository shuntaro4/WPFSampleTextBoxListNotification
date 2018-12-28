using Prism.Mvvm;
using Reactive.Bindings;

namespace WPFSampleTextBoxListNotification.Models
{
    public class NumberReactiveProperty : BindableBase
    {
        public ReactiveProperty<int> Amount { get; set; } = new ReactiveProperty<int>();

        public NumberReactiveProperty(int amount)
        {
            Amount.Value = amount;
        }
    }
}
