using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd1
{
    class Program
    {
        static void Main(string[] args)
        {
            double var;

            Console.Write("viberit variant a/b (a=1, b=2): ");
            var = Convert.ToDouble(Console.ReadLine());

            //var 1
            if (var == 1)
            {
                double xp, xk, sh, x, y;

                Console.Write("vvedit x po4atkove: ");
                xp = Convert.ToDouble(Console.ReadLine());

                Console.Write("vvedit x kinceve: ");
                xk = Convert.ToDouble(Console.ReadLine());

                Console.Write("vvedit krok: ");
                sh = Convert.ToDouble(Console.ReadLine());

                x = xp;

                while (xp <= x  && x <= xk)
                {
                    y = Math.Pow(Math.Sin(x), 2) / Math.Pow(x + 1, 2);

                    Console.WriteLine("___________________________________________");
                    Console.WriteLine($"x = {x} | y = {y}");

                    x += sh;
                }

                Console.WriteLine("end");
                Console.ReadKey();
            }

            //var 2
            else if (var == 2)
            {
                double xp, x, sh, n, i, y;

                i = 0;

                Console.Write("vvedit x po4atkove: ");
                xp = Convert.ToDouble(Console.ReadLine());

                Console.Write("vvedit x: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("vvedit krok: ");
                sh = Convert.ToDouble(Console.ReadLine());

                Console.Write("vvedit kilkist to4ok: ");
                n = Convert.ToDouble(Console.ReadLine());

                while (xp <= x && i < n)
                {
                    y = Math.Pow(Math.Sin(x), 2) / Math.Pow(x + 1, 2);

                    Console.WriteLine("___________________________________________");
                    Console.WriteLine($"x = {x} | y = {y}");

                    x += sh;
                    i++;
                }

                Console.WriteLine("end");
                Console.ReadKey();
            }

            //nevirni var
            else
            {
                Console.WriteLine("nema takogo varianta");
                Console.ReadKey();
            }

        }
    }
}
