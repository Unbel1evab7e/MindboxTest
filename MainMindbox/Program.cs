using System;
using System.Threading.Tasks;
using MindboxTest;

namespace MainMindbox
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var circle = new Circle{Radius = 2};
            var triangle = new Triangle { Sides = new []{5,3,6}};
            Console.WriteLine( await AreaCalculator.Calculate(circle));
            Console.WriteLine( "-----------------------------------------");
            Console.WriteLine( await AreaCalculator.Calculate(triangle));
        }
    }
}