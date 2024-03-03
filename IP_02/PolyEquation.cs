using System;
using System.Collections.Generic;
using System.Text;

namespace IP_02
{
    class PolyEquation : IEquation
    { 
        private EquationType _eqType;
        private double _x0;
        private double _x1;
        private double _x2;

        public PolyEquation(double x2, double x1, double x0)
        {
            _x2 = x2;
            _x1 = x1;
            _x0 = x0;
        }

        public String Solve()
        {
            double delta = _x1 * _x1 - 4 * _x0 * _x2;
            string info = "";
            if (_x2 == 0)
            {
                _eqType = EquationType.FirstDegree;
                double sol = -_x0 / _x1;
                info = "x = " + sol.ToString();
            }
            else if (delta > 0)
            {
                double sqrtDelta = Math.Sqrt(delta);
                double sol1 = (-_x1 + sqrtDelta) / (2.0 * _x2);
                double sol2 = (-_x1 - sqrtDelta) / (2.0 * _x2);
                info = "x1 = " + sol1.ToString() + "; x2 = " + sol2.ToString();
            }
            else if (delta == 0)
            {
                double sol = (-_x1) / (2.0 * _x2);
                info = "x = " + sol.ToString();
            }
            else
            {
                double rsol = -_x1 / (2.0 * _x2);
                double isol = Math.Sqrt(-delta) / (2.0 * _x2);
                double sol1 = rsol + isol;
                double sol2 = rsol - isol;
                info = "x1 = " + rsol.ToString() + " + " + isol.ToString() + "*i;  x2 = " + rsol.ToString() + " - " + isol.ToString() + "*i";
            }

            return info;
        }

        private enum EquationType
        {
            FirstDegree,
            SecondDegree
        }

    }
}
