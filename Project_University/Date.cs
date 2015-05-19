using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_University
{
    class Date
    {
        int day, month, year;

        public Date()
        {
            day = month = year = 0;
        }

        public Date(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }
    }
}
