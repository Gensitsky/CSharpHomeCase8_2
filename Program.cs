/*
    Создать необобщенный класс точки в трехмерном
    пространстве с целочисленными координатами (Point3D),
    который наследуется от generic-класса Point2D<T>, рас-
    смотренного в уроке. Реализовать в классе:
    1) конструктор с параметрами, который принимает на-
    чальные значения для координат точки;
    2) метод ToString().
 */
using System;

namespace CSharpHomeCase8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D<int> p1 = new Point2D<int>(10, 20);
            Console.WriteLine("x = {0} y = {1}", p1.X, p1.Y);
            Point2D<double> p2 = new Point2D<double>(10.5, 20.5);
            Console.WriteLine("x = {0} y = {1}", p2.X, p2.Y);
            Console.WriteLine(typeof(Point2D<int>).ToString());
            Console.WriteLine(typeof(Point2D<double>).ToString());

            Console.WriteLine("\nTest of non generic child - Point3D class\n");

            Point3D w1 = new Point3D(4, 7, 9);
            Console.WriteLine(w1);

            Console.ReadKey();
        }
    }
}
