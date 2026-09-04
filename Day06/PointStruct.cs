using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    #region Problem 6
    internal struct PointStruct
    {
        public int X;
        public int Y;

        public void ChangePoint(PointStruct p)
        {
            p.X = 10;
            p.Y = 10;
        }
    } 
    #endregion
}
