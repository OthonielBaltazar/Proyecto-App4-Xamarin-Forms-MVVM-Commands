using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App4.ViewModels
{
    public class CountViewModel : BaseViewModel
    {
        int _contador;
        ICommand _buttonClickCommand;
        ICommand _resetClickCommand;
        string _countConverted;
        public CountViewModel()
        {
            _contador = 0;
        }
        public int Contador { get => _contador;
            set  {
                if (value == _contador) return;
                    _contador = value;
                CountConverted = $"Has dado click {_contador} veces ";
                    OnPropertyChanged();
                OnPropertyChanged(nameof(CountConverted));
            }
        }

        public string CountConverted
        {
            get => _countConverted;
            set
            {
                if (String.Equals(_countConverted, value)) return;
                _countConverted = value;
                OnPropertyChanged();
            }
        }

        public ICommand ButtonClickCommand
        {
            get {
                if (_buttonClickCommand == null)

                    _buttonClickCommand = new Command(ButtonClickAction);
                return _buttonClickCommand;
            }
                
        }

        public ICommand ResetClickCommand
        {
            get
            {
                if (_resetClickCommand == null)

                    _resetClickCommand = new Command(ResetAction);
                return _resetClickCommand;
            }

        }

        private void ResetAction()
        {
            Contador = 0;
            CountConverted = "Has reiniciado el contador";
        }

        private void ButtonClickAction()
        {
            Contador++;
        }
    }
}
