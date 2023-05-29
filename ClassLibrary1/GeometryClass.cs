using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class GeometryClass
    {
        public static double AreaTriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2.0;

            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }

        public static double CalculateRightTriangleArea(double leg1, double leg2)
        {
            double area = (leg1 * leg2) / 2;
            return area;
        }

        public static double AreaRectangle(double len, double widht)
        {
            return len * widht;
        }

        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double TrapezeSquare(double a, double b, double h)
        {
            return (a + b) / h * 2;
        }
    }
}
