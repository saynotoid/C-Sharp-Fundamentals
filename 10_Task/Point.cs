using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Task
{
    public struct Point()
    {
        private double x;
        private double y;

        public double X
        {
            get => x; set { x = value; }
        }

        public double Y
        {
            get => y; set { y = value; }
        }

        public override string ToString()
        {
            return string.Format($"({x},{y})");
        }
    }
}
