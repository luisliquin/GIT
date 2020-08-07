using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo

{
    public class Cafetera {
        public int minCafe = 2;
        public int maxCafe = 35;
        private int cafe = 7;

        public bool LlenarCafetera(int cantidad) {
            if (cafe + cantidad > minCafe)
            {
                cafe = cafe + cantidad;
                return true;
            }
            else {
                return false;
            }
        }

        public void ServirCafe() {
            if (cafe > minCafe){
                cafe = cafe - 2;
                Console.WriteLine("se sirvio cafe");
            }
            else {
                Console.WriteLine("|||| No hay mas cafe para servir.");
            }
        }

        public int CantidadActualCafe() {
            return cafe;
        }
    }
}