using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    #region Problem 3
    internal struct Employee
    {
        private int empId;  //no need to it i will put it in auto property
        private string Name;
        private decimal salary;

        //the long way
        public string GetName()
        {
            return Name;
        }
        public void SetName(string value)
        {
            Name = value;
        }

        //OR property way
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        //Or with Auto property
        public int EmpId { get; set; }

    } 
    #endregion

}
