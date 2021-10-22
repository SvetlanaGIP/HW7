using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Два треугольника заданы длинами своих сторон. 
             * Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон). 
             * Для решения задачи можно использовать формулу Герона , где x, y, z – стороны треугольника, p – полупериметр. */
            Console.WriteLine("Введите длины сторон треугольника 1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int z1 = Convert.ToInt32(Console.ReadLine());
            double p1, S1;
            GetParam(x1, y1, z1, out p1, out S1);
            
            Console.WriteLine("Введите длины сторон треугольника 2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int z2 = Convert.ToInt32(Console.ReadLine());
            double p2, S2;
            GetParam(x2, y2, z2, out p2, out S2);
            
            if (S2>S1)
                Console.WriteLine("Площадь второго треугольника больше первого");
            else if (S1 > S2)
                Console.WriteLine("Площадь первого треугольника больше второго");
            else
                Console.WriteLine("Площади равны");
            Console.ReadKey();
        }
        static void GetParam(int x, int y, int z, out double p, out double S)
        {
            p = (x + y + z)/2;
            S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }
        
    }
}
