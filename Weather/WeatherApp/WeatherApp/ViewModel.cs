using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp;

namespace WeatherApp
{
    public class ViewModel : INotifyPropertyChanged
    {
        private DataService model;
        private Weather currentWeather;

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel(DataService model)
        {
            this.model = model;
        }

        public Weather CurrentWeather
        {
            get
            {
                return currentWeather;
            }
            private set
            {
                currentWeather = value;
                NotifyPropertyChanged("CurrentWether");
            }
        }
        private void NotifyPropertyChanged(string property)
        {
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
