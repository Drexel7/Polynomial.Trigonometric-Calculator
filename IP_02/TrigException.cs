using System;
using System.Collections.Generic;
using System.Text;

namespace IP_02
{
    class TrigException : Exception
    {
        private double _argument;
        private string _message;

        public string Message
        {
            get
            {
                return _message;
            }
        }

        public TrigException(string message, double argument) : base(message)
        {
            _message = message;
            _argument = argument;
        }
    }
}
