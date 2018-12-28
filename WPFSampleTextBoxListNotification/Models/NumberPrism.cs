using Prism.Mvvm;
using System;

namespace WPFSampleTextBoxListNotification.Models
{
    public class NumberPrism : BindableBase
    {
        private int _amount;
        public int Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                SetProperty(ref _amount, value);

                _amountChangedNotification?.Invoke();
            }
        }

        private Action _amountChangedNotification = null;

        public NumberPrism(int amount, Action amountChangedNotification = null)
        {
            Amount = amount;
            _amountChangedNotification = amountChangedNotification;
        }
    }
}
