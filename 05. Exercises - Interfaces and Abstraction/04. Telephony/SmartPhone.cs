using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class SmartPhone : ICallable, IBrowsable
    {
        private string phoneNumber;
        private string www;

        public string PhoneNumber
        { 
            get
            {
                return phoneNumber;
            }
            set
            {
                if (!value.All(char.IsDigit))
                {
                    throw new ArgumentException("Invalid number!");
                }
                phoneNumber = value;
            }
        }
        public string Www
        {
            get
            {
                return www;
            }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    throw new ArgumentException("Invalid URL!");
                }
                www = value;
            }
        }


        public string Calling()
        {
            return $"Calling... {PhoneNumber}";
        }

        public string Browsig()
        {
            return $"Browsing: {Www}!";
        }
    }
}
