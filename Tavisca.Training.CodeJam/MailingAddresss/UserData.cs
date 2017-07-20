using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingAddresss
{
    class UserData
    {
        private string _name;

        private string _cityName;

        private string _street;

        private int _pinCode;

        private int _houseNo;

        public string Name { get { return _name; } set { _name = value; } }

        public string CityName { get { return _cityName; } set { _cityName = value; } }

        public string Street { get { return _street; } set { _street = value; } }

        public int PinCode { get { return _pinCode; } set { _pinCode = value; } }

        public int HouseNo { get { return _houseNo; } set { _houseNo = value; } }

    }
}
