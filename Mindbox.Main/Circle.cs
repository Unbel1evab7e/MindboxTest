using System;
using System.Threading.Tasks;

namespace Mindbox.Library
{
    public class Circle: IShape
    {
        public int? Radius { get; set; }
        public double GetAreaValue()
        {
            if (!Radius.HasValue)
                throw new ShapeException("Radius is null",GetType());
            
            var result = Math.Pow(Radius.Value, 2) * Math.PI;

            return result;
        }
    }
}