using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_University
{
    class Passport
    {
        int series;
        int number;
        int subdivisionCode;
        string passportOffice;
        Date releaseDate;
        string birthPlace;
        string address;

        public Passport(int _series, int _number, int _subdivisionCode, 
                        string _passportOffice, Date _releaseDate, string _birthPlace, string _address)
        {
            series = _series;
            number = _number;
            subdivisionCode = _subdivisionCode;
            passportOffice = _passportOffice;
            releaseDate = _releaseDate;
            birthPlace = _birthPlace;
            address = _address;
        }
    }
}
