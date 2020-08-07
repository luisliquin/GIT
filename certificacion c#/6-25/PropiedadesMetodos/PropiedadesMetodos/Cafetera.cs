using System;
using System.Collections.Generic;
using System.Text;

namespace PropiedadesMetodos {
    public class Cafetera {
        int _id;
        double _mincafe;
        double _cafe;

        public string codigo {
            get { return "CAFET000" + _id;}
            set { _id = int.Parse(value);}
        }

        public double MinCafe {
            get { return _mincafe;}
        }

        public double Cafe {
            get { return _cafe; }
            set { _cafe = value; }
        }
    }
}