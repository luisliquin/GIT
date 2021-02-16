using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Conversiones {
    class Persona {
        private int _id;
        private string _nombre;

        public string Id {
            get { return _id.ToString(); }
            set { _id = int.Parse(value); }
        }
        public string Nombre {
            get { return _nombre;}
        }

        public override string ToString() {
            //return base.ToString();
            return "clase manipulada por tostring()";

        }
    }
}
