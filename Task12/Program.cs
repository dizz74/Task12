using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длина окружности {0}",MyMath.CircleLen(1.66));
            Console.WriteLine("Площадь окружности {0}", MyMath.CircleSquare(1.4));            
            Console.WriteLine("Точка 6.6,1 {0}принадлежит кругу R=5.6", MyMath.PointInCircle(6.6, 1, 1, 1, 5.6)?"":"не ");
            Console.ReadKey();
        }


        static class MyMath{

            public static double CircleLen(double R) {
                return 2 * Math.PI * R;
            }

            public static double CircleSquare(double R)
            {
                return Math.PI * R*R;
            }

            public static bool PointInCircle(double x, double y,double x0,double y0, double R)
            {
                return Math.Pow(x0-x,2)+Math.Pow(y0-y,2)==R*R;
            }
        }
    }
}
