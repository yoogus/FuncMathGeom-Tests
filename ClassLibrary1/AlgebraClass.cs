using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AlgebraClass
    {
        public static Tuple<double, double> SquareEquation(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return null;
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return new Tuple<double, double>(root, root);
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new Tuple<double, double>(root1, root2);
            }
        }

        public static double SolveLinearEquation(double a, double b)
        {
            if (a == 0 && b == 0)
            {
                return double.PositiveInfinity; 
            }
            else if (a == 0)
            {
                return double.NaN; 
            }
            else
            {
                double x = -b / a;
                return x; 
            }
        }

        public static double SeriesSum(params double[] values)
        {
            double sum = 0;

            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return sum;
        }

        public static double MaxSeriesSum(params double[] values)
        {
            double max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }

            return max;
        }

        public static double AverageSeriesSum(params double[] values)
        {
            double sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            double average = (double)sum / values.Length;
            return average;
        }
    }
}
