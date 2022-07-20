using System.Threading.Tasks;

namespace Mindbox.Library
{
    public static class AreaCalculator
    {
        public static double Calculate(IShape shape)
        {
            var result = shape.GetAreaValue();
            
            return result;
        }
    }
}