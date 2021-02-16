using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica {
    public abstract class Instrumento {
        public Instrumento() {            
        }
        public abstract string Tocar();        
    }

    public class Guitarra : Instrumento {
        public Guitarra() {
        }
        public override string Tocar() {
            return "Guitarra";
        }
    }

    public class Violin : Instrumento {
        public override string Tocar() {
            return "violin";
        }
    }
}