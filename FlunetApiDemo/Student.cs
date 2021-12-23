using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlunetApiDemo
{
    public  class Student
    {
        public string Name { get; set; }=string.Empty;

        public decimal Height { get; set; } 

        public decimal Weight { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
