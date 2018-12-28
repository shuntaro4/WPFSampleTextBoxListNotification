using System;
using System.ComponentModel;

namespace WPFSampleTextBoxListNotification.Models
{
    public class Number : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        private int _amount;
        public int Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));

                _amountChangedNotification?.Invoke();
            }
        }

        private Action _amountChangedNotification = null;

        public Number(int amount, Action amountChangedNotification = null)
        {
            Amount = amount;
            _amountChangedNotification = amountChangedNotification;
        }
    }
}
