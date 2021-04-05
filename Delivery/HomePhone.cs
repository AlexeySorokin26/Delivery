using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery
{
    class HomePhone : Phone
    {
        private string number;
        private string code;
        private string subscriber;
        public HomePhone(string code, string subscriber)
        {
            // cellar phone should have +7, +49 only in such case
            if (code != null && (code == "+495" || code == "+499"))
            {
                this.code = code;
            }
            if (subscriber != null)
            {
                this.subscriber = subscriber;
            }
            this.number = this.code + this.subscriber;
        }
        public override string Number
        {
            get { return number; }
        }
        public string Code
        {
            get { return code; }
            set
            {
                if (value == "+495" || value == "+499")
                {
                    this.code = value;
                }
                else
                {
                    code = "0";
                }
            }
        }
        public string Subscriber
        {
            get { return subscriber; }
            set { this.subscriber = value; }
        }
    }
}
