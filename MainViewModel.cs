using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Hillel_Lesson27_HW_4
{
    public partial class MainViewModel : INotifyPropertyChanged

    {
        private double _number;
        private double _result;

        public double Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));

            }
        }

        public double Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));

            }
        }

        public ICommand CalculateSinX { get; }
        public ICommand CalculateCosX { get; }
        public ICommand CalculateXFactorial { get; }

        public MainViewModel()
        {
            CalculateSinX = new RelayCommand(GetSin);
            CalculateCosX = new RelayCommand(GetCos);
            CalculateXFactorial = new RelayCommand(GetFactorial);
        }


        private void GetSin()
        {
            Result = Math.Sin(Number * Math.PI / 180);
        }

        public void GetCos()
        {
            Result = Math.Cos(Number * Math.PI / 180);
        }

        public void GetFactorial()
        {

            int temp = 0;
            int res = 1;

            for (int i = 0; i < Number; i++)
            {
                res *= (Int32)Number - temp;
                temp++;
            }

            Result = res;

        }


        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

