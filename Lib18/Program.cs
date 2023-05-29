using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Lib18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            infoGeometry();
            infoAlgebra();
            infoTrigonometry();
            
            Console.ReadKey();
        }

        public static void infoGeometry()
        {
            Console.WriteLine("-----------Геометрия-----------");
            Console.WriteLine("Площадь треугольника: " + GeometryClass.AreaTriangle(10, 15, 10));
            Console.WriteLine("Площадь прямоугольного треугольника: " + GeometryClass.CalculateRightTriangleArea(10, 10));
            Console.WriteLine("Площадь прямоугольника: " + GeometryClass.AreaRectangle(15, 5));
            Console.WriteLine("Площадь круга: " + GeometryClass.CalculateCircleArea(8));
            Console.WriteLine("Площадь трапеции: " + GeometryClass.TrapezeSquare(9, 6, 3));
        }

        public static void infoAlgebra()
        {
            Console.WriteLine("\n-----------Алгебра-----------");
            Console.WriteLine("Корень квадратного уровнения: " + AlgebraClass.SquareEquation(1, 4, 3));
            Console.WriteLine("Корень линейного уровнения: " + AlgebraClass.SolveLinearEquation(1,5));
            double result = AlgebraClass.SeriesSum(1, 2, 3, 4, 5);
            Console.WriteLine("Сумма ряда: " + result);
            double results = AlgebraClass.MaxSeriesSum(1, 2, 3, 4, 5);
            Console.WriteLine("Максимально значение из ряда: " + results);
            double res = AlgebraClass.AverageSeriesSum(1, 2, 3, 4, 5);
            Console.WriteLine("Максимально значение из ряда: " + res);
        }

        public static void infoTrigonometry()
        {
            Console.WriteLine("\n-----------Триганометрия-----------");
            Console.WriteLine("Sin x: " + TrigonometryClass.CalculateSins(4));
            Console.WriteLine("Cos x: " + TrigonometryClass.CalculateCos(4));
            Console.WriteLine("tg x: " + TrigonometryClass.CalculateTg(4));
            Console.WriteLine("Ctg x: " + TrigonometryClass.CalculateCtg(4));
            Console.WriteLine("Asin x: " + TrigonometryClass.CalculateAsin(0.2));
        }
    }
}
