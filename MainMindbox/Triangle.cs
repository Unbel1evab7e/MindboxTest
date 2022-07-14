using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindboxTest
{
    public class Triangle: IShape
    {
        private int[] _sides;
        public int[] Sides
        {
            get => _sides;
            set
            {
                if (value.Length != (int)ShapesEnum.TriangleSidesCount)
                    throw new ShapeException("Sides count don`t match to this shape", GetType());

                _sides = value;
            }
        } 

        public double GetAreaValue()
        {
            
            
            if (Sides == null)
                throw new ShapeException("Sides not initialized", GetType());
            
            var sortedSides = Sides
                .OrderByDescending(x => x)
                .ToArray();
            
            var expression = Math.Pow(sortedSides.FirstOrDefault(), 2) ==
                             sortedSides.Skip(1).Select(side => Math.Pow(side, 2)).Sum();

            if (expression)
                return 0.5d * sortedSides.Skip(1).FirstOrDefault() * sortedSides.Skip(1).LastOrDefault();

            var semiPerimeter = 0.5 * sortedSides.Sum();

            var multiplySemiPerimeterDifferenseWithSide = 1.0d;

            foreach (var side in sortedSides)
            {
                multiplySemiPerimeterDifferenseWithSide *= semiPerimeter - side;
            }

            var area = Math.Sqrt(semiPerimeter * multiplySemiPerimeterDifferenseWithSide);

            return area;
        }
    }
    
}