using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SquareEquation
    {
        //ax^2+bx+c=0
        //задание коэффициентов abc
        //получение значений коэффициентов abc
        //получение количества значений и корней уравнения
        //корни хранятся и пересчитываются только при необходимости
        //D=b^2-ac
        //D>0 два корня
        //D=0 один корень
        //D<0 корней не имеет
        //x=(-b+-sqrt(b^2-4ac) )/2a
        double a, b, c, d, x1, x2;
        double root1, root2;
        int n;
        public SquareEquation()
        {
            Console.WriteLine("Введите значение a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение c: ");
            c = Convert.ToInt32(Console.ReadLine());
            this.RefreshRoots();
        }
        public void GetCurrValues()
        {
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
            
        }

        public double GetDiscr(double a, double b, double c)
        {
            double d;
            d = b * b - 4* a * c;
            return d;
        }
        public int GetNumOfRoots()
        {
            if (GetDiscr(a, b, c) > 0)
                return 2;
            else if (GetDiscr(a, b, c) == 0)
                return 1;
            else
                return 0;
        }
        public void RefreshRoots()
        {
            if (GetNumOfRoots() > 0)
            {
                //
                root1 = (-b + Math.Sqrt(this.GetDiscr(a,b,c)))/ (2 * a);
                //
                root2 = (-b - Math.Sqrt(this.GetDiscr(a,b,c))) / (2 * a);
            }
        }
        public string ShowRoots()
        {
            return root1 + "; " + root2;
        }
    }
}
