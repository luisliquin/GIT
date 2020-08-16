using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacion
{
    public class Division  {
        public Action<int,int> MessageHandler;
        public int Divide(int a, int b) {
            int result = 0;
            if (b!=0) {
                result=a/b;
            }
            else {
                MessageHandler(a, b);
            }
            return result;
        }
    }
}