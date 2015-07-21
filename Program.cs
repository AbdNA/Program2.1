using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ring
{
    class Ring
    {
        double r, R ;
        double x, y;
        double PI = 3.14159265359;
        double a, b;

        // метод для ввода данных
        public void insert()
        {
            Console.Write("Малый радиус: ");
            r = double.Parse(Console.ReadLine());
            Console.Write("Большой радиус: ");
            R = double.Parse(Console.ReadLine());
            Console.Write("Координата X центра :");
            x = double.Parse(Console.ReadLine());
            Console.Write("Координата Y центра :");
            y = double.Parse(Console.ReadLine());
            Console.Write("Координата X точки :");
            a = double.Parse(Console.ReadLine());
            Console.Write("Координата Y точки :");
            b = double.Parse(Console.ReadLine());
        }

        // вычисление площади и толщины кольца
        public double Pl()
        {
            double s = PI * (Math.Pow(R, 2) - Math.Pow(r, 2));
            return s;
        }
        public double width()
        {
            double width = R - r;
            return width;
        }
        // расчет количества квадрантов
        public int quarters()
        {
            int q = 0;
            double c = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if ( x == 0 &&  y == 0 ) q = 4;
            if ( x > R )  q = 2;
            if ( x > R &&  y > R)  q = 1;
            if ( x > c && R > x  && R > y ) q = 3;
            return q;

        }

        // Закрытый метод для проверки попадания точки в кольцо
        private bool dot()
        {
            double width = R - r;
            double c = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            double m = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            if ( (c - width) > m) 
                return true;
            else
                return false;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Класс Ring (Кольцо)");
            Ring x = new Ring();
            x.insert();
            double s = x.Pl();
            Console.WriteLine("Площадь кольца s={0}", s);
            double width = x.width();
            Console.WriteLine("Толщина кольца width={0}", width);
            int q = x.quarters();
            Console.WriteLine("Количество квандрантов, в которых присутствует кольцо q={0}", q);
            Console.ReadKey(true);

        }
    }
}