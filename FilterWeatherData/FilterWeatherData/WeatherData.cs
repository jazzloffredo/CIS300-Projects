using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterWeatherData
{
    class WeatherData
    {
        private DateTime _date;
        private double _avgTemp;

        public WeatherData()
        {
            _date = default(DateTime);
            _avgTemp = default(double);
        }

        public WeatherData(DateTime dt, double temp)
        {
            _date = dt;
            _avgTemp = temp;
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }
        }

        public double AvgTemp
        {
            get
            {
                return _avgTemp;
            }
        }

        public override string ToString()
        {
            return _date.ToLongDateString() + ": " + this.AvgTemp.ToString("##.#") + " degrees";
        }

        public bool EqualsDate(object obj)
        {
            WeatherData other = obj as WeatherData;
            if (this.Date.CompareTo(other.Date) == 0) return true;
            else return false;
        }

        public bool EqualsTemp(object obj)
        {
            WeatherData other = obj as WeatherData;
            if (this.AvgTemp == other.AvgTemp) return true;
            else return false;
        }
    }
}
