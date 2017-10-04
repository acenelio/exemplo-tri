using System;
using System.Globalization;

namespace exemplo {
    class Program {
        static void Main(string[] args) {

            double area1, area2, p;
            Triangulo t1, t2;
            t1 = new Triangulo();
            t2 = new Triangulo();

            string[] s = Console.ReadLine().Split(' ');
            t1.a = double.Parse(s[0], CultureInfo.InvariantCulture);
            t1.b = double.Parse(s[0], CultureInfo.InvariantCulture);
            t1.c = double.Parse(s[0], CultureInfo.InvariantCulture);

            s = Console.ReadLine().Split(' ');
            t2.a = double.Parse(s[0], CultureInfo.InvariantCulture);
            t2.b = double.Parse(s[0], CultureInfo.InvariantCulture);
            t2.c = double.Parse(s[0], CultureInfo.InvariantCulture);

            p = (t1.a + t1.b + t1.c) / 2.0;
            area1 = Math.Sqrt(p * (p - t1.a) * (p - t1.b) * (p - t1.c));

            p = (t2.a + t2.b + t2.c) / 2.0;
            area2 = Math.Sqrt(p * (p - t2.a) * (p - t2.b) * (p - t2.c));

            Console.WriteLine("Area do triangulo 1: " + area1.ToString("F2"));
            Console.WriteLine("Area do triangulo 2: " + area2.ToString("F2"));

            Console.ReadLine();
        }
    }
}
