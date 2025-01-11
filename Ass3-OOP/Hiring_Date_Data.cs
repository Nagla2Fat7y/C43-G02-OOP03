using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
	class Hiring_Date_Data
    {
        private int day;
        private int month;
        private int year;

        public Hiring_Date_Data(int _day, int _month, int _year)
        {
            day=(_day >= 32 || _day <= 0) ? 1 : _day;
            month = (_month >= 13 || _month <= 0) ? 1 : _month;
            year = (_year <= 1000) ? 1000 : _year;
        }
        public int Year
        {
            get { return year; }
            set { year = (value <= 1000) ? 1000 : value; }
        }
        public int Month
        {
            get { return month; }
            set { month = (value >= 13 || value <= 0) ? 1 : value; }
        }
        public int Day
        {
            get { return day; }
            set { day = (value >= 32 || value <= 0) ? 1 : value; }
        }

        public override string ToString()
        {
            return $"{day}-{month}-{year}";
        }
    }
}
