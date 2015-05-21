using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Accounts
    {
        Date openingDate;
        string number;
        string currency;   //валюта
        double balance;
        bool isOpened;
        bool isBlocked;
        string accountType;

        public Accounts(Date _openingDate, string _number, string _currency, double _balance, bool _isOpend, bool _isBlocked, string _accountType) 
        {
            openingDate = _openingDate;
            number = _number;
            currency = _currency;
            balance = _balance;
            isOpened = _isOpend;
            isBlocked = _isBlocked;
            accountType = _accountType;
        } 
    }
}
