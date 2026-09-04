using common1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    #region Problem 2 testing
    internal class TypeA : Class1
    {
        Class1 n = new Class1();
        public void Print()
        {
            //n.F = 10;
            //n.G = 10;
            n.H = 10;
        }
    } 
    #endregion
}
