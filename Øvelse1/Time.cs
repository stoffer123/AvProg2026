using System;
using System.Collections.Generic;
using System.Text;

namespace Øvelse1
{
    internal struct Time
    {
        public int Hour
        {
            get
            {
                return _secondsSinceMidnight / 3600;
            }
            set
            {
                UpdateSecondsSinceMidnight(value, Minutes, Seconds);
            }
        }

        public int Minutes
        {
            get
            {
                return (_secondsSinceMidnight % 3600) / 60;
            }
            set
            {
                UpdateSecondsSinceMidnight(Hour, value, Seconds);
            }
        }

        public int Seconds
        {
            get
            {
                return _secondsSinceMidnight % 60;
            }
            set
            {
                UpdateSecondsSinceMidnight(Hour, Minutes, value);
            }
        }

        private int _secondsSinceMidnight;

        

        public Time(int hours, int minutes, int seconds)
        {
            _secondsSinceMidnight = 0;
            UpdateSecondsSinceMidnight(hours, minutes,  seconds);
        }

        public Time(string time)
        {
            _secondsSinceMidnight = 0;
            int hours = int.Parse(time.Substring(0, 2));
            int minutes = int.Parse(time.Substring(3, 2));
            int seconds = int.Parse(time.Substring(6, 2));
            UpdateSecondsSinceMidnight(hours, minutes, seconds);
        }

        public override string ToString()
        {
            return $"{Hour:D2}:{Minutes:D2}:{Seconds:D2}";
        }


        private void UpdateSecondsSinceMidnight(int hours = 0, int minutes = 0, int seconds = 0)
        {
            _secondsSinceMidnight = (hours * 3600) + (minutes* 60) + seconds;
        }
    }
}
