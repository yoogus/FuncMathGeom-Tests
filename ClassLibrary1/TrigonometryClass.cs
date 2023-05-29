using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TrigonometryClass
    {
        public static double CalculateSins(double x1)
        {
            return Math.Sin(x1);
        }

        public static double CalculateCos(double x1)
        {
            return Math.Cos(x1);
        }

        public static double CalculateTg(double x1)
        {
            return Math.Tan(x1);
        }

        public static double CalculateCtg(double x1)
        {
            return 1 / Math.Tan(x1);
        }

        public static double CalculateAsin(double x1)
        {
            return Math.Asin(x1);
        }
    }
}
