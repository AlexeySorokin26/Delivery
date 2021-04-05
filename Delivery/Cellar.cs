using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery
{
    class Cellar : Phone
    {
        private string number;
        private string code;
        private string subscriber;
        public Cellar(string? code, string? subscriber)
        {
            // cellar phone should have +7, +49 only in such case
            if(code != null && (code == "+49" || code == "+7"))
            {
                this.code = code;
            }
            if(subscriber != null)
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
            set {
                if (value == "+49" || value == "+7")
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
