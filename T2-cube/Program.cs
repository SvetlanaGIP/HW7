using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_cube
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Создать метод для вычисления объема и площади поверхности куба по длине его ребра. */
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());            
            double S, V;
            GetParam(a, out V, out S);
            Console.WriteLine("Площадь поверхности куба = {0}", S);        
            Console.WriteLine("Объём куба = {0}", V);
            Console.ReadKey();
        }
        static void GetParam(int a, out double V, out double S)
        {
            int s = a*a;
            S = s*6;
            V = s * a;
        }
    }
}
