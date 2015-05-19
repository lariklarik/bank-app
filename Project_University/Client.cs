using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_University
{
    class Client
    {
        string firstName;
        string middleName;
        string lastName;
        Date birthDate;
        char gender;
        string INN;
        string BIK;
        Account[] accounts;
        Passport passport;

        public Client(string _firstName, string _middleName, string _lastName,
            Date _birthDate, char _gender, string _INN, string _BIK, Account[] _accounts, Passport _passport)
        {
            firstName = _firstName;
            middleName = _middleName;
            lastName = _lastName;
            birthDate = _birthDate;
            gender = _gender;
            INN = _INN;
            BIK = _BIK;
            accounts = _accounts;
            passport = _passport;
        }
    }
}
