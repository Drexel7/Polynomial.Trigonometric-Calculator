using System;
using System.Collections.Generic;
using System.Text;

namespace IP_02
{
    class TrigEquation : IEquation
    {

        private double _arg;
        private EcuatieTrig _function;




        public string Solve()
        {
            if (_function == EcuatieTrig.Sin)
            {
                int grade;
                grade = (int)(Math.Asin(_arg) * 180 / Math.PI);

                if (Math.Abs(_arg) > 1)
                {
                    return "Argument invalid";
                }
                else
                    return "x= " + grade;
            }
            if (_function == EcuatieTrig.Cos)
            {
                int grade;
                grade = (int)(Math.Asin(_arg) * 180 / Math.PI);

                if (Math.Abs(_arg) > 1)
                {
                    return "Argument invalid";
                }
                else
                    return "x= " + grade;
            }

            else
            {
                int grade;
                grade = (int)(Math.Asin(_arg) * 180 / Math.PI);
                return "x= " + grade;
            }
        }

        public TrigEquation(EcuatieTrig tf, double argument)
        {
            _function = tf;
            _arg = argument;
        }

        public enum EcuatieTrig
        {
            Sin,
            Cos,
            Tan
        }

    }

}

