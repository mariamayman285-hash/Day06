using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    #region Problem 6
    internal class EmployeeClass
    {
        public int X;
        public int Y;

        public void ChangeEmployee(EmployeeClass e)
        {
            e.X = 10;
            e.Y = 10;
        }
    } 
    #endregion
}
