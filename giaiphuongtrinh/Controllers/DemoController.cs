using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap2.Models
{
    public class GiaiPhuongTrinh
    {
        public double Timx(double x, double y)
        {
            double GTX = 0;
           GTX = -x / y;
            return GTX;
        }
    }
}