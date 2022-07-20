using System;
using System.Threading.Tasks;
using Mindbox.Library;

namespace Mindbox.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle{Radius = 2};
            var triangle = new Triangle { Sides = new []{5,3,6}};
            Console.WriteLine(AreaCalculator.Calculate(circle));
            Console.WriteLine( "-----------------------------------------");
            Console.WriteLine(AreaCalculator.Calculate(triangle));
        }
    }
}