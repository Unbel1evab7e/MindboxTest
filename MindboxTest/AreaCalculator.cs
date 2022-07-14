using System.Threading.Tasks;

namespace MindboxTest
{
    public static class AreaCalculator
    {
        public static async Task<double> Calculate(IShape shape)
        {
            var result = double.MinValue;

            await Task.Run(() =>
            {
                result = shape.GetAreaValue();
            });

            return result;
        }
    }
}