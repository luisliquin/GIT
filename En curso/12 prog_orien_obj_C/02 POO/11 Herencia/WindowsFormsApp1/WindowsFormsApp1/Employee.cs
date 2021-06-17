using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
    class Employee :Human {
        protected string Position { get; set; }
        public double Salary { get; set; }

        public void SetValues() {
            Name="Charles";
            ID=1;
            Gender='M';
            Age=30;
        }
    }
}